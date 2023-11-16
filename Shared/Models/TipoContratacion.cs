using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class TipoContratacion
    {
        public int Id { get; set; }
        [Required]
        public string Tipo { get; set; }

        ICollection<Vacante> Vacantes { get; set; }
    }
}
