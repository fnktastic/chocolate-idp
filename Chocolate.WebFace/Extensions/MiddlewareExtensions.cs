using Chocolate.WebFace.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace Chocolate.WebFace.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseTokenDebug(this IApplicationBuilder builder)
            => builder.UseMiddleware<TokenDebuggerMiddleware>();
    }
}
