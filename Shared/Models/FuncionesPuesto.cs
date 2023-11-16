using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class FuncionesPuesto
    {
        public int Id { get; set; }
        public string Funcion { get; set; }

        ICollection<FuncionesVacante> FuncionesVacantes { get; set; }
    }
}
