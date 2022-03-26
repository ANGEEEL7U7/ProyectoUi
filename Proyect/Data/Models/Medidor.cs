using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Proyect.Data.Models
{
    public class Medidor
    {
        public int Id_Medidor { get; set; } = 0;
        public string? Marca { get; set; }
        public string? Proveedor { get; set; }
    }
}