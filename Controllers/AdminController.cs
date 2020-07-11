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
        private IUserValidator<AppUser> _userValidator;
        private IPasswordValidator<AppUser> _passwordValidator;
        private IPasswordHasher<AppUser> _passwordHasher;

        public AdminController(UserManager<AppUser> userManager, IUserValidator<AppUser> userValidator, IPasswordValidator<AppUser> passwordValidator, IPasswordHasher<AppUser> passwordHasher)
        {
            _userManager = userManager;
            _userValidator = userValidator;
            _passwordValidator = passwordValidator;
            _passwordHasher = passwordHasher;
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

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, string email, string password)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                if (string.IsNullOrWhiteSpace(email))
                {
                    ModelState.AddModelError("Email error", "Email is required!");
                }
                if (string.IsNullOrWhiteSpace(password))
                {
                    ModelState.AddModelError("Password error", "Password is required!");
                }
                if (!(string.IsNullOrWhiteSpace(email)) && !(string.IsNullOrWhiteSpace(password)))
                {
                    var userValidation = await _userValidator.ValidateAsync(_userManager, user);

                    if (userValidation.Succeeded)
                    {
                        user.PasswordHash = _passwordHasher.HashPassword(user, password);
                    }
                    else
                    {
                        SetIdentityErrorsToModelState(userValidation.Errors);
                    }

                    var passwordValidation = await _passwordValidator.ValidateAsync(_userManager, user, password);

                    if (passwordValidation.Succeeded)
                    {
                        user.Email = email;
                    }
                    else
                    {
                        SetIdentityErrorsToModelState(passwordValidation.Errors);
                    }

                    if (userValidation.Succeeded && passwordValidation.Succeeded)
                    {
                        var result = await _userManager.UpdateAsync(user);

                        if (result.Succeeded)
                            return RedirectToAction("Index");
                        else
                        {
                            SetIdentityErrorsToModelState(result.Errors);
                        }
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User not found!");
            }

            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                var result = await _userManager.DeleteAsync(user);

                if (result.Succeeded)
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
