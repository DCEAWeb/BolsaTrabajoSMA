using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class Curriculum
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Favor de capturar el nombre")]
        [MinLength(2, ErrorMessage = "El nombre del puesto debe tener al menos {1} caracteres")]
        [MaxLength(50, ErrorMessage = "El nombre del puesto debe tener maximo {1} caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Favor de capturar el {0}")]
        public string Pais { get; set; }
        [Required(ErrorMessage = "Favor de capturar el {0}")]
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
        public string Aptitudes { get; set; }
        public string Diplomas { get; set; }

    }
}
