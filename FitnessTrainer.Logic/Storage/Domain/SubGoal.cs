using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManager.Logic.Storage.Domain
{
    public class SubGoal
    {
        [Key]
        public Guid Id { get; set; }

        public string BodyCode { get; set; }

        [ForeignKey("BodyCode")]
        public CategoryOfBody Body { get; set; }

        public float Value { get; set; }

        public string CodeUnitsOfMeasurement { get; set; }

        [ForeignKey("CodeUnitsOfMeasurement")]
        public UnitsOfMeasurement UnitsOfMeasurement { get; set; }

        [ForeignKey("GoalId")]
        public Goal Goal { get; set; }

        public long GoalId { get; set; }
    }
}
