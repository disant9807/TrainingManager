using TrainingManager.Logic.Model;

namespace TrainingManager.ViewModels
{
    public class ExerciseVM
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool IsBased { get; set; }
        public string Description { get; set; }
        public Guid[] ImagesIds { get; set; }
        public HardSkillVM HardSkill { get; set; }
        public string[] CategoryOfBodiesIds { get; set; }
    }

    public enum HardSkillVM
    {
        easy = 0,
        normal = 1,
        hard = 2
    }

    public static class ExerciseVMExt
    {
        public static Exercise AsExercise(this ExerciseVM vm)
        {
            var result = new Exercise();

            long longId;
            if (long.TryParse(vm.Id, out longId))
                result.Id = longId;

            result.HardSkill = vm.HardSkill switch
            {
                HardSkillVM.easy => HardSkill.easy,
                HardSkillVM.normal => HardSkill.normal,
                HardSkillVM.hard => HardSkill.hard
            };
            result.ShortName = vm.ShortName;
            result.ImagesIds = vm.ImagesIds;
            result.CategoryOfBodiesIds = vm.CategoryOfBodiesIds;
            result.Description = vm.Description;
            result.IsBased = vm.IsBased;
            result.Name = vm.Name;

            return result;
        }
    }
}
