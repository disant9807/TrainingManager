using TrainingManager.Logic.Model;

namespace TrainingManager.ViewModels
{
    public class TrainingVM
    {
        public string Id { get; set; }
        public DateTime? TrainingDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
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
        public string Time { get; set; }
        public int NumberOfTraining { get; set; }
        public float Weight { get; set; }
        public string ExerciseId { get; set; }
        public int Hard { get; set; }
        public ApproachLvl Technicality { get; set; }
    }
}
