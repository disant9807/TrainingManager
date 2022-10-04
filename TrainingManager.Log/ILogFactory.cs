using Serilog;
using System;

namespace TrainingManager.Log
{
	public interface ILogFactory
	{
		/// <summary>Получить логгер по умолчанию</summary>
		ILogger Logger { get; }

		/// <summary>Получить логгер для определенного класса. Полное имя класса помещается в свойство SourceContext</summary>
		ILogger CreateModuleLogger(Type moduleType);

		/// <summary>Установить текущий идентификатор ЕПГУ через LogContext.PushProperty</summary>
		IDisposable SetEpguId(long epguId);

		/// <summary>Установить текущий идентификатор ручного запроса через LogContext.PushProperty</summary>
		IDisposable SetManualId(string manualId);

		/// <summary>Установить текущий идентификатор сообщения СМЭВ через LogContext.PushProperty</summary>
		IDisposable SetSmevMsgId(string smevId);
	}
}