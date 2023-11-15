using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class HistorialLaboral
    {
        public int Id { get; set; }
        public string? Puesto { get; set;}
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin {  get; set; }
        public string? Estado { get; set; }
        public string? Municipio { get; set;}
        public string? Empresa { get; set;}
        public string? Tareas { get; set;}
    }
}
