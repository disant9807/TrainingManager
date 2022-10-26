using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Model
{
    public class GetTrainingsFilter
    {
        public string[] CategoryOfBodies { get; set; }

        public string Name { get; set; }

        public DateTime? CreatedFrom { get; set; }

        public DateTime? CreatedTo { get; set; }

        public DateTime? TrainingFrom { get; set; }

        public DateTime? TrainingTo { get; set; }

        public string[] Exercises { get; set; }

        public string[] TrainingPrograms { get; set; }

        public bool? isNoneTrainingProgram { get; set; }

        public int? MaxCountApproach { get; set; }

        public int? MinCountApproach { get; set; }

        public long? MaxTimeSec { get; set; }

        public long? MinTimeSec { get; set; }

    }
}
