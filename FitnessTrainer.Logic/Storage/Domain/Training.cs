﻿using System;
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
        public DateTime? TrainingDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public bool IsEveryone { get; set; }

        public string UserId { get; set; }

        public long Time { get; set; }

        public long? TrainingProgramIdFK { get; set; }

        [ForeignKey("TrainingProgramIdFK")]
        public TrainingProgram? TrainingProgram { get; set; }

        public Guid? TrainingProgramDayFK { get; set; }

        [ForeignKey("TrainingProgramDayFK")]
        public TrainingProgramDay? TrainingProgramDay { get; set; }

        public ICollection<Approach> Approachs { get; set; }

        public bool IsArchived { get; set; }

        public Training()
        {
            Approachs = new List<Approach>();
        }
    }
}
