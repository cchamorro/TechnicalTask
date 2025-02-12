using System;

namespace TechnicalTaskWcf.Models
{
    /// <summary>
    /// Objeto de modelo de negocio corrspondiente a la tabla Order
    /// </summary>
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
