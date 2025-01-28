using System.ServiceModel;
using ServiceCustomerWCF;

namespace TechnicalTask_01.Services
{
    public class ServicioWCF
    {
        CustomerServiceClient client = new CustomerServiceClient(
            new BasicHttpBinding(),
            new EndpointAddress("http://cchamorro/technicaltaskwcf/TechnicalTaskWcf.CustomerService.svc"));

        public Task<bool> PutTracker(Models.WebTrack webTrack)
        {
            return client.PutTrackingAsync(
                webTrack.URLRequest,
                webTrack.SourceIp,
                webTrack.TimeOfAction
                );
        }

        public List<Models.Customer> GetCustomersByCountry(string country)
        {
            var customers = client.GetCustomersByCountry(country);

            List<Models.Customer> customersList = customers
                .Select(o => new Models.Customer
                {
                    CompanyName = o.CompanyName,
                    ContactName = o.ContactName,
                    CustomerId = o.CustomerId,
                    Fax = o.Fax,
                    Phone = o.Phone
                })
                .ToList();

            return customersList;
        }

        public List<Models.Order> GetOrdersByCustomerId(string customerId)
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

            return ordersList;
        }
    }
}
