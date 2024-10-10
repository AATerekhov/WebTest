using Microsoft.AspNetCore.Builder;

namespace WebTest
{
    public class MyMiddleware(RequestDelegate next, ILogger<MyMiddleware> logger)
    {        
        public async Task InvokeAsync(HttpContext httpContent) 
        {
            logger.LogInformation("Я вызван!");
        }
    }

    public static class MiddlewareExtention
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder app) 
        {
            return app.UseMiddleware<MyMiddleware>();
        }
    }
}
