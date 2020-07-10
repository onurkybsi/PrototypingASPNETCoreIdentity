using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PrototypingASPNETCoreIdentity.Models;
using PrototypingASPNETCoreIdentity.Models.ViewModels;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrototypingASPNETCoreIdentity.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<AppUser> _userManager;

        public AdminController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public ViewResult Index() => View(_userManager.Users);

        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(UserCreationModel newUser)
        {
            if (ModelState.IsValid)
            {
                AppUser _newUser = new AppUser
                {
                    UserName = newUser.Username,
                    Email = newUser.Email
                };

                var createUserResult = await _userManager.CreateAsync(_newUser, newUser.Password);

                if (createUserResult.Succeeded) 
                    return RedirectToAction("Index");
                else
                {
                    SetIdentityErrorsToModelState(createUserResult.Errors);
                }
            }

            return View(newUser);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if(user != null)
            {
                var result = await _userManager.DeleteAsync(user);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    SetIdentityErrorsToModelState(result.Errors);
                }
            }
            else
            {
                ModelState.AddModelError("Error", "User Not Found");
            }

            return View("Index", _userManager.Users);
        }

        private void SetIdentityErrorsToModelState(IEnumerable<IdentityError> identityErrors)
        {
            foreach (var error in identityErrors)
            {
                ModelState.AddModelError(error.Code, error.Description);
            }
        }
    }
}
