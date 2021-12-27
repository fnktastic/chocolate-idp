using Chocolate.Domain.Core.Abstracts;
using Chocolate.Domain.Core.Dtos;
using Chocolate.Domain.Core.Entities;
using Chocolate.Domain.Core.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chocolate.Domain.Services
{
    public class ChocolateService : IChocolateService
    {
        private readonly IChocolateRepository _chocolateRepository;
        public ChocolateService(IChocolateRepository chocolateRepository)
        {
            _chocolateRepository = chocolateRepository;
        }

        public Task<IEnumerable<ChocolateDto>> GetAllAsync()
            => Task.FromResult(_chocolateRepository
                .Query<ChocolateEntity>()
                .ToList()
                .Select(e => e.ToChocolateDto())
                .AsEnumerable());
    }
}
