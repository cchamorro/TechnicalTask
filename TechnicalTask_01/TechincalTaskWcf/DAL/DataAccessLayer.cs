using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTaskWcf.DAL
{
    /// <summary>
    /// Clase singleton para manejo de instancia de acceso a la base de datos, mediante el objeto de EntityFramework
    /// </summary>
    public class DataAccessLayer
    {
        public northwindEntities1 db = new northwindEntities1();
    }
}
