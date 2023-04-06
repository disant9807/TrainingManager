using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrainingManager.Logic.Model
{
    public class Exercise
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool IsBased { get; set; }
        public string Description { get; set; }
        public Guid[] ImagesIds { get; set; }
        public HardSkill HardSkill { get; set; }
        public string[] CategoryOfBodiesIds { get; set; }
        public CategoryOfBody[] CategoryOfBodies { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
