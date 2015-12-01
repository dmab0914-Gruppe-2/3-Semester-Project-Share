﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.UserService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserService.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindUserById", ReplyAction="http://tempuri.org/IUserService/FindUserByIdResponse")]
        Library.User FindUserById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindUserById", ReplyAction="http://tempuri.org/IUserService/FindUserByIdResponse")]
        System.Threading.Tasks.Task<Library.User> FindUserByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindUserByEmail", ReplyAction="http://tempuri.org/IUserService/FindUserByEmailResponse")]
        Library.User[] FindUserByEmail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindUserByEmail", ReplyAction="http://tempuri.org/IUserService/FindUserByEmailResponse")]
        System.Threading.Tasks.Task<Library.User[]> FindUserByEmailAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindUserByUsername", ReplyAction="http://tempuri.org/IUserService/FindUserByUsernameResponse")]
        Library.User[] FindUserByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindUserByUsername", ReplyAction="http://tempuri.org/IUserService/FindUserByUsernameResponse")]
        System.Threading.Tasks.Task<Library.User[]> FindUserByUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindAllUsers", ReplyAction="http://tempuri.org/IUserService/FindAllUsersResponse")]
        Library.User[] FindAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindAllUsers", ReplyAction="http://tempuri.org/IUserService/FindAllUsersResponse")]
        System.Threading.Tasks.Task<Library.User[]> FindAllUsersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : ClientApp.UserService.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<ClientApp.UserService.IUserService>, ClientApp.UserService.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Library.User FindUserById(int id) {
            return base.Channel.FindUserById(id);
        }
        
        public System.Threading.Tasks.Task<Library.User> FindUserByIdAsync(int id) {
            return base.Channel.FindUserByIdAsync(id);
        }
        
        public Library.User[] FindUserByEmail(string email) {
            return base.Channel.FindUserByEmail(email);
        }
        
        public System.Threading.Tasks.Task<Library.User[]> FindUserByEmailAsync(string email) {
            return base.Channel.FindUserByEmailAsync(email);
        }
        
        public Library.User[] FindUserByUsername(string username) {
            return base.Channel.FindUserByUsername(username);
        }
        
        public System.Threading.Tasks.Task<Library.User[]> FindUserByUsernameAsync(string username) {
            return base.Channel.FindUserByUsernameAsync(username);
        }
        
        public Library.User[] FindAllUsers() {
            return base.Channel.FindAllUsers();
        }
        
        public System.Threading.Tasks.Task<Library.User[]> FindAllUsersAsync() {
            return base.Channel.FindAllUsersAsync();
        }
    }
}
