﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.addFileService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="addFileService.IFileService")]
    public interface IFileService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/AddFile", ReplyAction="http://tempuri.org/IFileService/AddFileResponse")]
        void AddFile(string fileName, string fileDesc, int projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileService/AddFile", ReplyAction="http://tempuri.org/IFileService/AddFileResponse")]
        System.Threading.Tasks.Task AddFileAsync(string fileName, string fileDesc, int projectId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileServiceChannel : ClientApp.addFileService.IFileService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileServiceClient : System.ServiceModel.ClientBase<ClientApp.addFileService.IFileService>, ClientApp.addFileService.IFileService {
        
        public FileServiceClient() {
        }
        
        public FileServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddFile(string fileName, string fileDesc, int projectId) {
            base.Channel.AddFile(fileName, fileDesc, projectId);
        }
        
        public System.Threading.Tasks.Task AddFileAsync(string fileName, string fileDesc, int projectId) {
            return base.Channel.AddFileAsync(fileName, fileDesc, projectId);
        }
    }
}
