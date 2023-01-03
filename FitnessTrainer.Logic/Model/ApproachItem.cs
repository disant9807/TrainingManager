using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingManager.Logic.Model
{
    public class ApproachItem
    {
        public Guid Id { get; set; }
        public Approach approach { get; set; }
        public long Time { get; set; }
        public float Weight { get; set; }

        public int NumberOfApproach { get; set; }

        public int Hard { get; set; }
        public ApproachLvl Technicality { get; set; }

    }
}
