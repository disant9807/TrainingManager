using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrainingManager.ViewModels
{
    public class GoalVM
    {
        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string UserId { get; set; }

        public bool IsEveryone { get; set; }

        public string Description { get; set; }

        public bool IsArchived { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public DateTime? CreatedDate { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = true)]
        public DateTime? CompletionDate { get; set; }

        public ICollection<SubGoalVM> SubGoals { get; set; }
    }

    public class SubGoalVM
    {
        public string Id { get; set; }

        public string BodyCode { get; set; }

        public CategoryOfBodyVM Body { get; set; }

        public float Value { get; set; }

        public string CodeUnitsOfMeasurement { get; set; }

        public UnitsOfMeasurementVM UnitsOfMeasurement { get; set; }

        public string GoalId { get; set; }
    }
}
    