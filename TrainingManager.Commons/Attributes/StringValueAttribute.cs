using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManager.Commons.Attributes
{
	/// <summary>Аттрибут для хранения строкового представления перечисления</summary>
	public class StringValueAttribute : Attribute
	{
		/// <summary>Строковое предствление перечисления</summary>
		public string StringValue { get; }

		/// <summary>
		/// Конструктор инициализирует строковое представление
		/// </summary>
		/// <param name="value"></param>
		public StringValueAttribute(string value)
		{
			StringValue = value;
		}

	}
}
