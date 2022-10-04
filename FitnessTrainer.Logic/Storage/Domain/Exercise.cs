using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManager.Logic.Storage.Domain
{
    public class Exercise
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public bool IsBased { get; set; }

        public string Description { get; set; }

        public string[] ImagesIds { get; set; }
        
        public HardSkill HardSkill { get; set; }

        public string[] CategoryOfBodiesIds { get; set; }
        [ForeignKey("CategoryOfBodiesIds")]
        public CategoryOfBody[] CategoryOfBodies { get; set; }

        public DateTimeOffset CreatedDate { get; set; }
    }
}
