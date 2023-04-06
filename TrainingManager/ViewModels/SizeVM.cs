using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrainingManager.ViewModels
{
    public class SizeVM
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public ICollection<SizeItemVM> SizeItems { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsArchived { get; set; }
    }

    public class SizeItemVM
    {
        public string Id { get; set; }

        public string BodyCode { get; set; }

        public CategoryOfBodyVM Body { get; set; }

        public string Value { get; set; }

        public string CodeUnitsOfMeasurement { get; set; }

        public UnitsOfMeasurementVM UnitsOfMeasurement { get; set; }

        public string[] Images { get; set; }

        public string AvatarId { get; set; }
    }
}
