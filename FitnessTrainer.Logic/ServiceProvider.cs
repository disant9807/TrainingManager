using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using TrainingManager.Logic.Config;
using TrainingManager.Logic.Storage;
using TrainingManager.Log;

namespace TrainingManager.Logic
{
	public static class ServiceProvider
	{
		public static IServiceCollection AddTrainingManager(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddSingleton<IConfig, Config.Config>();
			AddDbContextFactory(services);
			services.AddSingleton<ILogFactory>(service => new LogFactory(true, "TrainingManagerLogic", service.GetService<IConfiguration>()));
			services.AddSingleton<IStorage, Storage.Storage>();

			return services;
		}

		private static void AddDbContextFactory(IServiceCollection services)
		{
			AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
			services.AddDbContextFactory<StorageContext>((services, options) =>
			{
				var config = services.GetService<IConfig>();
				var logFactory = services.GetService<ILogFactory>();
				var connectionString = (config ?? throw new ArgumentNullException(nameof(config))).StorageConnectionString;
				options.EnableSensitiveDataLogging();
				options.UseNpgsql(connectionString);
            });
		}
	}
}
