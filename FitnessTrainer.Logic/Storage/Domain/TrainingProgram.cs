using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManager.Logic.Storage.Domain
{
    public class TrainingProgram
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string AvatarId { get; set; }

        public string[] Images { get; set; }

        public string Description { get; set; }

        public Guid[] DaysIds { get; set; }
        [ForeignKey("DaysIds")]
        public TrainingProgramDay[] Days { get; set; }

        public DateTimeOffset CreatedDate { get; set; }
    }
}
