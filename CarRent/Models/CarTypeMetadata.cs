using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRent.Models
{
    [MetadataType(typeof(CarTypeMetadata))]
    public partial class CarType
    {
    }

    public partial class CarTypeMetadata
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Manufacturer is required")]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "Model is required")]
        public string Model { get; set; }
        [Required(ErrorMessage = "DailyCost is required")]
        public int DailyCost { get; set; }
        [Required(ErrorMessage = "DelayDailyCost is required")]
        public int DelayDailyCost { get; set; }
        [Required(ErrorMessage = "GearBox is required")]
        public Gear GearBox { get; set; }
    }
}