using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrainingManager.Logic.Storage.Domain
{
    public class UnitsOfMeasurement
    {
        [Key]
        public string Code { get; set; }

        public string Value { get; set; }

        public bool IsArchive { get; set; }
    }
}
