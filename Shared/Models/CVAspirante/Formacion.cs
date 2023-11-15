using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class Formacion
    {
        public int Id { get; set; }
        public string NivelEstudios { get; set;}
        public DateTime FechaFin {  get; set; }
        public string? Area { get; set; }
        public string? Universidad { get; set;}
        public string? Adicional { get; set;}

    }
}
