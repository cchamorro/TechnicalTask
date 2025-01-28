using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTaskWcf.BLL
{

    public class OrderBLL
    {
        public List<Models.Order> GetOrdersByCustomerId(string customerId)
        { 
            return new DAL.OrderDAL().GetOrdersByCustomerId(customerId);
        }
    }
}
