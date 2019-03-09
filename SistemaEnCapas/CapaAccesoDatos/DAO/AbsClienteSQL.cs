using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.DAO
{
    public class AbsClienteSQL
    {
        //Declaran las constantes
        protected const string NOMBRE_CADENA_CONEXION = "ModeloDbEscuela";

        //Declarar variables privadas
        protected string cadenaConexion;
        protected SqlConnection conn;

        //Contructor(es)
        //para inicializar la variables declaradas
        public AbsClienteSQL()
        {
            this.cadenaConexion = System.Configuration.ConfigurationManager
                .ConnectionStrings[NOMBRE_CADENA_CONEXION].ConnectionString;
        }
        
    }
}
