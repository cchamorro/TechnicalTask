using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTaskWcf.DAL
{
    public class CustomerDAL : DataAccessLayer
    {
        public List<Models.Customer> GetCustomersByCountry(string country)
        {
            var result = (from a in db.Customers
                          where a.Country == country
                          select new Models.Customer
                          {
                              CustomerId = a.CustomerID,
                              CompanyName = a.CompanyName,
                              ContactName = a.ContactName,
                              Fax = a.Fax,
                              Phone = a.Phone
                          }).ToList();

            return result;
        }
    }
}
