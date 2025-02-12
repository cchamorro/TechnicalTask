namespace TechnicalTask_01.Models
{
    /// <summary>
    /// Clase para manejar y mostrar información sobre errores en la aplicación
    /// </summary>
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}