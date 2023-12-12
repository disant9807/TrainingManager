using TrainingManager.Commons.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainingManager.Commons
{
	public static class SwaggerExtensions
	{
		/// <summary>Добавить сервис сваггера</summary>
		/// <param name="services">Коллекция сервисов</param>
		/// <param name="version">Версия API</param>
		/// <param name="title">Наименование API</param>
		/// <param name="description">Описание API</param>
		/// <param name="examplesNamespace">Name space, где расположены примеры для Swagger</param>
		/// <returns></returns>
		public static IServiceCollection AddDefaultSwagger(this IServiceCollection services,
			string version,
			string title,
			string description = "",
			Action<SwaggerGenOptions> additionalOptions = null,
			string examplesNamespace = null)
		{
			if (string.IsNullOrWhiteSpace(version)) throw new ArgumentNullException(nameof(version));
			if (string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException(nameof(title));
			bool hasExamples = !string.IsNullOrWhiteSpace(examplesNamespace);
			services.AddSwaggerGen(c => {
				c.CustomSchemaIds(type => type.ToString());
				c.SwaggerDoc(version, new OpenApiInfo {
					Version = version,
					Title = title,
					Description = description ?? "Описание"
				});
				// Set the comments path for the Swagger JSON and UI.
				var xmlComments = System.IO.Directory.GetFiles(AppContext.BaseDirectory, "*.xml");
				if(xmlComments.Any())
				{
					foreach (var xmlFile in xmlComments) c.IncludeXmlComments(xmlFile);
					c.SchemaFilter<EnumTypesSchemaFilter>((IEnumerable<string>)xmlComments);
				}
				if (hasExamples) c.ExampleFilters();
				additionalOptions?.Invoke(c);
			});

			// Регистрация примеров
			if (hasExamples)
			{
				foreach (var type in AppDomain.CurrentDomain
					.GetAssemblies()
					.SelectMany(a => a.GetTypes())
					.Where(t => examplesNamespace.Equals(t.Namespace, StringComparison.Ordinal)))
				{
					services.AddSwaggerExamplesFromAssemblyOf(type);
				}
			}
			return services;
		}

		public static IApplicationBuilder UseDefaultSwagger(this IApplicationBuilder app, string version, string title)
		{
			if (string.IsNullOrWhiteSpace(version)) throw new ArgumentNullException(nameof(version));
			if (string.IsNullOrWhiteSpace(title)) throw new ArgumentNullException(nameof(title));
			app.UseSwagger();
			app.UseSwaggerUI(c => { c.SwaggerEndpoint($"/swagger/{version}/swagger.json", title); });
			return app;
		}
	}
}
