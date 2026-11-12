
using Lib_CHpicina.entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Lib_CHpicina.interfaces
{
    public interface IConexion
    {
        DbSet<persona>? persona { get; set; }
        
        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
