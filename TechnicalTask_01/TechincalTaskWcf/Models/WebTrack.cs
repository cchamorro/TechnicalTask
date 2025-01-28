using System;

namespace TechnicalTaskWcf.Models
{
    public class WebTrack
    {
        public int Id { get; set; }
        public string URLRequest { get; set; }
        public string SourceIp { get; set; }
        public DateTime TimeOfAction { get; set; }
    }
}
