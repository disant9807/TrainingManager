using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingManager.Logic.Model
{
    public class Approach
    {
        public Guid Id { get; set; }
        public long Time { get; set; }
        public int NumberOfTraining { get; set; }
        public float Weight { get; set; }
        public long ExerciseId { get; set; }
        public int Hard { get; set; }
        public ApproachLvl Technicality { get; set; }

    }
}
