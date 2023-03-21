using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManager.Logic.Storage.Domain
{
    public class SubPurpose
    {
        [Key]
        public Guid Id { get; set; }

        public CategoryOfBody CategoryOfBody { get; set; }

        public float Value { get; set; }

        public string CodeUnitsOfMeasurement { get; set; }

        [ForeignKey("CodeUnitsOfMeasurement")]
        public UnitsOfMeasurement UnitsOfMeasurement { get; set; }

        [ForeignKey("PurposeId")]
        public Purpose Purpose { get; set; }

        public long PurposeId { get; set; }
    }
}
