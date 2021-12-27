using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Chocolate.Api.Controllers
{
    public class HomeController : Controller
    {
        public Task<string> Index()
            => Task.FromResult("Api works.");
    }
}
