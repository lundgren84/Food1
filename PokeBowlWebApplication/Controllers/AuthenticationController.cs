using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PokeBowlWebApplication.Models.AuthenticationModels;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PokeBowlWebApplication.Controllers
{
    public class AuthenticationController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private RoleManager<IdentityRole> roleManager;
        public AuthenticationController()
        {
            var context = new IdentityDatabaseContext();
            var store = new UserStore<IdentityUser>(context);
            userManager = new UserManager<IdentityUser>(store);
            roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        }

        public ActionResult Register()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            var resultModel = new AuthenticationResultModel();
            if (!ModelState.IsValid)
            {
                resultModel.Success = false;
                resultModel.ResultMessage = "Unvalid input values!";
                return Json(resultModel, JsonRequestBehavior.AllowGet);
            }

            var user = new IdentityUser
            {
                UserName = model.Username,
                Email = model.Username,
                PhoneNumber = model.PhoneNumber

            };
            var result = await userManager.CreateAsync(user, model.password);

            if (result.Succeeded)
            {
                var identity = await userManager.CreateIdentityAsync(user,
                    DefaultAuthenticationTypes.ApplicationCookie);

                var authorisationManager =
                    HttpContext.GetOwinContext().Authentication;
                //Sign in
                authorisationManager.SignIn(identity);

                resultModel.Success = true;
                return Json(resultModel, JsonRequestBehavior.AllowGet);
            }
            resultModel.Success = false;
            resultModel.ResultMessage = result.Errors.First();
            return Json(resultModel, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginModel model)
        {
            var resultModel = new AuthenticationResultModel();

            if (!ModelState.IsValid)
            {
                model.Password = string.Empty;
                ModelState.AddModelError(string.Empty, "Fel e-post eller lösenord");
                return PartialView("_LoginForm",model);
                //return Json(resultModel, JsonRequestBehavior.AllowGet);
            }

            var user = await userManager.FindAsync(model.Username, model.Password);
            if (user == null)
            {
                model.Password = string.Empty;
                ModelState.AddModelError(string.Empty, "Fel e-post eller lösenord");
                return PartialView("_LoginForm", model);
            }

            var identity = await userManager.CreateIdentityAsync(user,
                DefaultAuthenticationTypes.ApplicationCookie);
            var authorisationManager = HttpContext.GetOwinContext().Authentication;
            authorisationManager.SignIn(identity);

            resultModel.Success = true;
            return Content("great success");
        }

        public ActionResult Logout()
        {
            var authorisationManager = HttpContext.GetOwinContext().Authentication;
            authorisationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);

            return RedirectToAction("Index","Home",null);
        }
    }
}