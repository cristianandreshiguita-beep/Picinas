using Lib_CHpicina.entidades;

namespace pruebas_ganado.Nucleo
{
    public class EntidadesNucleo
    {
        public static persona? persona()
        {
            var entidad = new persona();
            entidad.Codigo = "C-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre = "N-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Edad = 20;
            entidad.precio = 25000.00;
            entidad.Activo = false;
            entidad.Observaciones = "O-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            return entidad;
        }
    }
}
