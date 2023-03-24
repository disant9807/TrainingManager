using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Model
{
    public class GetSizesFilter
    {
        public string[] CodeUnitsOfMeasurement { get; set; }

        public string[] CategoryOfBodies { get; set; }

        public string Name { get; set; }

        public DateTime? CreatedFrom { get; set; }

        public DateTime? CreatedTo { get; set; }

    }
}
