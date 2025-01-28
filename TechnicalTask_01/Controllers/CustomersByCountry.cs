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
        public IActionResult CustomersByCountry()
        {
            return View();

        }

        [HttpPost]
        public JsonResult SearchCustomers(string country)
        {
            var customers = new Services.ServicioWCF().GetCustomersByCountry(country);
            return Json(customers);
        }

        public IActionResult CustomerOrdersInformation(string customerId)
        {
            List<Models.Order> ordersList = new Services.ServicioWCF().GetOrdersByCustomerId(customerId);
            return View(ordersList);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
