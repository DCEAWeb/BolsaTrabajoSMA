using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class Vacante
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Favor de capturar el nombre del puesto")]
        [MinLength(5,ErrorMessage ="El nombre del puesto debe tener al menos {1} caracteres")]
        [MaxLength(50,ErrorMessage ="El nombre del puesto debe tener maximo {1} caracteres")]
        public string NombrePuesto { get; set; }
        
        [Required(ErrorMessage ="Favor de capturar el {0}")]
        [Range(0.1f,float.MaxValue,ErrorMessage ="El {0} debe ser mayor a {1}")]
        public float Sueldo { get; set; }
       
        [Required(ErrorMessage = "Favor de capturar el {0}")]
        [MinLength(5, ErrorMessage = "El {0} debe tener al menos {1} caracteres")]
        [MaxLength(50, ErrorMessage = "El {0} debe tener maximo {1} caracteres")]
        public string Lugar { get; set; }
        
        [Required(ErrorMessage = "Favor de capturar las {0}")]
        public string Coordenadas { get; set; }
        [Range(1,int.MaxValue)]
        public int ModalidadId { get; set; }
        public Modalidades? Modalidad { get; set; }
        [Range(1, int.MaxValue)]
        public int NivelEscolaridadId { get; set; }
        public NivelEscolaridad? NivelEscolaridad { get; set; }
        [Range(1, int.MaxValue)]
        public int TipoContratacionId { get; set; }
        public TipoContratacion? TipoContratacion { get; set; }

        ICollection<FuncionesVacante> FuncionesVacantes { get; set; }
        ICollection<BeneficiosVacante> BeneficiosVacantes { get; set; }
        ICollection<ExperienciaVacante> ExperienciaVacantes { get; set; }
        ICollection<HabilidadesVacante> HabilidadesVacantes { get; set; }
        ICollection<IdiomasVacante> IdiomasVacantes { get; set; }
    }
}
