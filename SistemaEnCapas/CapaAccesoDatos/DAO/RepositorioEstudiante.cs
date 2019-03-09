using CapaAccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.DAO
{
    public class RepositorioEstudiante: IDisposable
    {
        //Declarar contexto de base de datos EF
        private ModeloDbEscuela contexto;

        //Inicializar el contexto de la base de datos
        public RepositorioEstudiante()
        {
            //Se inicializar el bloque de memoria donde
            //se cargaran los datos de las tablas registradas
            //en este contexto de EF
            contexto = new ModeloDbEscuela();
        }

        public List<Estudiante> ConsultarEstudiantes()
        {
            return contexto.Estudiante.ToList();
        }

        public bool CrearEstudiantes(Estudiante registro) {

            contexto.Estudiante.Add(registro);

            //Se ejecuta una evaluacion de los datos
            //que cambiaron (en el bloque de memoria) con respecto a la ultima vez
            //que se consulto la base de datos
            return contexto.SaveChanges() > 0;
        }

        public bool ModificarEstudiantes(Estudiante registro) {

            //Se obtiene el registro del contexto de DB con el fin
            //de minimizar el riesgo de inconsistencias, asi 
            //como una seguridad de que no se realizaran
            //modificaciones indeseadas
            var registroOriginal = contexto.Estudiante
                .Where(e => e.Id == registro.Id).SingleOrDefault();

            if (registroOriginal != null)
            {
                //Se modifica la informacion del registro original
                registroOriginal.Salario = registro.Salario;
                registroOriginal.Altura = registro.Altura;
                registroOriginal.Activo = registro.Activo;
                registroOriginal.FechaNacimiento = registro.FechaNacimiento;

                //Se ejecuta una evaluacion de los datos
                //que cambiaron (en el bloque de memoria) con respecto a la ultima vez
                //que se consulto la base de datos
                return contexto.SaveChanges() > 0;
            }
            return false;
        }

        public Estudiante EliminarEstudiantes(int Id)
        {
            //Se obtiene el registro del contexto de DB con el fin
            //de minimizar el riesgo de inconsistencias, asi 
            //como una seguridad de que no se realizaran
            //eliminaciones indeseadas de datos
            var registroOriginal = contexto.Estudiante
                .Where(e => e.Id == Id).SingleOrDefault();

            if (registroOriginal != null)
            {
                //Se elimina el registro del contexto de la DB
                //pero aun existe en la base de datos
                contexto.Estudiante.Remove(registroOriginal);

                //Se ejecuta la evaluacion de cambios y
                //se sincroniza la eliminacion de registro 
                contexto.SaveChanges();
            }
            return registroOriginal;
        }

        //Liberar recursos del contexto de la base de datos EF
        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
