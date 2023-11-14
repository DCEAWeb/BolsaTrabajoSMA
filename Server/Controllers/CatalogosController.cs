//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BolsaTrabajoSMA.Server.Data;
using BolsaTrabajoSMA.Shared.Models;
using BolsaTrabajoSMA.Server.Data;
using BolsaTrabajoSMA.Shared.Models;

namespace BolsaSMA.Server.Controllers
{
    //Agregamos seguridad de autenticación a nuestro controlador
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CatalogosController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet("TipoContratacion")]
        public async Task<List<TipoContratacion>> TipoContrataciones()
        {
            List<TipoContratacion> tipocontrataciones = new List<TipoContratacion>();
            tipocontrataciones = await context.tipoContrataciones.ToListAsync();

            return tipocontrataciones;
        }

    }
}
