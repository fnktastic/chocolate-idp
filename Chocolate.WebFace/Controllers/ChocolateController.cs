using Chocolate.WebFace.HttpHelpers;
using Chocolate.WebFace.Services;
using Chocolate.WebFace.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Chocolate.WebFace.Controllers
{
    [Authorize]
    public class ChocolateController : Controller
    {
        private readonly IChocolateApiService _chocolateApiService;

        public ChocolateController(IChocolateApiService chocolateApiService)
        {
            _chocolateApiService = chocolateApiService;
        }

        [Authorize( Roles = "Admin" )]
        public async Task<IActionResult> Index()
        {
            var chocolates = await _chocolateApiService.GetAllAsync();

            return View(new ChocolatesViewModel
            {
                Chocolates = chocolates
            });
        }
    }
}
