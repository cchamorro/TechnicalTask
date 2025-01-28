using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTaskWcf.DAL
{
    public class OrderDAL
    {
        public northwindEntities1 db = new northwindEntities1();

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
    }
}
