using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using TechnicalTask_01.Models;
using Microsoft.Owin;
using System.ServiceModel;
using Microsoft.AspNetCore.Http.Extensions;

namespace TechnicalTask_01.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class WebTrackerMiddleware 
    {
        private readonly RequestDelegate _next;

        public WebTrackerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            string sourceIP = context.GetServerVariable("HTTP_X_FORWARDED_FOR") ?? string.Empty;

            new Services.ServicioWCF().PutTracker(
                new WebTrack { 
                    URLRequest = context.Request.GetDisplayUrl().ToString(), 
                    SourceIp = sourceIP, 
                    TimeOfAction = DateTime.Now
                }).Wait();

            await _next(context);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class WebTrackerMiddlewareExtensions
    {
        public static IApplicationBuilder UseWebTrackerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<WebTrackerMiddleware>();
        }
    }
}
