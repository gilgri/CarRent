using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRent.Models
{
    [MetadataType(typeof(LocationMetadata))]
    public partial class Location
    {
    }

    public partial class LocationMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Latitude is required")]
        public double Latitude { get; set; }
        [Required(ErrorMessage = "Longitude is required")]
        public double Longitude { get; set; }
        [Required(ErrorMessage = "Addreass is required")]
        public string Addreass { get; set; }

    }


}