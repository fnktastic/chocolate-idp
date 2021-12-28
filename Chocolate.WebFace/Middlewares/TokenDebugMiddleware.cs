using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Chocolate.WebFace.Middlewares
{
    public class TokenDebuggerMiddleware
    {
        private readonly RequestDelegate _next;

        public TokenDebuggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IHttpContextAccessor httpContextAccessor)
        {
            var identityToken = await httpContextAccessor.HttpContext
                .GetTokenAsync(OpenIdConnectParameterNames.IdToken);

            var accessToken = await httpContextAccessor.HttpContext
                .GetTokenAsync(OpenIdConnectParameterNames.AccessToken);

            Debug.WriteLine($"Token: {identityToken}");
            Debug.WriteLine($"Access token: {accessToken}");

            await _next(context);
        }
    }
}
