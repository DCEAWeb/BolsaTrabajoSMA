using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class Habilidades
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Favor de registrar la {0}")]
        public string Habilidad { get; set; }

        ICollection<HabilidadesVacante> HabilidadesVacantes { get; set; }
    }
}
