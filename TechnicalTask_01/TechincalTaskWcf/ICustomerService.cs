using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TechnicalTaskWcf.Models;

namespace TechnicalTaskWcf
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        List<Customer> GetCustomersByCountry(string country);

        [OperationContract]
        List<Order> GetOrdersByCustomerId(string customerId);

        [OperationContract]
        Boolean PutTracking(string urlRequest, string sourceIp, DateTime timeOfAction);
    }

}
