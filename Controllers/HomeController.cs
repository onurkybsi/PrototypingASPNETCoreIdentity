using Microsoft.AspNetCore.Mvc;

namespace PrototypingASPNETCoreIdentity.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View();
    }
}
