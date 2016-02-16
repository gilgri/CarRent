using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRent.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public CarType CarType { get; set; }
        public int Kilometrage { get; set; }
        public string Image { get; set; }
        public bool IsRentable { get; set; }
        public string Number { get; set; }
        public Branch Branch { get; set; }
    }
}