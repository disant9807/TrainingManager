﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Model
{
    public class TrainingProgram
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string AvatarId { get; set; }
        public string[] Images { get; set; }
        public string Description { get; set; }
        public Guid[] DaysIds { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
