using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrainingManager.Logic.Storage.Domain
{
    public class TrainingProgramDay
    {
        [Key]
        public Guid Id { get; set; }
        public long ExercisesId { get; set; }
        public Exercise Exercises { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DayRelax { get; set; }
        public int NumberOfTrainingProgram { get; set; }

        public TrainingProgram TrainingProgram { get; set; }
        public long TrainingProgramId { get; set; }
    }
}
