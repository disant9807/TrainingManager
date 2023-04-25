using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Storage.Domain
{
    public class StatisticsIndicator
    {
        [Key]
        public Guid Id { get; set; }

        public string UserId { get; set; }

        public bool IsArchived { get; set; }

        public Guid ObjectCode { get; set; }

        [ForeignKey("ObjectCode")]
        public ObjectOfStatistics ObjectOfStatistics { get; set; }

        public string Value { get; set; }

        public DateTime CreatedOrUpdate { get; set; }

        public DateTime DateOfMeasurement { get; set; }
    }
}
