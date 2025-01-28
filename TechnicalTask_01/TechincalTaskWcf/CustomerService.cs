using System;
using System.Collections.Generic;
//using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TechnicalTaskWcf;

namespace TechnicalTaskWcf
{
    public class CustomerService : ICustomerService
    {
        public List<Models.Customer> GetCustomersByCountry(string country)
        {
            return new BLL.CustomerBLL().GetCustomersByCountry(country);
        }

        public List<Models.Order> GetOrdersByCustomerId(string customerId)
        {
            return new BLL.OrderBLL().GetOrdersByCustomerId(customerId);
        }

        public Boolean PutTracking(string urlRequest, string sourceIp, DateTime timeOfAction)
        {
            try
            {
                return new BLL.WebTrackBLL().PutTracking(
                    new Models.WebTrack { URLRequest = urlRequest, SourceIp = sourceIp, TimeOfAction = timeOfAction }
                    );
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
