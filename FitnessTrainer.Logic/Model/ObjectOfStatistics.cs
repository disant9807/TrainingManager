using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManager.Logic.Model;

namespace TrainingManager.Logic.Model
{
    public class ObjectOfStatistics
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsArchived { get; set; }

        public string UnitCode { get; set; }

        public string CategoryCode { get; set; }

        public DateTime CreateOrUpdate { get; set; }

        public UnitsOfMeasurement UnitsOfMeasurement { get; set; }
    }
}
