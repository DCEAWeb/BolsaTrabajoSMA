using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class Beneficios
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Favor de capturar el {0}")]
        public string Beneficio { get; set; }

        ICollection<BeneficiosVacante> BeneficiosVacantes { get; set; }
    }
}
