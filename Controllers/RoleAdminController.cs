using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PrototypingASPNETCoreIdentity.Models;
using PrototypingASPNETCoreIdentity.Models.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace PrototypingASPNETCoreIdentity.Controllers
{
    public class RoleAdminController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<AppUser> _userManager;

        public RoleAdminController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            this._roleManager = roleManager;
            this._userManager = userManager;
        }

        public ViewResult Index() => View(_roleManager.Roles);

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create([Required]string roleName)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole { Name = roleName });

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }
            }

            return View(roleName);
        }
    }
}
