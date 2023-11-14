using Microsoft.EntityFrameworkCore;
using BolsaTrabajoSMA.Shared.Models;
//using System.Collections.Generic;
//using System.Reflection.Emit;

namespace BolsaTrabajoSMA.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        //internal object tipocontrataciones;
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
        public DbSet<TipoContratacion> tipoContrataciones { get; set; }

        public DbSet<NombrePuesto> nombrePuestos { get; set; }
        public DbSet<Escolaridad> escolaridadess { get; set; }

        public DbSet<Habilidades> habilidades { get; set; }

        public DbSet<Responsabilidades> responsabilidades { get; set; }

        public DbSet<Modalidad> modalidades { get; set; }





    }
}
