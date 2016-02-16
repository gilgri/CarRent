using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRent.Models
{
    public class CarType
    {
        [Key]
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int DailyCost { get; set; }
        public int DelayDailyCost { get; set; }
        public Gear GearBox { get; set; }
    }

    public enum Gear
    {
        Automaton,
        Manual
    }

}