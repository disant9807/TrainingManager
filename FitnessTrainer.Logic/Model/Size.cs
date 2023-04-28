using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManager.Logic.Model
{
    public class Size
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public ICollection<SizeItem> SizeItems { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UserId { get; set; }

        public bool IsEveryone { get; set; }

        public bool IsArchived { get; set; }
    }
}
