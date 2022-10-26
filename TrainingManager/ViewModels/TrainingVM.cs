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

    public static class TrainingVMExt
    {
        public static Training AsTraining(this TrainingVM vm)
        {
            var result = new Training();

            long longId;
            if (long.TryParse(vm.Id, out longId))
                result.Id = longId;

            result.TrainingDate = vm.TrainingDate;
            result.TrainingProgramId = vm.TrainingProgramId;
            result.Approachs = vm.Approachs.Select(e => e.AsApproach()).ToArray();
            result.Description = vm.Description;

            long timeLong;
            if (long.TryParse(vm.Time, out timeLong))
                result.Time = timeLong;

            result.Name = vm.Name;

            return result;
        }

        public static Approach AsApproach(this ApproachVM vm)
        {
            var result = new Approach();

            Guid idGuid;
            if (Guid.TryParse(vm.Id, out idGuid))
                result.Id = idGuid;
            result.Hard = vm.Hard;
            result.ExerciseId = vm.ExerciseId;
            result.Technicality = vm.Technicality switch
            {
                ApproachLvl.bad => TrainingManager.Logic.Model.ApproachLvl.bad,
                ApproachLvl.normal => TrainingManager.Logic.Model.ApproachLvl.normal,
                ApproachLvl.good => TrainingManager.Logic.Model.ApproachLvl.good
            };
            result.NumberOfTraining = vm.NumberOfTraining;

            long timeLong;
            if (long.TryParse(vm.Time, out timeLong))
                result.Time = timeLong;

            result.Weight = vm.Weight;

            return result;
        }
    }
}
