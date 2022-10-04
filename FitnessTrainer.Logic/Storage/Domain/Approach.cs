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

        public long Time { get; set; }

        public int NumberOfTraining { get; set; }

        public float Weight { get; set; }

        public long ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

        public int Hard { get; set; }

        public ApproachLvl Technicality { get; set; }

    }
}
