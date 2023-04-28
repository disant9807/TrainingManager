using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TrainingManager.Logic.Storage.Domain
{
    public class Size
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public string UserId { get; set; }

        public bool IsEveryone { get; set; }

        public ICollection<SizeItem> SizeItems { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsArchived { get; set; }

        public Size()
        {
            SizeItems = new List<SizeItem>();
        }
    }
}
