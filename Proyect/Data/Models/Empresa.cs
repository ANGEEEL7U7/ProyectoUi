namespace Proyect.Data.Models{
    public class Empresas{
        public int Id_Empresa { get; set; } = 0;
        public int Rfc { get; set; }
        public string? Nombre_E { get; set; }
        public string? Contasenia_E { get; set; }
        public string? Ubicacion_E { get; set; }
        public DateTime Fecha_Regristro { get; set; }
        public int Id_Medidor_E { get; set; }
        public string? Correo_E { get; set; }
    }
}