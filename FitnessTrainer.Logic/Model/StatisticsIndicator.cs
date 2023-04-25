using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Model
{
    public class StatisticsIndicator
    {
        public Guid Id { get; set; }

        public string UserId { get; set; }

        public bool IsArchived { get; set; }

        public Guid ObjectCode { get; set; }

        public ObjectOfStatistics ObjectOfStatistics { get; set; }

        public string Value { get; set; }

        public DateTime CreatedOrUpdate { get; set; }

        public DateTime DateOfMeasurement { get; set; }

    }
}
