using Lib_CHpicina.entidades;

namespace Lib_CHpicina.interfaces
{
    public interface IpersonaAplicacion
    {
        persona Insertar(persona entidad);
        persona Actualizar(persona entidad);
        List<persona> Consultar();
        List<persona> Buscar(persona entidad);
        persona Borrar(persona entidad);
    }
}