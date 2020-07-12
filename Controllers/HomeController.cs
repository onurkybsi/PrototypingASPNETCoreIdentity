using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PrototypingASPNETCoreIdentity.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ViewResult Index() => View();
    }
}
