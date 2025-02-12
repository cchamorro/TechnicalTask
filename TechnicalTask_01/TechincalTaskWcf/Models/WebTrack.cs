using System;

namespace TechnicalTaskWcf.Models
{
    /// <summary>
    /// Objeto de modelo de negocio corrspondiente a la tabla WebTracker
    /// </summary>
    public class WebTrack
    {
        public int Id { get; set; }
        public string URLRequest { get; set; }
        public string SourceIp { get; set; }
        public DateTime TimeOfAction { get; set; }
    }
}
