using Chocolate.Domain.Core.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chocolate.Domain.Core.Abstracts
{
    public interface IChocolateService
    {
        Task<IEnumerable<ChocolateDto>> GetAllAsync();
    }
}
