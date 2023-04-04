using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Model
{
    public class SizeItem
    {
        public Guid Id { get; set; }

        public long SizeId { get; set; }

        public string BodyCode { get; set; }

        public string Value { get; set; }

        public string CodeUnitsOfMeasurement { get; set; }

        public Guid? AvatarId { get; set; }
    }
}
