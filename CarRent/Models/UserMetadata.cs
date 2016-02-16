using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRent.Models
{

    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {

    }

    public class UserMetadata
    {
        [Required (ErrorMessage ="Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage ="first name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "alias is required")]
        public string Alias { get; set; }

        [Required(ErrorMessage = "sex is required")]
        public Gender Sex { get; set; }

        [Required(ErrorMessage = "email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "password is required")]
        public string Password { get; set; }
    }
}