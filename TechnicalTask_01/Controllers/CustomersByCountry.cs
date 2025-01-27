using Microsoft.AspNetCore.Mvc;
using ServiceCustomerWCF;
using System.Diagnostics.Contracts;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Diagnostics;
using TechnicalTask_01.Models;
using System.Configuration;

namespace TechnicalTask_01.Controllers
{
    public class Customer : Controller
    {
        CustomerServiceClient? client = new CustomerServiceClient(
            new BasicHttpBinding(), 
            new EndpointAddress("http://cchamorro/technicaltaskwcf/TechnicalTaskWcf.CustomerService.svc"));

        public IActionResult CustomersByCountry()
        {
            //client = new CustomerServiceClient(new BasicHttpBinding(), new EndpointAddress(configuration.GetSection("ServiceURL").Value));
            return View();

        }

        [HttpPost]
        public JsonResult SearchCustomers(string country)
        {
            var customers = client.GetCustomersByCountry(country);
            return Json(customers);
        }

        public IActionResult CustomerOrdersInformation(string customerId)
        {
            var orders = client.GetOrdersByCustomerId(customerId);

            List<Models.Order> ordersList = orders
                .Select(o => new Models.Order
                {
                    CustomerId = o.CustomerId,
                    OrderDate = o.OrderDate,
                    OrderId = o.OrderId,
                    ShippedDate = o.ShippedDate,
                })
                .ToList();

            return View(ordersList);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
