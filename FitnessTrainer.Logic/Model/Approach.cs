using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingManager.Logic.Model
{
    public class Approach
    {
        public Guid Id { get; set; }
        public int NumberOfTraining { get; set; }
        public Exercise Exercise { get; set; }

        public ApproachItem[] ApproachsItems { get; set; }

    }
}
