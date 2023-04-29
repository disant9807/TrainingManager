using TrainingManager.Logic.Model;

namespace TrainingManager.ViewModels
{
    public class TrainingProgramVM
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }

        public bool IsEveryone { get; set; }
        public string ShortName { get; set; }
        public string AvatarId { get; set; }
        public string[] Images { get; set; }
        public string Description { get; set; }

        public DateTime? CreatedDate { get; set; }

        public ICollection<TrainingProgramDayVM> Days { get; set; }
    }


    public class TrainingProgramDayVM
    {
        public string Id { get; set; }
        public ICollection<ExerciseVM> Exercises { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DayRelax { get; set; }
        public int NumberOfTrainingProgram { get; set; }
    }
}
