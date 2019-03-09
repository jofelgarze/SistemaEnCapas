using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaAccesoDatos.Entidades;
using System.Data;

namespace CapaAccesoDatos.DAO
{
   public class ClienteSQLEstudiante: AbsClienteSQL
    {

        public List<Estudiante> ConsultarEstudiantes() {

            //Declarar variables de retorno 
            List<Estudiante> resultado = new List<Estudiante>();

            //Declarar una conexion a la base de datos
            this.conn = new SqlConnection(this.cadenaConexion);

            //Abrir la conexion
            this.conn.Open();

            //Definir la sentencia SQL a ejecutar
            string sentenciaSQL = "SELECT * FROM Estudiante";

            //Declarar el comando SQL a ejecutar en la base de datos
            SqlCommand comandoSQL = new SqlCommand(sentenciaSQL,this.conn);

            //Decarar la variable reader para recibir los resultados
            SqlDataReader reader = comandoSQL.ExecuteReader();

            //Recorrer el cursor de resultado de sentencia SQL de consulta
            Estudiante registro;
            while (reader.Read()) {
                registro = new Estudiante();
                registro.Id = reader.GetInt32(0);
                registro.Nombres = reader.GetString(1);
                registro.Apellidos = reader.GetString(2);
                registro.FechaNacimiento = reader.GetDateTime(3);
                registro.Activo = reader.GetBoolean(4);
                registro.Genero = reader.GetString(5);
                registro.Altura = reader.GetDouble(6);               
                registro.Salario = reader.GetDecimal(7);
                resultado.Add(registro);
            }

            //Cerrar la conexion a la base
            this.conn.Close();

            return resultado;
        }

        public bool CrearEstudiantes(Estudiante registro)
        {
            //Declarar una conexion a la base de datos
            this.conn = new SqlConnection(this.cadenaConexion);

            //Abrir la conexion
            this.conn.Open();

            //Definir la sentencia SQL a ejecutar
            string sentenciaSQL = "INSERT INTO[dbo].[Estudiante]" +
           "([Nombres],[Apellidos],[FechaNacimiento],[Activo]" +
           ",[Genero],[Altura],[Salario])" +
           "VALUES (@Nombres,@Apellidos,@FechaNacimiento, @Activo" +
           ",@Genero,@Altura,@Salario)";

            //Declarar el comando SQL a ejecutar en la base de datos
            SqlCommand comandoSQL = new SqlCommand(sentenciaSQL, this.conn);

            comandoSQL.Parameters.Add("@Nombres", SqlDbType.VarChar, 150).Value = registro.Nombres;
            comandoSQL.Parameters.Add("@Apellidos", SqlDbType.VarChar, 150).Value = registro.Apellidos;
            comandoSQL.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = registro.FechaNacimiento;
            comandoSQL.Parameters.Add("@Activo", SqlDbType.Bit).Value = registro.Activo;
            comandoSQL.Parameters.Add("@Genero", SqlDbType.Char, 1).Value = registro.Genero;
            comandoSQL.Parameters.Add("@Altura", SqlDbType.Float).Value = registro.Altura;
            comandoSQL.Parameters.Add("@Salario", SqlDbType.Decimal).Value = registro.Salario;

            //Declarar variable para capturar resultado de ejecucion de sentencia SQL
            int registrosAfectados = comandoSQL.ExecuteNonQuery();

            //Cerrar la conexion a la base
            this.conn.Close();

            return registrosAfectados == 1;
        }

        public bool ModificarEstudiantes(Estudiante registro)
        {
            //Declarar una conexion a la base de datos
            this.conn = new SqlConnection(this.cadenaConexion);

            //Abrir la conexion
            this.conn.Open();

            //Definir la sentencia SQL a ejecutar
            string sentenciaSQL = "sp_upd_estudiante";

            //Declarar el comando SQL a ejecutar en la base de datos
            SqlCommand comandoSQL = new SqlCommand(sentenciaSQL, this.conn);

            //Especificar tipo sentencia SQL
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add("@Id", SqlDbType.Int).Value = registro.Id;
            comandoSQL.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = registro.FechaNacimiento;
            comandoSQL.Parameters.Add("@Activo", SqlDbType.Bit).Value = registro.Activo;
            comandoSQL.Parameters.Add("@Altura", SqlDbType.Float).Value = registro.Altura;
            comandoSQL.Parameters.Add("@Salario", SqlDbType.Decimal).Value = registro.Salario;

            //Declarar variable para capturar resultado de ejecucion de sentencia SQL
            int registrosAfectados = comandoSQL.ExecuteNonQuery();

            //Cerrar la conexion a la base
            this.conn.Close();

            return registrosAfectados == 1;
        }

        public Estudiante EliminarEstudiantes(int Id)
        {
            Estudiante registro = null;
            //Declarar una conexion a la base de datos
            this.conn = new SqlConnection(this.cadenaConexion);

            //Abrir la conexion
            this.conn.Open();

            //Definir la sentencia SQL a ejecutar
            string sentenciaSQL = "sp_del_estudiante";

            //Declarar el comando SQL a ejecutar en la base de datos
            SqlCommand comandoSQL = new SqlCommand(sentenciaSQL, this.conn);

            //Especificar tipo sentencia SQL
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add("@Id", SqlDbType.Int).Value = Id;

            //Decarar la variable reader para recibir los resultados
            SqlDataReader reader = comandoSQL.ExecuteReader();

            //Recorrer el cursor de resultado de sentencia SQL de consulta
            
            while (reader.Read())
            {
                registro = new Estudiante();
                registro.Id = reader.GetInt32(0);
                registro.Nombres = reader.GetString(1);
                registro.Apellidos = reader.GetString(2);
                registro.FechaNacimiento = reader.GetDateTime(3);
                registro.Activo = reader.GetBoolean(4);
                registro.Genero = reader.GetString(5);
                registro.Altura = reader.GetDouble(6);
                registro.Salario = reader.GetDecimal(7);
            }

            //Cerrar la conexion a la base
            this.conn.Close();

            return registro;
        }

    }
}
