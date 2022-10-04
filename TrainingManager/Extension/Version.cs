using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

#nullable enable
namespace TrainingManager.Extension
{
	public static class Version
	{
		private static string? _number;
		public static string Number
		{
			get {
				if (string.IsNullOrEmpty(_number))
				{
					_number = Assembly.GetEntryAssembly()?.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "0";
				}
				return _number;
			}
		}
	}
}
