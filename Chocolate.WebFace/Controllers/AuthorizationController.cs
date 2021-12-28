using Chocolate.WebFace.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Chocolate.WebFace.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly IClientAuthorizationService _clientAuthorizationService;

        public AuthorizationController(IClientAuthorizationService clientAuthorizationService)
        {
            _clientAuthorizationService = clientAuthorizationService;
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _clientAuthorizationService.LogoutAsync();

            return Ok();
        }
    }
}
