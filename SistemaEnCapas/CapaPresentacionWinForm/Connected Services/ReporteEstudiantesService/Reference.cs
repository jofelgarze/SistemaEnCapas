﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaPresentacionWinForm.ReporteEstudiantesService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EstudianteVIP", Namespace="http://schemas.datacontract.org/2004/07/CapaServicioSoap.DTO")]
    [System.SerializableAttribute()]
    public partial class EstudianteVIP : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreCompletoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal SalarioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((this.EstadoField.Equals(value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreCompleto {
            get {
                return this.NombreCompletoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreCompletoField, value) != true)) {
                    this.NombreCompletoField = value;
                    this.RaisePropertyChanged("NombreCompleto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Salario {
            get {
                return this.SalarioField;
            }
            set {
                if ((this.SalarioField.Equals(value) != true)) {
                    this.SalarioField = value;
                    this.RaisePropertyChanged("Salario");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReporteEstudiantesService.IReporteEstudiantesService")]
    public interface IReporteEstudiantesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReporteEstudiantesService/EstudiantesSalarioVIP", ReplyAction="http://tempuri.org/IReporteEstudiantesService/EstudiantesSalarioVIPResponse")]
        CapaPresentacionWinForm.ReporteEstudiantesService.EstudianteVIP[] EstudiantesSalarioVIP(decimal salarioMinimo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReporteEstudiantesService/EstudiantesSalarioVIP", ReplyAction="http://tempuri.org/IReporteEstudiantesService/EstudiantesSalarioVIPResponse")]
        System.Threading.Tasks.Task<CapaPresentacionWinForm.ReporteEstudiantesService.EstudianteVIP[]> EstudiantesSalarioVIPAsync(decimal salarioMinimo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReporteEstudiantesServiceChannel : CapaPresentacionWinForm.ReporteEstudiantesService.IReporteEstudiantesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReporteEstudiantesServiceClient : System.ServiceModel.ClientBase<CapaPresentacionWinForm.ReporteEstudiantesService.IReporteEstudiantesService>, CapaPresentacionWinForm.ReporteEstudiantesService.IReporteEstudiantesService {
        
        public ReporteEstudiantesServiceClient() {
        }
        
        public ReporteEstudiantesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReporteEstudiantesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReporteEstudiantesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReporteEstudiantesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CapaPresentacionWinForm.ReporteEstudiantesService.EstudianteVIP[] EstudiantesSalarioVIP(decimal salarioMinimo) {
            return base.Channel.EstudiantesSalarioVIP(salarioMinimo);
        }
        
        public System.Threading.Tasks.Task<CapaPresentacionWinForm.ReporteEstudiantesService.EstudianteVIP[]> EstudiantesSalarioVIPAsync(decimal salarioMinimo) {
            return base.Channel.EstudiantesSalarioVIPAsync(salarioMinimo);
        }
    }
}