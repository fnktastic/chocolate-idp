using System.Threading.Tasks;

namespace Chocolate.WebFace.Services
{
    public interface IClientAuthorizationService
    {
        Task LogoutAsync();
    }
}
