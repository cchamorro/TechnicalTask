namespace TechnicalTaskWcf.Models
{
    /// <summary>
    /// Objeto de modelo de negocio correspondiente a la tabla Customers. 
    /// </summary>
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}
