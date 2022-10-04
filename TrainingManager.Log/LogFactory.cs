using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Context;
using Serilog.Exceptions;
using System;
using System.Collections.Generic;

namespace TrainingManager.Log
{
	public class LogFactory : IDisposable, ILogFactory
	{
		private const string DefaultPosgreConnectionString = "";

		public const string LogSectionName = "Log";
		public const string PgConnStrName = "PgConnStr";
		public const string FilePathName = "FilePath";

		public const string LogTableName = "smevlog";
		public const string MessageColName = "message";
		private const string LevelColName = "level";
		private const string EventTimestampColName = "event_timestamp";
		private const string ExceptionColName = "exception";
		private const string SmevMessageIdColName = "smev_message_id";
		private const string EpguOrderIdColName = "epgu_order_id";
		private const string ManualRequestIdColName = "manual_request_id";
		private const string ServiceColName = "service";
		private const string ModuleColName = "module";
		private const string AllPropsColName = "all_props";
		private const string PropertiesColName = "properties";

		public LogFactory(bool console, string serviceName, IConfiguration config, Func<LoggerConfiguration, LoggerConfiguration> extraConfig = null)
		{
			var cfg = new LoggerConfiguration()
				.ReadFrom.Configuration(config, sectionName: "Log");
			if (console) cfg = cfg.WriteTo.Console(Serilog.Events.LogEventLevel.Information);

			var logSection = config.GetSection(LogSectionName);

			// Сконфигурируем запись в БД 
			var pgConnStr = logSection.GetValue(PgConnStrName, "");
			if (!string.IsNullOrWhiteSpace(pgConnStr))
			{
				/*
				cfg = cfg.WriteTo.PostgreSQL(
					connectionString: pgConnStr,
					tableName: LogTableName,
					columnOptions: new Dictionary<string, ColumnWriterBase> {
						{MessageColName, new RenderedMessageColumnWriter(NpgsqlDbType.Text) },
						{LevelColName, new LevelColumnWriter(true, NpgsqlDbType.Varchar) },
						{EventTimestampColName, new TimestampColumnWriter(NpgsqlDbType.Timestamp) },
						{ExceptionColName, new ExceptionColumnWriter(NpgsqlDbType.Text) },
						{AllPropsColName, new LogEventSerializedColumnWriter(NpgsqlDbType.Jsonb) },
						{PropertiesColName, new PropertiesColumnWriter(NpgsqlDbType.Jsonb) },
						{ModuleColName, new SinglePropertyColumnWriter("SourceContext", PropertyWriteMethod.ToString, NpgsqlDbType.Text) },
						{SmevMessageIdColName, new SinglePropertyColumnWriter(LogPropNames.SmevMessageId, PropertyWriteMethod.ToString, NpgsqlDbType.Text) },
						{EpguOrderIdColName, new SinglePropertyColumnWriter(LogPropNames.EpguOrderId, PropertyWriteMethod.Raw, NpgsqlDbType.Bigint) },
						{ManualRequestIdColName, new SinglePropertyColumnWriter(LogPropNames.ManualRequestId, PropertyWriteMethod.ToString, NpgsqlDbType.Text) },
						{ServiceColName, new SinglePropertyColumnWriter(LogPropNames.Service, PropertyWriteMethod.ToString, NpgsqlDbType.Text) },
					},
					needAutoCreateTable: true
				);
				*/
			}
			// Всегда записываем в файл
			cfg = cfg
				.WriteTo.File(System.IO.Path.Combine(logSection.GetValue(FilePathName, ""), $"{serviceName}.log"), rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true);
			// Добавим энричеры
			cfg = cfg
				.Enrich.FromLogContext()
				.Enrich.WithExceptionDetails()
				.Enrich.WithProperty(LogPropNames.Service, serviceName);

			if (null != extraConfig) cfg = extraConfig.Invoke(cfg);
			Serilog.Log.Logger = cfg.CreateLogger();
		}

		public ILogger Logger => Serilog.Log.Logger;

		public ILogger CreateModuleLogger(Type moduleType)
		{
			return Serilog.Log.ForContext(moduleType);
		}

		public IDisposable SetEpguId(long epguId)
		{
			return LogContext.PushProperty(LogPropNames.EpguOrderId, epguId);
		}

		public IDisposable SetSmevMsgId(string smevId)
		{
			return LogContext.PushProperty(LogPropNames.SmevMessageId, smevId);
		}

		public IDisposable SetManualId(string manualId)
		{
			return LogContext.PushProperty(LogPropNames.ManualRequestId, manualId);
		}

		public void Dispose()
		{
			Serilog.Log.Logger?.Information("Завершение работы");
			Serilog.Log.CloseAndFlush();
		}
	}
}
