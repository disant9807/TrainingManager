using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Model
{
    public class GetGoalsFilter
    {
        public string[] CodeUnitsOfMeasurement { get; set; }

        public string[] CategoryOfBodies { get; set; }

        public float Value { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? CreatedFrom { get; set; }

        public DateTime? CreatedTo { get; set; }

        public DateTime? CompletionDateFrom { get; set; }

        public DateTime? CompletionDateTo { get; set; }

    }
}
