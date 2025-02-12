namespace TechnicalTask_01.Models
{
    /// <summary>
    /// Objeto de modelo de negocio correspondiente a la tabla WebTrack 
    /// </summary>
    public class WebTrack
    {
        public int Id { get; set; }
        public string URLRequest { get; set; }
        public string SourceIp { get; set; }
        public DateTime TimeOfAction { get; set; }
    }
}
