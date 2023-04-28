using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManager.Logic.Model;

namespace TrainingManager.Logic.Model
{
    public class ObjectOfStatistics
    {
        public Guid Id { get; set; }

        public string CategoryCode { get; set; }

        public Category Category { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Code { get; set; }

        public bool IsArchived { get; set; }

        public DateTime CreateOrUpdate { get; set; }

        public List<StatisticsIndicator> StatisticsIndicators { get; set; }

        public ObjectOfStatistics()
        {
            this.StatisticsIndicators = new List<StatisticsIndicator>();
        }
    }
}
