using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Model
{
    public class ExerciseListItem
    {
        public long Id { get; set; }
        public string ShortName { get; set; }
        public bool IsBased { get; set; }
        public string Description { get; set; }
        public string[] ImagesIds { get; set; }
        public HardSkill HardSkill { get; set; }
        public string[] CategoryOfBodiesIds { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
