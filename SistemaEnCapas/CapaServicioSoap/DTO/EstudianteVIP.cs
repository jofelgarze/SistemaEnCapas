using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CapaServicioSoap.DTO
{
    [DataContract]
    public class EstudianteVIP
    {
        [DataMember]
        public int Codigo { get; set; }

        [DataMember]
        public string NombreCompleto { get; set; }

        [DataMember]
        public decimal Salario { get; set; }

        [DataMember]
        public bool Estado { get; set; }
    }
}