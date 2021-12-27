using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Chocolate.WebFace.HttpHelpers
{
    public class IdentityInformationHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IdentityInformationHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task WriteOutIdentityInformation()
        {
            var identityToken = await _httpContextAccessor.HttpContext
                .GetTokenAsync(OpenIdConnectParameterNames.IdToken);

            Debug.WriteLine($"Token: {identityToken}");
        }
    }
}
