using System.ComponentModel.DataAnnotations;

namespace PokeBowlWebApplication.Models.AuthenticationModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Fyll i detta fält")]
        [Display(Name = "E-post")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Fyll i detta fält")]
        [Display(Name = "Lösenord")]
        public string Password { get; set; }
        [Display(Name ="Kom ihåg mig")]
        public bool RememberMe { get; set; }
    }
}