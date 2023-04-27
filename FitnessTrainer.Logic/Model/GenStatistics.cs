using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManager.Logic.Model;

namespace TrainingManager.Logic.Model
{
    public class GenStatistics
    {
        public Guid Id { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime GeneratedTime { get; set; }

        public string CategoryCode { get; set; }

        public Category Category { get; set; }

        public string UserId { get; set; }

        public ICollection<ObjectOfStatistics> Statistics { get; set; }

        public GenStatistics()
        {
            Statistics = new List<ObjectOfStatistics>();
        }
    }
}
