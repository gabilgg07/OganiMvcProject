using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Ogani.WebUI.Areas.Admin.Models.ViewModel;
using Ogani.WebUI.Models.Entity.Membership;

namespace Ogani.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        readonly SignInManager<OganiUser> signInManager;
        readonly UserManager<OganiUser> userManager;

        public AccountController(SignInManager<OganiUser> signInManager, UserManager<OganiUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [AllowAnonymous]
        public IActionResult Signin()
        {
            return View(new SignInModel
            {
                UserName = "admin123@box.az",
                Password = "!2023@QabilCoder0707#"
            });
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Signin(SignInModel user)
        {
            var foundUser = await userManager.FindByEmailAsync(user.UserName);

            if (foundUser == null)
            {
                ModelState.AddModelError("UserName", "The username or password is incorrect");

                goto finish;
            }

            var checkResult = await signInManager.CheckPasswordSignInAsync(foundUser, user.Password,false);

            if (!checkResult.Succeeded)
            {
                ModelState.AddModelError("UserName", "The username or password is incorrect");

                goto finish;
            }

            if (!foundUser.EmailConfirmed)
            {
                ModelState.AddModelError("UserName", "Please, confirm your email address");

                goto finish;
            }

            var signinResult = await signInManager.PasswordSignInAsync(foundUser, user.Password, true, true);

            if (!signinResult.Succeeded)
            {
                ModelState.AddModelError("UserName", "The username or password is incorrect");

                goto finish;
            }

            string callbackUrl = Request.Query["ReturnUrl"].ToString();

            if (!string.IsNullOrWhiteSpace(callbackUrl))
            {
                return Redirect(callbackUrl);
            }

            return RedirectToAction("index", "home", routeValues: new
            {
                area = "admin"
            });

            finish:

            return View(user);
        }


        public async Task<IActionResult> Signout(SignInModel user)
        {
            await signInManager.SignOutAsync();
            return RedirectToAction(nameof(Signin));
        }

        public IActionResult AccessDenied(SignInModel user)
        {
            
            return View();
        }
    }
}

