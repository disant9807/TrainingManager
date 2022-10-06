using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrainingManager.Logic.Storage.Domain
{
    public class CategoryOfBody
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        [Key]
        public string Code { get; set; }
        public string Decsription { get; set; }

        public Image Avatar { get; set; }
        public Guid? AvatarId { get; set; }

        public ICollection<Exercise> Exercises { get; set; }

        public CategoryOfBody()
        {
            Exercises = new List<Exercise>();
        }
    }
}
