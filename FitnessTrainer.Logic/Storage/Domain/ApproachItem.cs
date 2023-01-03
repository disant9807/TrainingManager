using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrainingManager.Logic.Storage.Domain
{
    public class ApproachItem
    {
        [Key]
        public Guid Id { get; set; }
        public Approach approach { get; set; }
        public long Time { get; set; }
        public float Weight { get; set; }

        public int NumberOfApproach { get; set; }

        public int Hard { get; set; }
        public ApproachLvl Technicality { get; set; }

    }
}
