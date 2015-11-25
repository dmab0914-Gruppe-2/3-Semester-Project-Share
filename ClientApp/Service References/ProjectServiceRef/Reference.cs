﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.ProjectServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProjectServiceRef.IProjectService")]
    public interface IProjectService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectService/AddProject", ReplyAction="http://tempuri.org/IProjectService/AddProjectResponse")]
        Library.ProjectReturnType AddProject(string title, string description, string projectFolder, Library.User projectAdministratorUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectService/AddProject", ReplyAction="http://tempuri.org/IProjectService/AddProjectResponse")]
        System.Threading.Tasks.Task<Library.ProjectReturnType> AddProjectAsync(string title, string description, string projectFolder, Library.User projectAdministratorUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectService/GetAllProjects", ReplyAction="http://tempuri.org/IProjectService/GetAllProjectsResponse")]
        Library.Project[] GetAllProjects();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProjectService/GetAllProjects", ReplyAction="http://tempuri.org/IProjectService/GetAllProjectsResponse")]
        System.Threading.Tasks.Task<Library.Project[]> GetAllProjectsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProjectServiceChannel : ClientApp.ProjectServiceRef.IProjectService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProjectServiceClient : System.ServiceModel.ClientBase<ClientApp.ProjectServiceRef.IProjectService>, ClientApp.ProjectServiceRef.IProjectService {
        
        public ProjectServiceClient() {
        }
        
        public ProjectServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProjectServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProjectServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProjectServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Library.ProjectReturnType AddProject(string title, string description, string projectFolder, Library.User projectAdministratorUser) {
            return base.Channel.AddProject(title, description, projectFolder, projectAdministratorUser);
        }
        
        public System.Threading.Tasks.Task<Library.ProjectReturnType> AddProjectAsync(string title, string description, string projectFolder, Library.User projectAdministratorUser) {
            return base.Channel.AddProjectAsync(title, description, projectFolder, projectAdministratorUser);
        }
        
        public Library.Project[] GetAllProjects() {
            return base.Channel.GetAllProjects();
        }
        
        public System.Threading.Tasks.Task<Library.Project[]> GetAllProjectsAsync() {
            return base.Channel.GetAllProjectsAsync();
        }
    }
}
