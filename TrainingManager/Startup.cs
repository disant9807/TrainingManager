using TrainingManager.Logic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Swashbuckle.AspNetCore.Filters;
using Version = TrainingManager.Extension.Version;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using TrainingManager.Commons;
using TrainingManager.Logic.Storage;
using TrainingManager.Logic.Config;
using TrainingManager.Log;

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
			services
				.AddCors()
				.AddControllers()
				.AddJsonOptions(options =>
					options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter())
				);

			services.AddDefaultSwagger($"{ApiVersion}", ApiName, $"Build:{Version.Number}", c =>
			{
				c.MapType<JsonDocument>(() => new OpenApiSchema { Type = "jsonObject" });
				c.ExampleFilters();
			});
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogFactory logFactory)
		{
			var log = logFactory.CreateModuleLogger(typeof(Startup));

			try
			{
				// применим миграции
				MigrateDatabase(app);

				app
					.UseHttpsRedirection()
					.UseRouting()
					.UseCors(options => options.SetIsOriginAllowed(x => _ = true)
					.AllowAnyMethod()
					.AllowAnyHeader()
					.AllowCredentials())
					//.UseAuthorization()
					.UseDefaultSwagger(ApiVersion, ApiName)
					.UseEndpoints(endpoints => { endpoints.MapControllers(); });
			}
			catch (System.Exception e)
			{
				log.Fatal(e, $"Ошибка при запуске сервиса {e.Message}");
				throw e;
			}
		}

		public static void MigrateDatabase(IApplicationBuilder app)
		{
			var config = app.ApplicationServices.GetRequiredService<IConfig>();
			var connectionString = (config ?? throw new ArgumentNullException(nameof(config))).StorageConnectionString;
			var optionsBuilder = new DbContextOptionsBuilder<StorageContext>();
			var options = optionsBuilder.UseSqlite(connectionString).Options;

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
