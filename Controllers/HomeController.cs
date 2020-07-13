using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PrototypingASPNETCoreIdentity.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ViewResult Index() => View(GetUserData());

        private Dictionary<string, string> GetUserData()
        {
            return new Dictionary<string, string>
            {
                ["Username"] = HttpContext.User.Identity.Name,
                ["IsAuthenticated"] = HttpContext.User.Identity.IsAuthenticated ? "Login successful!" : "Login failed!"
            };
        }
    }
}
