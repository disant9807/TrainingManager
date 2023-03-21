using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace TrainingManager.Logic.Storage.Domain
{
    public class SizeItem
    {
        [Key]
        public Guid Id { get; set; }

        public long SizeId { get; set; }

        [Required]
        [ForeignKey("SizeId")]
        public Size Size { get; set; }

        public string BodyCode { get; set; }

        [ForeignKey("BodyCode")]
        public CategoryOfBody Body { get; set; }

        public string Value { get; set; }

        public string CodeUnitsOfMeasurement { get; set; }

        [ForeignKey("CodeUnitsOfMeasurement")]
        public UnitsOfMeasurement UnitsOfMeasurement { get; set; }

        public ICollection<Image> Images { get; set; }

        public Guid? AvatarId { get; set; }

        [ForeignKey("AvatarId")]
        public Image Avatar { get; set; }

        public SizeItem()
        {
            Images = new List<Image>();
        }
    }
}
