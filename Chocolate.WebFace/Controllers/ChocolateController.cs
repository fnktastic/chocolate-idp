using Chocolate.WebFace.HttpHelpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Chocolate.WebFace.Controllers
{
    [Authorize]
    public class ChocolateController : Controller
    {
        private readonly IdentityInformationHelper _identityInformationHelper;

        public ChocolateController(IdentityInformationHelper identityInformationHelper)
        {
            _identityInformationHelper = identityInformationHelper;
        }

        public async Task<IActionResult> Index()
        {
            await _identityInformationHelper.WriteOutIdentityInformation();

            //get chocolates from api...

            return View();
        }
    }
}
