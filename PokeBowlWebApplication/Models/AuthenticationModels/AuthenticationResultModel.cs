using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeBowlWebApplication.Models.AuthenticationModels
{
    public class AuthenticationResultModel
    {
        public bool Success { get; set; }
        public string ResultMessage { get; set; }
    }
}