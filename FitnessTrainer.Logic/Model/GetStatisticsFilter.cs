using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Model
{
    public class GetStatisticsFilter
    {
        public string UserId { get; set; }

        public string ObjectCode { get; set; }

        public DateTime? MeasurementFrom { get; set; }

        public DateTime? MeasurementTo { get; set; }

    }
}
