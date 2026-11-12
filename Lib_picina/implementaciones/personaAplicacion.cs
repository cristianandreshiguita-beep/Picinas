
using Lib_CHpicina.entidades;
using Microsoft.EntityFrameworkCore;

namespace Lib_CHpicina.interfaces
{
    public class personaAplicacion : IpersonaAplicacion
    {
        private IConexion IConexion;

        public personaAplicacion(IConexion IConexion)
        {
            this.IConexion = IConexion;
        }

        public persona Actualizar(persona entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var entry = this.IConexion!.Entry<persona>(entidad);
            entry.State = EntityState.Modified;
            this.IConexion!.SaveChanges();
            return entidad;
        }

        public persona Borrar(persona entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            this.IConexion.persona!.Remove(entidad!);
            this.IConexion.SaveChanges();
            return entidad;
        }

        public List<persona> Buscar(persona entidad)
        {
            return this.IConexion.persona!
                .Where(x => x.Nombre!.Contains(entidad.Nombre!))
                .ToList();
        }

        public List<persona> Consultar()
        {
            return this.IConexion.persona!.Take(5).ToList();
        }

        public persona Insertar(persona entidad)
        {
            if (entidad.Id != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            this.IConexion.persona!.Add(entidad!);
            this.IConexion.SaveChanges();
            return entidad;
        }

        private bool Validar(persona entidad)
        {
            return string.IsNullOrEmpty(entidad.Codigo) ||
                string.IsNullOrEmpty(entidad.Nombre) ||
                entidad.Edad <= 0 ||
                double.IsNaN(entidad.precio) ||
                string.IsNullOrEmpty(entidad.Observaciones);
        }
    }
}