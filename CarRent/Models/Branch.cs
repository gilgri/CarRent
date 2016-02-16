using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRent.Models
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Location Address { get; set; }
    }
}