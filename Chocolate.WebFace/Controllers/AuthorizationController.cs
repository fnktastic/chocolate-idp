using Microsoft.AspNetCore.Mvc;

namespace Chocolate.WebFace.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
