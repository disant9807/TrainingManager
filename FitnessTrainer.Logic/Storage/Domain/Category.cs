﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManager.Logic.Storage.Domain
{
    public class Category
    {
        [Key]
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
