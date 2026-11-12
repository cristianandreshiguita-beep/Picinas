using Lib_CHpicina.entidades;
using Lib_CHpicina.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace servicios_persona.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class personaController : ControllerBase
    {
        private IpersonaAplicacion IpersonaAplicacion;

        public personaController(IpersonaAplicacion IpersonaAplicacion)
        {
            this.IpersonaAplicacion = IpersonaAplicacion;
        }

        [HttpPost]
        public List<persona> Consultar()
        {
            return this.IpersonaAplicacion.Consultar();
        }

        [HttpPost]
        public List<persona> Buscar(persona entidad)
        {
            return this.IpersonaAplicacion.Buscar(entidad);
        }

        [HttpPost]
        public persona Insertar(persona entidad)
        {
            return this.IpersonaAplicacion.Insertar(entidad);
        }

        [HttpPost]
        public persona Actualizar(persona entidad)
        {
            return this.IpersonaAplicacion.Actualizar(entidad);
        }

        [HttpPost]
        public persona Borrar(persona entidad)
        {
            return this.IpersonaAplicacion.Borrar(entidad);
        }
    }
}
