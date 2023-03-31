using TrainingManager.Logic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Swashbuckle.AspNetCore.Filters;
using Version = TrainingManager.Extension.Version;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using TrainingManager.Commons;
using TrainingManager.Commons.Middleware;
using TrainingManager.Logic.Storage;
using TrainingManager.Logic.Config;
using TrainingManager.Log;
using Microsoft.Extensions.DependencyInjection;
using TrainingManager.Logic.Storage.Mappings;
using TrainingManager.Mappings;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;

namespace TrainingManager
{
    public class Startup
    {
		private const string ApiVersion = "v1";
		private const string ApiName = "Взаимодействие с менеджером тренировок";

		public Startup(IWebHostEnvironment env)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(env.ContentRootPath)
				.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
				.AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
				.AddEnvironmentVariables();

			Configuration = builder.Build();
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
        {
			services.AddHttpClient();
			services.AddTrainingManager(Configuration);
			services.AddAutoMapper(typeof(DomainToModelProfile), typeof(ModelToViewModelProfile));
			services
				.AddCors()
				.AddControllers()
				.AddNewtonsoftJson();

			services.AddDefaultSwagger($"{ApiVersion}", ApiName, $"Build:{Version.Number}");

			services.AddControllers();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogFactory logFactory)
		{
			var log = logFactory.CreateModuleLogger(typeof(Startup));
			app.UseExceptionToHttpResponse((e, h) => log.Error(e, e.FullInfo(true)));

			try
			{
				// применим миграции
				MigrateDatabase(app);

				app
					.UseRouting()
					.UseCors(options => options.SetIsOriginAllowed(x => _ = true)
						.AllowAnyMethod()
						.AllowAnyHeader()
						.AllowCredentials())
					//.UseAuthorization()
					.UseDefaultSwagger(ApiVersion, ApiName)
					.UseEndpoints(endpoints =>
					{
						endpoints.MapControllers();
					});
			}
			catch (System.Exception e)
			{
				log.Fatal(e, $"Ошибка при запуске сервиса {e.Message}");
                //throw e;
			}
		}

		public static void MigrateDatabase(IApplicationBuilder app)
		{
			var config = app.ApplicationServices.GetRequiredService<IConfig>();
			var connectionString = (config ?? throw new ArgumentNullException(nameof(config))).StorageConnectionString;
			var optionsBuilder = new DbContextOptionsBuilder<StorageContext>();

			if (!File.Exists(connectionString))
			{
				var directory = Path.GetDirectoryName(connectionString);
				Directory.CreateDirectory(directory);
				File.WriteAllBytes(connectionString, Array.Empty<byte>());
			}
			var options = optionsBuilder.UseSqlite($"Data Source={connectionString}").Options;
			using (var serviceScope = app.ApplicationServices
				.GetRequiredService<IServiceScopeFactory>()
				.CreateScope())
			{
				using var context = new StorageContext(options);
				context.Database.Migrate();
			}
		}
	}
}
