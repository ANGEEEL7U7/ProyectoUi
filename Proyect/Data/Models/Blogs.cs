

namespace Proyect.Data.Models
{
    public class Blog
    {
        public int Id_Blog { get; set; } = 0;
        public string? UrlFoto { get; set; }
        public double? Uso_Agua { get; set; }
        public string? Ubicacion { get; set; }
        public string? Opinion { get; set; }
        public int? Id_Medidor_fk { get; set; }
    }
}