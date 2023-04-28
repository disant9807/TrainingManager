using TrainingManager.Logic.Model;

namespace TrainingManager.ViewModels
{
    public class ExerciseVM
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string UserId { get; set; }
        public string ShortName { get; set; }
        public bool IsBased { get; set; }
        public string Description { get; set; }
        public Guid[] ImagesIds { get; set; }
        public HardSkillVM HardSkill { get; set; }
        public string[] CategoryOfBodiesIds { get; set; }  
        public CategoryOfBodyVM[] CategoryOfBodies { get; set; }
        public DateTime? CreatedDate { get; set; }
    }

    public enum HardSkillVM
    {
        easy = 0,
        normal = 1,
        hard = 2
    }
}
