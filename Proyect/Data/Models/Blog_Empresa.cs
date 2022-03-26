using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyect.Data.Models
{
    public class BlogEmpresa
    {
        public int Id_BlogEmpresa { get; set; } = 0;
        public string? UrlFoto_E { get; set; }
        public double Uso_Agua_E { get; set; }
        public string? Ubicacion_E { get; set; }
        public string? Opinion_E { get; set; }
        public int Id_Medidor_fk_E { get; set; }
    }
}