using Lib_CHpicina.entidades;

namespace presentacion_CHpicina.interfaces
{
    public class personaPresentacion : IpersonaPresentacion
    {
        private IComunicaciones IComunicaciones;

        public personaPresentacion(IComunicaciones IComunicaciones)
        {
            this.IComunicaciones = IComunicaciones;
        }

        public persona Actualizar(persona entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<persona>(
                "persona/Actualizar", 
                entidad);
            task.Wait();
            return task.Result;
        }

        public persona Borrar(persona entidad)
        {
            if (entidad.Id == 0)
                throw new Exception("No se ha guardo");

            var task = this.IComunicaciones.Ejecutar<persona>(
                "persona/Borrar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<persona> Buscar(persona entidad)
        {
            var task = this.IComunicaciones.Ejecutar<List<persona>>(
                "persona/Buscar",
                entidad);
            task.Wait();
            return task.Result;
        }

        public List<persona> Consultar()
        {
            var task = this.IComunicaciones.Ejecutar<List<persona>>(
                "persona/Consultar",
                null);
            task.Wait();
            return task.Result;
        }

        public persona Insertar(persona entidad)
        {
            if (entidad.Id != 0)
                throw new Exception("Ya se guardo");

            if (Validar(entidad))
                throw new Exception("Falta informacion");

            var task = this.IComunicaciones.Ejecutar<persona>(
                "persona/Insertar",
                entidad);
            task.Wait();
            return task.Result;
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