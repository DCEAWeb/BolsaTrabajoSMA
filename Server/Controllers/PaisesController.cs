using BolsaTrabajoSMA.Server.Data;
using BolsaTrabajoSMA.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BolsaTrabajoSMA.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public PaisesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet("paises")]
        public async Task<List<ListaPaises>> Paises()
        {
            List<ListaPaises> paises = new List<ListaPaises>();
            paises = await context.listaPaises.ToListAsync();          
            return paises;
        }

    }
}
