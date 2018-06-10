using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeBowlWebApplication.Models.AuthenticationModels
{
    public class RegisterViewModel
    {
        public string Username { get; set; }
        public string password { get; set; }
        public string PasswordRepeat { get; set; }
        public bool RememberMe { get; set; }
        public string PhoneNumber { get; set; }

    }
}