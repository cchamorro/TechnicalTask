using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTaskWcf;

namespace TechnicalTaskWcf.BLL
{
    /// <summary>
    /// Clase de reglas de negocio para el objeto Customer
    /// </summary>
    public class CustomerBLL
    {
        public List<Models.Customer> GetCustomersByCountry(string country) 
        {
            return new DAL.CustomerDAL().GetCustomersByCountry(country);
        }
    }
}
