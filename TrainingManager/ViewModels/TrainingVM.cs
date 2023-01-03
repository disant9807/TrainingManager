using TrainingManager.Logic.Model;

namespace TrainingManager.ViewModels
{
    public class TrainingVM
    {
        public string Id { get; set; }
        public DateTime? TrainingDate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public string TrainingProgramId { get; set; }

        public ApproachVM[] Approachs { get; set; }
    }

    public enum ApproachLvl
    {
        good = 0,
        normal = 1,
        bad = 2
    }

    public class ApproachVM
    {
        public string Id { get; set; }
        public int NumberOfTraining { get; set; }
        public ExerciseVM Exercise { get; set; }

        public ApproachItemVM[] ApproachItems { get; set; }
    }

    public class ApproachItemVM
    {
        public string Id { get; set; }
        public ApproachVM approach { get; set; }
        public long Time { get; set; }
        public float Weight { get; set; }

        public int NumberOfApproach { get; set; }

        public int Hard { get; set; }
        public ApproachLvl Technicality { get; set; }
    }
}
