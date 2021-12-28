using Chocolate.Domain.Core.Abstracts;
using Chocolate.Domain.Core.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chocolate.Api.Controllers
{
    [ApiController]
    [Authorize]
    public class ChocolateController : Controller
    {
        private readonly IChocolateService _chocolateService;

        public ChocolateController(IChocolateService chocolateService)
        {
            _chocolateService = chocolateService;
        }

        [HttpGet("api/chocolate/getall")]
        [Authorize( Roles = "Admin" )]
        public Task<IEnumerable<ChocolateDto>> GetAll()
        {
            return _chocolateService.GetAllAsync();
        }
    }
}
