using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class Curriculum
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NumTelefono { get; set; }
        public string Correo { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string CP { get; set; }
        public string NumInterior { get; set; }
        public string NumExterior { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }

    }
}
