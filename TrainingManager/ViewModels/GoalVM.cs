using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrainingManager.ViewModels
{
    public class GoalVM
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsArchived { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime CompletionDate { get; set; }

        public ICollection<SubGoalVM> SubGoals { get; set; }
    }

    public class SubGoalVM
    {
        public string Id { get; set; }

        public string BodyCode { get; set; }

        public float Value { get; set; }

        public string CodeUnitsOfMeasurement { get; set; }

        public GoalVM Goal { get; set; }

        public string GoalId { get; set; }
    }
}
