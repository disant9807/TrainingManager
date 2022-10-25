using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Model
{
    public class GetExercisesFilter
    {
        public string[] CategoryOfBodies { get; set; }

        public string Name { get; set; }

        public DateTime? CreatedFrom { get; set; }

        public DateTime? CreatedTo { get; set; }

        public bool? IsBased { get; set; }

        public HardSkill[] HardSkills { get; set; }

        public HardSkill? HardSkill { get; set; }
    }
}
