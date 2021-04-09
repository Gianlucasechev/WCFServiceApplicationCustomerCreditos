﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pacagroup.Comercial.Creditos.ConsoleConsumer.ProxyCredito {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyCredito.ICreditoService")]
    public interface ICreditoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditoService/listarCreditos", ReplyAction="http://tempuri.org/ICreditoService/listarCreditosResponse")]
        Pacagroup.Comercial.Creditos.Dominio.Credito[] listarCreditos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditoService/listarCreditos", ReplyAction="http://tempuri.org/ICreditoService/listarCreditosResponse")]
        System.Threading.Tasks.Task<Pacagroup.Comercial.Creditos.Dominio.Credito[]> listarCreditosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditoService/registrarCredito", ReplyAction="http://tempuri.org/ICreditoService/registrarCreditoResponse")]
        Pacagroup.Comercial.Creditos.Dominio.Credito registrarCredito(Pacagroup.Comercial.Creditos.Dominio.Credito credito);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditoService/registrarCredito", ReplyAction="http://tempuri.org/ICreditoService/registrarCreditoResponse")]
        System.Threading.Tasks.Task<Pacagroup.Comercial.Creditos.Dominio.Credito> registrarCreditoAsync(Pacagroup.Comercial.Creditos.Dominio.Credito credito);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditoService/actualizarCredito", ReplyAction="http://tempuri.org/ICreditoService/actualizarCreditoResponse")]
        Pacagroup.Comercial.Creditos.Dominio.Credito actualizarCredito(Pacagroup.Comercial.Creditos.Dominio.Credito credito);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditoService/actualizarCredito", ReplyAction="http://tempuri.org/ICreditoService/actualizarCreditoResponse")]
        System.Threading.Tasks.Task<Pacagroup.Comercial.Creditos.Dominio.Credito> actualizarCreditoAsync(Pacagroup.Comercial.Creditos.Dominio.Credito credito);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditoService/EliminarCredito", ReplyAction="http://tempuri.org/ICreditoService/EliminarCreditoResponse")]
        bool EliminarCredito(string idCredito);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreditoService/EliminarCredito", ReplyAction="http://tempuri.org/ICreditoService/EliminarCreditoResponse")]
        System.Threading.Tasks.Task<bool> EliminarCreditoAsync(string idCredito);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICreditoServiceChannel : Pacagroup.Comercial.Creditos.ConsoleConsumer.ProxyCredito.ICreditoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreditoServiceClient : System.ServiceModel.ClientBase<Pacagroup.Comercial.Creditos.ConsoleConsumer.ProxyCredito.ICreditoService>, Pacagroup.Comercial.Creditos.ConsoleConsumer.ProxyCredito.ICreditoService {
        
        public CreditoServiceClient() {
        }
        
        public CreditoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CreditoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreditoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreditoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Pacagroup.Comercial.Creditos.Dominio.Credito[] listarCreditos() {
            return base.Channel.listarCreditos();
        }
        
        public System.Threading.Tasks.Task<Pacagroup.Comercial.Creditos.Dominio.Credito[]> listarCreditosAsync() {
            return base.Channel.listarCreditosAsync();
        }
        
        public Pacagroup.Comercial.Creditos.Dominio.Credito registrarCredito(Pacagroup.Comercial.Creditos.Dominio.Credito credito) {
            return base.Channel.registrarCredito(credito);
        }
        
        public System.Threading.Tasks.Task<Pacagroup.Comercial.Creditos.Dominio.Credito> registrarCreditoAsync(Pacagroup.Comercial.Creditos.Dominio.Credito credito) {
            return base.Channel.registrarCreditoAsync(credito);
        }
        
        public Pacagroup.Comercial.Creditos.Dominio.Credito actualizarCredito(Pacagroup.Comercial.Creditos.Dominio.Credito credito) {
            return base.Channel.actualizarCredito(credito);
        }
        
        public System.Threading.Tasks.Task<Pacagroup.Comercial.Creditos.Dominio.Credito> actualizarCreditoAsync(Pacagroup.Comercial.Creditos.Dominio.Credito credito) {
            return base.Channel.actualizarCreditoAsync(credito);
        }
        
        public bool EliminarCredito(string idCredito) {
            return base.Channel.EliminarCredito(idCredito);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarCreditoAsync(string idCredito) {
            return base.Channel.EliminarCreditoAsync(idCredito);
        }
    }
}