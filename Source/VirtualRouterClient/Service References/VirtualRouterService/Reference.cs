﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualRouterClient.VirtualRouterService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SharableConnection", Namespace="http://schemas.datacontract.org/2004/07/VirtualRouterHost")]
    [System.SerializableAttribute()]
    public partial class SharableConnection : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeviceNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid GuidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string DeviceName {
            get {
                return this.DeviceNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DeviceNameField, value) != true)) {
                    this.DeviceNameField = value;
                    this.RaisePropertyChanged("DeviceName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Guid {
            get {
                return this.GuidField;
            }
            set {
                if ((this.GuidField.Equals(value) != true)) {
                    this.GuidField = value;
                    this.RaisePropertyChanged("Guid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConnectionSettings", Namespace="http://schemas.datacontract.org/2004/07/VirtualRouterHost")]
    [System.SerializableAttribute()]
    public partial class ConnectionSettings : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxPeerCountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SSIDField;
        
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
        public int MaxPeerCount {
            get {
                return this.MaxPeerCountField;
            }
            set {
                if ((this.MaxPeerCountField.Equals(value) != true)) {
                    this.MaxPeerCountField = value;
                    this.RaisePropertyChanged("MaxPeerCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SSID {
            get {
                return this.SSIDField;
            }
            set {
                if ((object.ReferenceEquals(this.SSIDField, value) != true)) {
                    this.SSIDField = value;
                    this.RaisePropertyChanged("SSID");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConnectedPeer", Namespace="http://schemas.datacontract.org/2004/07/VirtualRouterHost")]
    [System.SerializableAttribute()]
    public partial class ConnectedPeer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MacAddressField;
        
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
        public string MacAddress {
            get {
                return this.MacAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.MacAddressField, value) != true)) {
                    this.MacAddressField = value;
                    this.RaisePropertyChanged("MacAddress");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://VirtualRouter", ConfigurationName="VirtualRouterService.IVirtualRouterHost")]
    public interface IVirtualRouterHost {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://VirtualRouter/IVirtualRouterHost/Start", ReplyAction="http://VirtualRouter/IVirtualRouterHost/StartResponse")]
        bool Start(VirtualRouterClient.VirtualRouterService.SharableConnection sharedConnection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://VirtualRouter/IVirtualRouterHost/Stop", ReplyAction="http://VirtualRouter/IVirtualRouterHost/StopResponse")]
        bool Stop();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://VirtualRouter/IVirtualRouterHost/SetConnectionSettings", ReplyAction="http://VirtualRouter/IVirtualRouterHost/SetConnectionSettingsResponse")]
        bool SetConnectionSettings(string ssid, int maxPeerCount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://VirtualRouter/IVirtualRouterHost/GetConnectionSettings", ReplyAction="http://VirtualRouter/IVirtualRouterHost/GetConnectionSettingsResponse")]
        VirtualRouterClient.VirtualRouterService.ConnectionSettings GetConnectionSettings();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://VirtualRouter/IVirtualRouterHost/GetSharableConnections", ReplyAction="http://VirtualRouter/IVirtualRouterHost/GetSharableConnectionsResponse")]
        VirtualRouterClient.VirtualRouterService.SharableConnection[] GetSharableConnections();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://VirtualRouter/IVirtualRouterHost/SetPassword", ReplyAction="http://VirtualRouter/IVirtualRouterHost/SetPasswordResponse")]
        bool SetPassword(string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://VirtualRouter/IVirtualRouterHost/GetPassword", ReplyAction="http://VirtualRouter/IVirtualRouterHost/GetPasswordResponse")]
        string GetPassword();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://VirtualRouter/IVirtualRouterHost/IsStarted", ReplyAction="http://VirtualRouter/IVirtualRouterHost/IsStartedResponse")]
        bool IsStarted();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://VirtualRouter/IVirtualRouterHost/GetConnectedPeers", ReplyAction="http://VirtualRouter/IVirtualRouterHost/GetConnectedPeersResponse")]
        VirtualRouterClient.VirtualRouterService.ConnectedPeer[] GetConnectedPeers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://VirtualRouter/IVirtualRouterHost/GetSharedConnection", ReplyAction="http://VirtualRouter/IVirtualRouterHost/GetSharedConnectionResponse")]
        VirtualRouterClient.VirtualRouterService.SharableConnection GetSharedConnection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://VirtualRouter/IVirtualRouterHost/GetLastError", ReplyAction="http://VirtualRouter/IVirtualRouterHost/GetLastErrorResponse")]
        string GetLastError();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVirtualRouterHostChannel : VirtualRouterClient.VirtualRouterService.IVirtualRouterHost, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VirtualRouterHostClient : System.ServiceModel.ClientBase<VirtualRouterClient.VirtualRouterService.IVirtualRouterHost>, VirtualRouterClient.VirtualRouterService.IVirtualRouterHost {
        
        public VirtualRouterHostClient() {
        }
        
        public VirtualRouterHostClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VirtualRouterHostClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VirtualRouterHostClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VirtualRouterHostClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Start(VirtualRouterClient.VirtualRouterService.SharableConnection sharedConnection) {
            return base.Channel.Start(sharedConnection);
        }
        
        public bool Stop() {
            return base.Channel.Stop();
        }
        
        public bool SetConnectionSettings(string ssid, int maxPeerCount) {
            return base.Channel.SetConnectionSettings(ssid, maxPeerCount);
        }
        
        public VirtualRouterClient.VirtualRouterService.ConnectionSettings GetConnectionSettings() {
            return base.Channel.GetConnectionSettings();
        }
        
        public VirtualRouterClient.VirtualRouterService.SharableConnection[] GetSharableConnections() {
            return base.Channel.GetSharableConnections();
        }
        
        public bool SetPassword(string password) {
            return base.Channel.SetPassword(password);
        }
        
        public string GetPassword() {
            return base.Channel.GetPassword();
        }
        
        public bool IsStarted() {
            return base.Channel.IsStarted();
        }
        
        public VirtualRouterClient.VirtualRouterService.ConnectedPeer[] GetConnectedPeers() {
            return base.Channel.GetConnectedPeers();
        }
        
        public VirtualRouterClient.VirtualRouterService.SharableConnection GetSharedConnection() {
            return base.Channel.GetSharedConnection();
        }
        
        public string GetLastError() {
            return base.Channel.GetLastError();
        }
    }
}
