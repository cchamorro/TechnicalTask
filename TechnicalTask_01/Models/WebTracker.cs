namespace TechnicalTask_01.Models
{
    public class WebTracker
    {
        public int Id { get; set; }
        public string URLRequest { get; set; }
        public string SourceIp { get; set; }
        public DateTime TimeOfAction { get; set; }
    }
}
