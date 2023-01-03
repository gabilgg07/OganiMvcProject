using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ogani.WebUI.Areas.Admin.Models.ViewModel;
using Ogani.WebUI.Models.DataContext;
using Ogani.WebUI.Models.Entity.Membership;

namespace Ogani.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : MainController
    {
        readonly SignInManager<OganiUser> signInManager;
        readonly UserManager<OganiUser> userManager;
        readonly OganiDbContext db;

        public AccountController(SignInManager<OganiUser> signInManager,
            UserManager<OganiUser> userManager,
            OganiDbContext db)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.db = db;
        }

        [AllowAnonymous]
        public IActionResult Signin()
        {
            return View(new SignInModel
            {
                UserName = "aaliyeva0791@gmail.com",
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

            var checkResult = await signInManager.CheckPasswordSignInAsync(foundUser, user.Password, false);

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

        [HttpPost]
        [Authorize(Policy = "admin.account.setrole")]
        public async Task<IActionResult> SetRole(int userId, int roleId, bool selected)
        {
            var role = await db.Roles.FirstOrDefaultAsync(r => r.Id == roleId);

            if (role == null)
            {
                return Json(new
                {
                    error = true,
                    message = "Bele role yoxdur"
                });
            }

            if (selected)
            {
#warning role set etmek ucun

                if (await db.UserRoles.AnyAsync(ur => ur.UserId == userId && ur.RoleId == roleId))
                {
                    return Json(new
                    {
                        error = true,
                        message = "Istifadeci bu roldadir"
                    });
                }

                await db.UserRoles.AddAsync(new OganiUserRole
                {
                    UserId = userId,
                    RoleId = roleId
                });

                await db.SaveChangesAsync();
            }
            else
            {
#warning roldan cixartmaq ucun

                if (userId == UserId)
                {
                    return Json(new
                    {
                        error = true,
                        message = "Istifadeci oz rolunu deyise bilmez"
                    });
                }

                var userRole = await db.UserRoles.FirstOrDefaultAsync
                    (ur => ur.UserId == userId && ur.RoleId == roleId);
                if (userRole == null)
                {
                    return Json(new
                    {
                        error = true,
                        message = "Istifadeci bu rolda deyil"
                    });
                }

                db.UserRoles.Remove(userRole);
                await db.SaveChangesAsync();
            }

            return Json(new
            {
                error = false,
                message = "Successed"
            });
        }

        #region Crud

        [Authorize(Policy = "admin.account.users")]
        public async Task<IActionResult> Users()
        {
            var data = await db.Users.ToListAsync();

            return View(data);
        }

        [Authorize(Policy = "admin.account.userdetails")]
        public async Task<IActionResult> UserDetails(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }

            var user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            // join islemesi ucun using System.Linq; yazilmalidir
            var roles = (from r in db.Roles
                         join ur in db.UserRoles on new
                         {
                             RoleId = r.Id,
                             UserId = id
                         } equals new { ur.RoleId, ur.UserId }
                        into lGroup
                         from lg in lGroup.DefaultIfEmpty()
                         select Tuple.Create(r.Id, r.Name, lg != null ? true : false))
                        .ToArray();

            ViewBag.Roles = roles;

            return View(user);
        }

        #endregion
    }
}

