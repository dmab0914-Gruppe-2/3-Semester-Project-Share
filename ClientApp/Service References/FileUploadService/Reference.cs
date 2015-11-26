﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.FileUploadService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileMetaData", Namespace="http://schemas.datacontract.org/2004/07/WebService.Models")]
    [System.SerializableAttribute()]
    public partial class FileMetaData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private ClientApp.FileUploadService.DefinedFileTypes FileTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullLocalPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public ClientApp.FileUploadService.DefinedFileTypes FileType {
            get {
                return this.FileTypeField;
            }
            set {
                if ((this.FileTypeField.Equals(value) != true)) {
                    this.FileTypeField = value;
                    this.RaisePropertyChanged("FileType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullLocalPath {
            get {
                return this.FullLocalPathField;
            }
            set {
                if ((object.ReferenceEquals(this.FullLocalPathField, value) != true)) {
                    this.FullLocalPathField = value;
                    this.RaisePropertyChanged("FullLocalPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string FileName {
            get {
                return this.FileNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FileNameField, value) != true)) {
                    this.FileNameField = value;
                    this.RaisePropertyChanged("FileName");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DefinedFileTypes", Namespace="http://schemas.datacontract.org/2004/07/WebService.Models")]
    public enum DefinedFileTypes : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DOC = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DOCX = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PDF = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RTF = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        jpg = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        png = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GENERIC = 6,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FileUploadService.IFileUpLoadService")]
    public interface IFileUpLoadService {
        
        // CODEGEN: Generating message contract since the operation UploadFile is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpLoadService/UploadFile", ReplyAction="http://tempuri.org/IFileUpLoadService/UploadFileResponse")]
        ClientApp.FileUploadService.UploadFileResponse UploadFile(ClientApp.FileUploadService.FileUploadMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpLoadService/UploadFile", ReplyAction="http://tempuri.org/IFileUpLoadService/UploadFileResponse")]
        System.Threading.Tasks.Task<ClientApp.FileUploadService.UploadFileResponse> UploadFileAsync(ClientApp.FileUploadService.FileUploadMessage request);
        
        // CODEGEN: Generating message contract since the wrapper name (FileDownloadMessage) of message FileDownloadMessage does not match the default value (DownloadFile)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpLoadService/DownloadFile", ReplyAction="http://tempuri.org/IFileUpLoadService/DownloadFileResponse")]
        ClientApp.FileUploadService.FileDownloadReturnMessage DownloadFile(ClientApp.FileUploadService.FileDownloadMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpLoadService/DownloadFile", ReplyAction="http://tempuri.org/IFileUpLoadService/DownloadFileResponse")]
        System.Threading.Tasks.Task<ClientApp.FileUploadService.FileDownloadReturnMessage> DownloadFileAsync(ClientApp.FileUploadService.FileDownloadMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpLoadService/GetAllFilesForProject", ReplyAction="http://tempuri.org/IFileUpLoadService/GetAllFilesForProjectResponse")]
        Library.File[] GetAllFilesForProject(int projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpLoadService/GetAllFilesForProject", ReplyAction="http://tempuri.org/IFileUpLoadService/GetAllFilesForProjectResponse")]
        System.Threading.Tasks.Task<Library.File[]> GetAllFilesForProjectAsync(int projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpLoadService/AddFile", ReplyAction="http://tempuri.org/IFileUpLoadService/AddFileResponse")]
        void AddFile(string fileName, string fileDesc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFileUpLoadService/AddFile", ReplyAction="http://tempuri.org/IFileUpLoadService/AddFileResponse")]
        System.Threading.Tasks.Task AddFileAsync(string fileName, string fileDesc);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FileUploadMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FileUploadMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public ClientApp.FileUploadService.FileMetaData Metadata;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream FileByteStream;
        
        public FileUploadMessage() {
        }
        
        public FileUploadMessage(ClientApp.FileUploadService.FileMetaData Metadata, System.IO.Stream FileByteStream) {
            this.Metadata = Metadata;
            this.FileByteStream = FileByteStream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadFileResponse {
        
        public UploadFileResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FileDownloadMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FileDownloadMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public ClientApp.FileUploadService.FileMetaData FileMetaData;
        
        public FileDownloadMessage() {
        }
        
        public FileDownloadMessage(ClientApp.FileUploadService.FileMetaData FileMetaData) {
            this.FileMetaData = FileMetaData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FileDownloadReturnMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class FileDownloadReturnMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public ClientApp.FileUploadService.FileMetaData DownloadedFileMetadata;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream FileByteStream;
        
        public FileDownloadReturnMessage() {
        }
        
        public FileDownloadReturnMessage(ClientApp.FileUploadService.FileMetaData DownloadedFileMetadata, System.IO.Stream FileByteStream) {
            this.DownloadedFileMetadata = DownloadedFileMetadata;
            this.FileByteStream = FileByteStream;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFileUpLoadServiceChannel : ClientApp.FileUploadService.IFileUpLoadService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileUpLoadServiceClient : System.ServiceModel.ClientBase<ClientApp.FileUploadService.IFileUpLoadService>, ClientApp.FileUploadService.IFileUpLoadService {
        
        public FileUpLoadServiceClient() {
        }
        
        public FileUpLoadServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileUpLoadServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileUpLoadServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileUpLoadServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientApp.FileUploadService.UploadFileResponse ClientApp.FileUploadService.IFileUpLoadService.UploadFile(ClientApp.FileUploadService.FileUploadMessage request) {
            return base.Channel.UploadFile(request);
        }
        
        public void UploadFile(ClientApp.FileUploadService.FileMetaData Metadata, System.IO.Stream FileByteStream) {
            ClientApp.FileUploadService.FileUploadMessage inValue = new ClientApp.FileUploadService.FileUploadMessage();
            inValue.Metadata = Metadata;
            inValue.FileByteStream = FileByteStream;
            ClientApp.FileUploadService.UploadFileResponse retVal = ((ClientApp.FileUploadService.IFileUpLoadService)(this)).UploadFile(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientApp.FileUploadService.UploadFileResponse> ClientApp.FileUploadService.IFileUpLoadService.UploadFileAsync(ClientApp.FileUploadService.FileUploadMessage request) {
            return base.Channel.UploadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientApp.FileUploadService.UploadFileResponse> UploadFileAsync(ClientApp.FileUploadService.FileMetaData Metadata, System.IO.Stream FileByteStream) {
            ClientApp.FileUploadService.FileUploadMessage inValue = new ClientApp.FileUploadService.FileUploadMessage();
            inValue.Metadata = Metadata;
            inValue.FileByteStream = FileByteStream;
            return ((ClientApp.FileUploadService.IFileUpLoadService)(this)).UploadFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientApp.FileUploadService.FileDownloadReturnMessage ClientApp.FileUploadService.IFileUpLoadService.DownloadFile(ClientApp.FileUploadService.FileDownloadMessage request) {
            return base.Channel.DownloadFile(request);
        }
        
        public ClientApp.FileUploadService.FileMetaData DownloadFile(ClientApp.FileUploadService.FileMetaData FileMetaData, out System.IO.Stream FileByteStream) {
            ClientApp.FileUploadService.FileDownloadMessage inValue = new ClientApp.FileUploadService.FileDownloadMessage();
            inValue.FileMetaData = FileMetaData;
            ClientApp.FileUploadService.FileDownloadReturnMessage retVal = ((ClientApp.FileUploadService.IFileUpLoadService)(this)).DownloadFile(inValue);
            FileByteStream = retVal.FileByteStream;
            return retVal.DownloadedFileMetadata;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientApp.FileUploadService.FileDownloadReturnMessage> ClientApp.FileUploadService.IFileUpLoadService.DownloadFileAsync(ClientApp.FileUploadService.FileDownloadMessage request) {
            return base.Channel.DownloadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientApp.FileUploadService.FileDownloadReturnMessage> DownloadFileAsync(ClientApp.FileUploadService.FileMetaData FileMetaData) {
            ClientApp.FileUploadService.FileDownloadMessage inValue = new ClientApp.FileUploadService.FileDownloadMessage();
            inValue.FileMetaData = FileMetaData;
            return ((ClientApp.FileUploadService.IFileUpLoadService)(this)).DownloadFileAsync(inValue);
        }
        
        public Library.File[] GetAllFilesForProject(int projectId) {
            return base.Channel.GetAllFilesForProject(projectId);
        }
        
        public System.Threading.Tasks.Task<Library.File[]> GetAllFilesForProjectAsync(int projectId) {
            return base.Channel.GetAllFilesForProjectAsync(projectId);
        }
        
        public void AddFile(string fileName, string fileDesc) {
            base.Channel.AddFile(fileName, fileDesc);
        }
        
        public System.Threading.Tasks.Task AddFileAsync(string fileName, string fileDesc) {
            return base.Channel.AddFileAsync(fileName, fileDesc);
        }
    }
}