using System;
using System.Collections.Generic;
using System.Text;

#nullable enable
namespace TrainingManager.Commons
{
	public static class ExceptionHelper
	{
		public const int DefaultStringCapacity = 1000;
		public const string ExceptionSeparator = "===== Вложенное исключение =====";
		public static string FullInfo(this Exception ex, bool includeStackTrace)
		{
			var sb = new StringBuilder(DefaultStringCapacity);
			var exCurrent = ex;
			while (null != exCurrent)
			{
				if (ex != exCurrent)
				{
					sb.AppendLine();
					sb.AppendLine(ExceptionSeparator);
				}
				sb.Append("[");
				sb.Append(exCurrent.GetType());
				sb.Append("] ");
				sb.Append(exCurrent.Message);
				if (includeStackTrace)
				{
					sb.AppendLine();
					sb.Append(exCurrent.StackTrace);
				}
				exCurrent = exCurrent.InnerException;
			}
			return sb.ToString();
		}
	}
}
