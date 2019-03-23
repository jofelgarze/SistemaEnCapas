using CapaAccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
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

        public bool ModificarEstudianteSP(Estudiante registro) {
            // Create a SQL command to execute the sproc
            var cmd = contexto.Database.Connection.CreateCommand();
            cmd.CommandText = "[dbo].[sp_upd_estudiante] @Id, @FechaNacimiento, @Activo, @Altura, @Salario";

            cmd.Parameters.Add(new SqlParameter("@Id", registro.Id));
            cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", registro.FechaNacimiento));
            cmd.Parameters.Add(new SqlParameter("@Activo", registro.Activo));
            cmd.Parameters.Add(new SqlParameter("@Altura", registro.Altura));
            cmd.Parameters.Add(new SqlParameter("@Salario", registro.Salario));

            try
            {

                contexto.Database.Connection.Open();
                // Run the sproc
                var reader = cmd.ExecuteReader();

                // Read Blogs from the first result set
                var estudiantes = ((IObjectContextAdapter)contexto)
                    .ObjectContext
                    .Translate<Estudiante>(reader, "Estudiante", MergeOption.AppendOnly);


                foreach (var item in estudiantes.ToList())
                {
                    Console.WriteLine(item.Nombres);
                }

                // Move to second result set and read Posts
                //reader.NextResult();
                //var posts = ((IObjectContextAdapter)db)
                //    .ObjectContext
                //    .Translate<Post>(reader, "Posts", MergeOption.AppendOnly);


                //foreach (var item in posts)
                //{
                //    Console.WriteLine(item.Title);
                //}
            }
            finally
            {
                contexto.Database.Connection.Close();
            }
            return true;
        }

        public bool ModificarEstudianteSP2(Estudiante registro)
        {
            var Id = new SqlParameter("@Id", registro.Id);
            var FechaNacimiento = new SqlParameter("@FechaNacimiento", registro.FechaNacimiento);
            var Activo = new SqlParameter("@Activo", registro.Activo);
            var Altura = new SqlParameter("@Altura", registro.Altura);
            var Salario = new SqlParameter("@Salario", registro.Salario);

            var resultado = contexto.Database.SqlQuery<Estudiante>("exec [dbo].[sp_upd_estudiante] @Id, @FechaNacimiento, @Activo, @Altura, @Salario",
                Id, FechaNacimiento, Activo, Altura, Salario);

            foreach (var item in resultado.ToList())
            {
                Console.WriteLine(item.Nombres);
            }

            return true;
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
