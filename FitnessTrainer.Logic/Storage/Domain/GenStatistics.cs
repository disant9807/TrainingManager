using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Storage.Domain
{
    public class GenStatistics
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime GeneratedTime { get; set; }

        public string CategoryCode { get; set; }

        [ForeignKey("CategoryCode")]
        public Category Category { get; set; }

        public string UserId { get; set; }

        public ICollection<ObjectOfStatistics> Statistics { get; set; }

        public GenStatistics()
        {
            Statistics = new List<ObjectOfStatistics>();
        }
    }
}
