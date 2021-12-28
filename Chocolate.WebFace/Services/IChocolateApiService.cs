using Chocolate.Domain.Core.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chocolate.WebFace.Services
{
    public interface IChocolateApiService
    {
        Task<IEnumerable<ChocolateDto>> GetAllAsync();
    }
}
