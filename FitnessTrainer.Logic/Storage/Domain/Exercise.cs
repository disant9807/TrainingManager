﻿using System;
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

        public ICollection<Image> Images { get; set; }

        public Image Avatar { get; set; }

        public Guid? AvatarId { get; set; }

        public HardSkill HardSkill { get; set; }

        public ICollection<CategoryOfBody> CategoryOfBodies { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public Exercise()
        {
            CategoryOfBodies = new List<CategoryOfBody>();
            Images = new List<Image>();
        }
    }
}
