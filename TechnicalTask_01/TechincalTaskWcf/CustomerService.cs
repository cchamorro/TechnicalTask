using System;
using System.Collections.Generic;
//using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TechincalTaskWcf;

namespace TechnicalTaskWcf
{
    public class CustomerService : ICustomerService
    {
        public northwindEntities1 db = new northwindEntities1();

        public List<Models.Customer> GetCustomersByCountry(string country)
        {
            var result = (from a in db.Customers
                          where a.Country == country
                          select new Models.Customer { 
                              CustomerId = a.CustomerID, 
                              CompanyName = a.CompanyName, 
                              ContactName = a.ContactName, 
                              Fax = a.Fax, 
                              Phone = a.Phone 
                          }).ToList();

            return result;
        }

        public List<Models.Order> GetOrdersByCustomerId(string customerId)
        {
            var result = (from o in db.Orders
                          where o.Customers.CustomerID == customerId
                          select new Models.Order
                          {
                              CustomerId = customerId,
                              OrderDate = o.OrderDate,
                              OrderId = o.OrderID,
                              ShippedDate = o.ShippedDate,
                          }).ToList();

            return result;
        }

        public Boolean PutTracking(string urlRequest, string sourceIp, DateTime timeOfAction)
        {
            try
            {
                db.WebTracker.Add(new WebTracker
                {
                    URLRequest = urlRequest,
                    SourceIp = sourceIp,
                    TimeOfAction = timeOfAction
                });
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
