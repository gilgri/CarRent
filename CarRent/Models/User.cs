using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarRent.Models
{
    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public DateTime? Birthday { get; set; } 
        public Gender Sex { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public Part Part { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
    public enum Part
    {
        Admin,
        User,
        CompanyUser
    }

}