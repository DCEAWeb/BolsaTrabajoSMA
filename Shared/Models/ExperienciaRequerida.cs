using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class ExperienciaRequerida
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Favor de capturar la {0}")]
        public string Experiencia { get; set; }

        ICollection<ExperienciaVacante> ExperienciaVacantes { get; set; }
    }
}
