﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project5GroupSln.XMLServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="XMLServiceRef.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateMember", ReplyAction="http://tempuri.org/IService/CreateMemberResponse")]
        string CreateMember(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateMember", ReplyAction="http://tempuri.org/IService/CreateMemberResponse")]
        System.Threading.Tasks.Task<string> CreateMemberAsync(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateStaff", ReplyAction="http://tempuri.org/IService/CreateStaffResponse")]
        string CreateStaff(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateStaff", ReplyAction="http://tempuri.org/IService/CreateStaffResponse")]
        System.Threading.Tasks.Task<string> CreateStaffAsync(string name, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Project5GroupSln.XMLServiceRef.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Project5GroupSln.XMLServiceRef.IService>, Project5GroupSln.XMLServiceRef.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string CreateMember(string name, string password) {
            return base.Channel.CreateMember(name, password);
        }
        
        public System.Threading.Tasks.Task<string> CreateMemberAsync(string name, string password) {
            return base.Channel.CreateMemberAsync(name, password);
        }
        
        public string CreateStaff(string name, string password) {
            return base.Channel.CreateStaff(name, password);
        }
        
        public System.Threading.Tasks.Task<string> CreateStaffAsync(string name, string password) {
            return base.Channel.CreateStaffAsync(name, password);
        }
    }
}
