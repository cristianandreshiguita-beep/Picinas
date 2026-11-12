using Lib_CHpicina.entidades;
using Lib_CHpicina.interfaces;
using Lib_CHpicina.nucleo;
using Microsoft.EntityFrameworkCore;

namespace Lib_CHpicina.implementaciones
{
    public class Conexion : DbContext, IConexion
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatosGenerales.StringConexion()!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<persona>? persona { get; set; }
    }
}
