using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CapaAccesoDatos.Entidades;
using CapaServicioSoap.DTO;

namespace CapaServicioSoap.Reportes
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ReporteEstudiantesService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ReporteEstudiantesService.svc o ReporteEstudiantesService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ReporteEstudiantesService : IReporteEstudiantesService
    {
        private ModeloDbEscuela contexto;

        public ReporteEstudiantesService()
        {
            contexto = new ModeloDbEscuela();
        }

        public List<EstudianteVIP> EstudiantesSalarioVIP(decimal salarioMinimo)
        {
            var resultado = contexto.Estudiante
                .Where(e => e.Salario >= salarioMinimo)
                .Select(e => new EstudianteVIP {
                    Codigo = e.Id,
                    NombreCompleto = e.Apellidos + " " + e.Nombres,
                    Estado = e.Activo,
                    Salario = e.Salario.HasValue ? e.Salario.Value : 0
                })
                .ToList();
            return resultado;
        }
    }
}
