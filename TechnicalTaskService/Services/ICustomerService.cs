using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TechnicalTaskService.Services
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        List<Customer> GetCustomersByCountry(string country);

        [OperationContract]
        List<Order> GetOrdersByCustomerId(string customerId);
    }

}
