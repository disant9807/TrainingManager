using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingManager.Logic.Config
{
	public interface IConfig
	{
		string StorageConnectionString { get; }
	}
}
