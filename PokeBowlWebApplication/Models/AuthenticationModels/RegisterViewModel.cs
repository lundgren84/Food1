using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PokeBowlWebApplication.Models.AuthenticationModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Fyll i detta fält")]
        [Display(Name = "E-post")]
        [EmailAddress]
        public string Username { get; set; }

        [Required(ErrorMessage = "Fyll i detta fält")]
        [Display(Name = "Lösenord")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Fyll i detta fält")]
        [Display(Name = "Lösenord igen")]
        [CompareAttribute("Password", ErrorMessage = "Lösenord matchar inte")]
        public string PasswordRepeat { get; set; }

        [Required(ErrorMessage = "Fyll i detta fält")]
        [Display(Name = "Telefon nummer")]
        public int PhoneNumber { get; set; }

        public bool RememberMe { get; set; }
    }
}