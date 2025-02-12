namespace TechnicalTask_01.Models
{
    /// <summary>
    /// Objeto de modelo de negocio correspondiente a la tabla Orders. 
    /// </summary>
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
    }
}
