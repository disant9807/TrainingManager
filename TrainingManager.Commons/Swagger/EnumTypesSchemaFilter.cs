using TrainingManager.Commons.Attributes;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace TrainingManager.Commons.Swagger
{
	public class EnumTypesSchemaFilter : ISchemaFilter
	{
		private const string EnumMemperNamePrefix = "F:";
		private readonly Dictionary<string, string> _enumDescriptions = null;

		public EnumTypesSchemaFilter(IEnumerable<string> xmlPath)
		{
			if (xmlPath is null || !xmlPath.Any()) return;
			var _xmlComments = xmlPath.Where(p => File.Exists(p)).Select(p => XDocument.Load(p)).ToArray();
			if (_xmlComments.Length == 0) return;
			_enumDescriptions = _xmlComments.SelectMany(c => c.Descendants("member"))
				.Where(m => (m.Attribute("name")?.Value ?? string.Empty).StartsWith(EnumMemperNamePrefix) && m.Descendants("summary").Any(s => !string.IsNullOrWhiteSpace(s.Value)))
				.ToDictionary(m => m.Attribute("name").Value.Substring(EnumMemperNamePrefix.Length), m => m.Descendants("summary").First(s => !string.IsNullOrWhiteSpace(s.Value)).Value.Trim());
			if (!_enumDescriptions.Any()) _enumDescriptions = null;
		}

		public void Apply(OpenApiSchema schema, SchemaFilterContext context)
		{
			if (
				_enumDescriptions is null || 
				schema?.Enum == null ||
				context?.Type == null ||
				schema.Enum.Count <= 0 || 
				!context.Type.IsEnum) return;

			schema.Description += "<p>Members:</p><ul>";
			var fullTypeName = context.Type.FullName;
			Type enumType = GetTypeByName(fullTypeName);
			if (enumType != null && !enumType.IsEnum) enumType = null;
			foreach (var enumMemberName in schema.Enum.OfType<OpenApiString>().Select(v => v.Value))
			{
				if (!_enumDescriptions.TryGetValue(fullTypeName + "." + enumMemberName, out var description))
				{
					if (enumType == null) continue;
					description = enumType.GetMember(enumMemberName)?.FirstOrDefault()?.GetCustomAttributes(false)?.OfType<StringValueAttribute>()?.FirstOrDefault()?.StringValue;
					if (description is null) continue;
				}
				schema.Description += $"<li><i>{enumMemberName}</i> - {description}</li> ";
			}
			schema.Description += "</ul>";
		}

		private static Type GetTypeByName(string typeName)
		{
			foreach (var ass in AppDomain.CurrentDomain.GetAssemblies())
			{
				if (ass.FullName.StartsWith("System.")) continue;
				var t = ass.GetType(typeName);
				if (t != null) return t;
			}
			return null;
		}
	}
}
