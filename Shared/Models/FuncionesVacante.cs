using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class FuncionesVacante
    {
        public int Id { get; set; }
        [Range(1, int.MaxValue)]
        public int VacanteId { get; set; }
        public Vacante? Vacante { get; set; }
        [Range(1, int.MaxValue)]
        public int FuncionesId { get; set; }
        public  FuncionesPuesto? Funciones { get; set; }
    }
}
