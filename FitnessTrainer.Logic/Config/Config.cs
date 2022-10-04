using Microsoft.Extensions.Configuration;
using System;

namespace TrainingManager.Logic.Config
{
    public class Config: IConfig
    {
        private readonly IConfigurationSection _trainingManagerSection;

        public string StorageConnectionString => _trainingManagerSection[nameof(StorageConnectionString)];

        public Config(IConfiguration configuration)
        {
            var config = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _trainingManagerSection = config.GetSection("TrainingManagerConfig");
        }
    }
}
