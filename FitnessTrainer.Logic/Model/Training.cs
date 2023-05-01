using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrainingManager.Logic.Model
{
    public class Training
    {
        public long Id { get; set; }
        public DateTime? TrainingDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public bool IsEveryone { get; set; }
        public string Name { get; set; }
        public long Time { get; set; }
        public long? TrainingProgramIdFK { get; set; }

        public Guid? TrainingProgramDayFK { get; set; }
        public TrainingProgram? TrainingProgram { get; set; }
        public ICollection<Approach> Approachs { get; set; }
    }
}
