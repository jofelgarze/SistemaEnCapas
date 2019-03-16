using CapaAccesoDatos.Entidades;
using CapaServicioSoap.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CapaServicioSoap.Reportes
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IReporteEstudiantesService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IReporteEstudiantesService
    {
        [OperationContract]
        List<EstudianteVIP> EstudiantesSalarioVIP(decimal salarioMinimo);
    }
}
