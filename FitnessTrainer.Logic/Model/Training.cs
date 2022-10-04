using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrainingManager.Logic.Storage.Model
{
    public class Training
    {
        public long Id { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public long Time { get; set; }
        public long TrainingProgramId { get; set; }
        public TrainingProgram? TrainingProgram { get; set; }
        public Guid[] ApproachsIds { get; set; }
    }
}
