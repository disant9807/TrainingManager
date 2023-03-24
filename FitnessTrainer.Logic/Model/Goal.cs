using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManager.Logic.Model
{
    public class Goal
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsArchived { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime CompletionDate { get; set; }

        public ICollection<SubGoal> SubGoals { get; set; }
    }
}
