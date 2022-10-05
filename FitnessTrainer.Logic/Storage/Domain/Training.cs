using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TrainingManager.Logic.Storage.Domain
{
    public class Training
    {
        [Key]
        public long Id { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public long Time { get; set; }

        public long TrainingProgramId { get; set; }
        public TrainingProgram? TrainingProgram { get; set; }

        public List<Approach> Approachs { get; set; }
    }
}
