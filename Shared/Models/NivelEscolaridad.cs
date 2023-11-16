using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class NivelEscolaridad
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nivel { get; set; }

        ICollection<Vacante> Vacantes { get; set; }
    }
}
