using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrainingManager.Logic.Storage.Domain
{
    public class Approach
    {
        [Key]
        public Guid Id { get; set; }

        public int NumberOfTraining { get; set; }

        public Exercise? Exercise { get; set; }

        public Training Training { get; set; }
        public long TrainingId { get; set; }

        public bool IsArchived { get; set; }

        public ICollection<ApproachItem> ApproachsItems { get; set; }

        public Approach()
        {
            ApproachsItems = new List<ApproachItem>();
        }

    }
}
