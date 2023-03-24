using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManager.Logic.Model
{ 
    public class SubGoal
    {
        public Guid Id { get; set; }

        public string BodyCode { get; set; }

        public CategoryOfBody CategoryOfBody { get; set; }

        public float Value { get; set; }

        public string CodeUnitsOfMeasurement { get; set; }

        public UnitsOfMeasurement UnitsOfMeasurement { get; set; }

        public Goal Goal { get; set; }

        public long GoalId { get; set; }

    }
}
