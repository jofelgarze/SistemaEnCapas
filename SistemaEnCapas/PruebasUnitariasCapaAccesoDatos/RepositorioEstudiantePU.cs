using System;
using CapaAccesoDatos.DAO;
using CapaAccesoDatos.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitariasCapaAccesoDatos
{
    [TestClass]
    public class RepositorioEstudiantePU
    {
        [TestMethod]
        public void PruebaConsultaEstudianteEF()
        {
            RepositorioEstudiante cliente = new RepositorioEstudiante();

            var resultado = cliente.ConsultarEstudiantes();

            Assert.IsTrue(resultado.Count > 0);

        }

        [TestMethod]
        public void PruebaInsertarEstudianteEF()
        {
            RepositorioEstudiante cliente = new RepositorioEstudiante();

            Estudiante registroNuevo = new Estudiante
            {
                Nombres = "Carlos",
                Apellidos = "Rodriguez",
                Activo = true,
                Altura = 1.67,
                FechaNacimiento = DateTime.Now,
                Genero = "M",
                Salario = (decimal)3500.26
            };

            var resultado = cliente.CrearEstudiantes(registroNuevo);

            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void PruebaModificarEstudianteEF()
        {
            RepositorioEstudiante cliente = new RepositorioEstudiante();

            var lista = cliente.ConsultarEstudiantes();

            Estudiante registro = lista[lista.Count - 1];

            registro.Activo = false;
            registro.Altura = 1.45;
            registro.FechaNacimiento = DateTime.Now;
            registro.Salario = (decimal)450.26;

            var resultado = cliente.ModificarEstudiantes(registro);

            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void PruebaEliminarEstudianteTablaADO()
        {
            RepositorioEstudiante cliente = new RepositorioEstudiante();

            var lista = cliente.ConsultarEstudiantes();

            Estudiante registro = lista[lista.Count - 1];

            var resultado = cliente.EliminarEstudiantes(registro.Id);

            Assert.IsTrue(resultado != null);

        }
    }
}
