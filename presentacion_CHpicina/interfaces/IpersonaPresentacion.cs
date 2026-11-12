using Lib_CHpicina.entidades;

namespace presentacion_CHpicina.interfaces
{
    public interface IpersonaPresentacion
    {
        persona Insertar(persona entidad);
        persona Actualizar(persona entidad);
        List<persona> Consultar();
        List<persona> Buscar(persona entidad);
        persona Borrar(persona entidad);
    }
}