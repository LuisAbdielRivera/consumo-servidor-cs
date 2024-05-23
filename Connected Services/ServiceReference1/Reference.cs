﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clienteServidor.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaNacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public System.DateTime FechaNacimiento {
            get {
                return this.FechaNacimientoField;
            }
            set {
                if ((this.FechaNacimientoField.Equals(value) != true)) {
                    this.FechaNacimientoField = value;
                    this.RaisePropertyChanged("FechaNacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCliente {
            get {
                return this.IdClienteField;
            }
            set {
                if ((this.IdClienteField.Equals(value) != true)) {
                    this.IdClienteField = value;
                    this.RaisePropertyChanged("IdCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IClienteService")]
    public interface IClienteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ObtenerClientes", ReplyAction="http://tempuri.org/IClienteService/ObtenerClientesResponse")]
        clienteServidor.ServiceReference1.Cliente[] ObtenerClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ObtenerClientes", ReplyAction="http://tempuri.org/IClienteService/ObtenerClientesResponse")]
        System.Threading.Tasks.Task<clienteServidor.ServiceReference1.Cliente[]> ObtenerClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/InsertarCliente", ReplyAction="http://tempuri.org/IClienteService/InsertarClienteResponse")]
        void InsertarCliente(clienteServidor.ServiceReference1.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/InsertarCliente", ReplyAction="http://tempuri.org/IClienteService/InsertarClienteResponse")]
        System.Threading.Tasks.Task InsertarClienteAsync(clienteServidor.ServiceReference1.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ModificarCliente", ReplyAction="http://tempuri.org/IClienteService/ModificarClienteResponse")]
        void ModificarCliente(clienteServidor.ServiceReference1.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/ModificarCliente", ReplyAction="http://tempuri.org/IClienteService/ModificarClienteResponse")]
        System.Threading.Tasks.Task ModificarClienteAsync(clienteServidor.ServiceReference1.Cliente c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/EliminarCliente", ReplyAction="http://tempuri.org/IClienteService/EliminarClienteResponse")]
        void EliminarCliente(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/EliminarCliente", ReplyAction="http://tempuri.org/IClienteService/EliminarClienteResponse")]
        System.Threading.Tasks.Task EliminarClienteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteServiceChannel : clienteServidor.ServiceReference1.IClienteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteServiceClient : System.ServiceModel.ClientBase<clienteServidor.ServiceReference1.IClienteService>, clienteServidor.ServiceReference1.IClienteService {
        
        public ClienteServiceClient() {
        }
        
        public ClienteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public clienteServidor.ServiceReference1.Cliente[] ObtenerClientes() {
            return base.Channel.ObtenerClientes();
        }
        
        public System.Threading.Tasks.Task<clienteServidor.ServiceReference1.Cliente[]> ObtenerClientesAsync() {
            return base.Channel.ObtenerClientesAsync();
        }
        
        public void InsertarCliente(clienteServidor.ServiceReference1.Cliente c) {
            base.Channel.InsertarCliente(c);
        }
        
        public System.Threading.Tasks.Task InsertarClienteAsync(clienteServidor.ServiceReference1.Cliente c) {
            return base.Channel.InsertarClienteAsync(c);
        }
        
        public void ModificarCliente(clienteServidor.ServiceReference1.Cliente c) {
            base.Channel.ModificarCliente(c);
        }
        
        public System.Threading.Tasks.Task ModificarClienteAsync(clienteServidor.ServiceReference1.Cliente c) {
            return base.Channel.ModificarClienteAsync(c);
        }
        
        public void EliminarCliente(int id) {
            base.Channel.EliminarCliente(id);
        }
        
        public System.Threading.Tasks.Task EliminarClienteAsync(int id) {
            return base.Channel.EliminarClienteAsync(id);
        }
    }
}
