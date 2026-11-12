using Lib_CHpicina.entidades;
using Lib_CHpicina.implementaciones;
using Lib_CHpicina.interfaces;
using Microsoft.EntityFrameworkCore;
using pruebas_ganado.Nucleo;

namespace pruebas_ganado.Repositorios
{
    [TestClass]
    public class personaPrueba
    {
        private readonly IConexion? iConexion;
        private List<persona>? lista;
        private persona? entidad;

        public personaPrueba()
        {
            iConexion = new Conexion();
        }

        [TestMethod]
        public void Ejecutar()
        {
            Assert.IsTrue(Guardar());
            Assert.IsTrue(Modificar());
            Assert.IsTrue(Listar());
            Assert.IsTrue(Borrar());
        }

        public bool Listar()
        {
            this.lista = this.iConexion!.persona!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            this.entidad = EntidadesNucleo.persona()!;

            this.iConexion!.persona!.Add(this.entidad);
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Modificar()
        {
            this.entidad!.Activo = true;

            var entry = this.iConexion!.Entry<persona>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();

            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.persona!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }
}