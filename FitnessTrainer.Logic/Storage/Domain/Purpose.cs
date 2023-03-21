using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingManager.Logic.Storage.Domain
{
    public class Purpose
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public ICollection<SubPurpose> SubPurpose { get; set; }

        public Purpose()
        {
            SubPurpose = new List<SubPurpose>();
        }
    }
}
