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

    public static class ExerciseExt
    {
        public static ExerciseVM AsExerciseVM(this Exercise model)
        {
            var result = new ExerciseVM();
            result.Id = model.Id.ToString();
            result.HardSkill = model.HardSkill switch
            {
                HardSkill.easy => HardSkillVM.easy,
                HardSkill.normal => HardSkillVM.normal,
                HardSkill.hard => HardSkillVM.hard
            };
            result.ShortName = model.ShortName;
            result.ImagesIds = model.ImagesIds;
            result.CategoryOfBodiesIds = model.CategoryOfBodiesIds;
            result.Description = model.Description;
            result.IsBased = model.IsBased;
            result.Name = model.Name;

            return result;
        }
    }
}
