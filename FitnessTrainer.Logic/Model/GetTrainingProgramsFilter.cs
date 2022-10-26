using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Model
{
    public class GetTrainingProgramsFilter
    {
        public string[] CategoryOfBodies { get; set; }

        public string Name { get; set; }

        public DateTime? CreatedFrom { get; set; }

        public DateTime? CreatedTo { get; set; }

        public string[] Exercises { get; set; }

        public int? MaxCountTrainingDays { get; set; }

        public int? MinCountTrainingDays { get; set; }

    }
}
