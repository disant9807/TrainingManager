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

        public string AvatarId { get; set; }
    }
}
