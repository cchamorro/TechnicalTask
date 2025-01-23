using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using TechnicalTask_01.Models;
using Microsoft.Owin;
using ServiceCustomerWCF;
using System.ServiceModel;

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
            CustomerServiceClient? client = new CustomerServiceClient(
            new BasicHttpBinding(),
            new EndpointAddress("http://localhost/TechnicalTaskWcf/TechnicalTaskWcf.CustomerService.svc"));

            await client.PutTrackingAsync(
                context.GetServerVariable("url"),
                context.GetServerVariable("remote_addr"),
                DateTime.Now
                );

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
