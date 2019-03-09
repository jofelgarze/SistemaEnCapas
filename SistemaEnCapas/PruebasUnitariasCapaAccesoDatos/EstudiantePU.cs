using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaAccesoDatos.DAO;
using CapaAccesoDatos.Entidades;

namespace PruebasUnitariasCapaAccesoDatos
{
    [TestClass]
    public class EstudiantePU
    {
        [TestMethod]
        public void PruebaConsultaTablaEstudianteADO()
        {
            ClienteSQLEstudiante cliente = new ClienteSQLEstudiante();

            var resultado = cliente.ConsultarEstudiantes();

            Assert.IsTrue(resultado.Count > 0);

        }

        [TestMethod]
        public void PruebaInsertarEstudianteTablaADO()
        {
            ClienteSQLEstudiante cliente = new ClienteSQLEstudiante();

            Estudiante registroNuevo = new Estudiante {
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
        public void PruebaModificarEstudianteTablaADO()
        {
            ClienteSQLEstudiante cliente = new ClienteSQLEstudiante();

            var lista = cliente.ConsultarEstudiantes();
            
            Estudiante registro = lista[lista.Count - 1];

            registro.Activo = false;
            registro.Altura = 1.81;
            registro.FechaNacimiento = DateTime.Now;
            registro.Salario = (decimal)400.26;

            var resultado = cliente.ModificarEstudiantes(registro);

            Assert.IsTrue(!resultado);

        }

        [TestMethod]
        public void PruebaEliminarEstudianteTablaADO()
        {
            ClienteSQLEstudiante cliente = new ClienteSQLEstudiante();

            var lista = cliente.ConsultarEstudiantes();

            Estudiante registro = lista[lista.Count - 1];

            var resultado = cliente.EliminarEstudiantes(registro.Id);

            Assert.IsTrue(resultado != null);

        }
        //Declarar/Inicializar contexto de base de datos EF

        //Se define la variable de respuesta 


        //Se prepara la sentencia de SQL/Linq

        //Ejecucion

        //Liberar recursos del contexto de la base de datos EF
    }
}
