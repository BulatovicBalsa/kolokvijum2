﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sub.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LotteryNumbers", Namespace="http://schemas.datacontract.org/2004/07/PubSubApp")]
    [System.SerializableAttribute()]
    public partial class LotteryNumbers : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Number1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Number2Field;
        
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
        public int Number1 {
            get {
                return this.Number1Field;
            }
            set {
                if ((this.Number1Field.Equals(value) != true)) {
                    this.Number1Field = value;
                    this.RaisePropertyChanged("Number1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number2 {
            get {
                return this.Number2Field;
            }
            set {
                if ((this.Number2Field.Equals(value) != true)) {
                    this.Number2Field = value;
                    this.RaisePropertyChanged("Number2");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Ticket", Namespace="http://schemas.datacontract.org/2004/07/PubSubApp")]
    [System.SerializableAttribute()]
    public partial class Ticket : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Number1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Number2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlayerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double StakeField;
        
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
        public int Number1 {
            get {
                return this.Number1Field;
            }
            set {
                if ((this.Number1Field.Equals(value) != true)) {
                    this.Number1Field = value;
                    this.RaisePropertyChanged("Number1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number2 {
            get {
                return this.Number2Field;
            }
            set {
                if ((this.Number2Field.Equals(value) != true)) {
                    this.Number2Field = value;
                    this.RaisePropertyChanged("Number2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlayerName {
            get {
                return this.PlayerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayerNameField, value) != true)) {
                    this.PlayerNameField = value;
                    this.RaisePropertyChanged("PlayerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Stake {
            get {
                return this.StakeField;
            }
            set {
                if ((this.StakeField.Equals(value) != true)) {
                    this.StakeField = value;
                    this.RaisePropertyChanged("Stake");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Summary", Namespace="http://schemas.datacontract.org/2004/07/PubSubApp")]
    [System.SerializableAttribute()]
    public partial class Summary : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CurrentTurnEarningsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HitCountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Sub.ServiceReference1.Player PlayerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RankField;
        
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
        public double CurrentTurnEarnings {
            get {
                return this.CurrentTurnEarningsField;
            }
            set {
                if ((this.CurrentTurnEarningsField.Equals(value) != true)) {
                    this.CurrentTurnEarningsField = value;
                    this.RaisePropertyChanged("CurrentTurnEarnings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HitCount {
            get {
                return this.HitCountField;
            }
            set {
                if ((this.HitCountField.Equals(value) != true)) {
                    this.HitCountField = value;
                    this.RaisePropertyChanged("HitCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Sub.ServiceReference1.Player Player {
            get {
                return this.PlayerField;
            }
            set {
                if ((object.ReferenceEquals(this.PlayerField, value) != true)) {
                    this.PlayerField = value;
                    this.RaisePropertyChanged("Player");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Rank {
            get {
                return this.RankField;
            }
            set {
                if ((this.RankField.Equals(value) != true)) {
                    this.RankField = value;
                    this.RaisePropertyChanged("Rank");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Player", Namespace="http://schemas.datacontract.org/2004/07/PubSubApp")]
    [System.SerializableAttribute()]
    public partial class Player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double CumulativeStakeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double EarningsField;
        
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
        public double CumulativeStake {
            get {
                return this.CumulativeStakeField;
            }
            set {
                if ((this.CumulativeStakeField.Equals(value) != true)) {
                    this.CumulativeStakeField = value;
                    this.RaisePropertyChanged("CumulativeStake");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Earnings {
            get {
                return this.EarningsField;
            }
            set {
                if ((this.EarningsField.Equals(value) != true)) {
                    this.EarningsField = value;
                    this.RaisePropertyChanged("Earnings");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMachine")]
    public interface IMachine {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMachine/DrawLotteryNumbers")]
        void DrawLotteryNumbers(Sub.ServiceReference1.LotteryNumbers numbers);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMachine/DrawLotteryNumbers")]
        System.Threading.Tasks.Task DrawLotteryNumbersAsync(Sub.ServiceReference1.LotteryNumbers numbers);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMachineChannel : Sub.ServiceReference1.IMachine, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MachineClient : System.ServiceModel.ClientBase<Sub.ServiceReference1.IMachine>, Sub.ServiceReference1.IMachine {
        
        public MachineClient() {
        }
        
        public MachineClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MachineClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MachineClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MachineClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DrawLotteryNumbers(Sub.ServiceReference1.LotteryNumbers numbers) {
            base.Channel.DrawLotteryNumbers(numbers);
        }
        
        public System.Threading.Tasks.Task DrawLotteryNumbersAsync(Sub.ServiceReference1.LotteryNumbers numbers) {
            return base.Channel.DrawLotteryNumbersAsync(numbers);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IPlayer", CallbackContract=typeof(Sub.ServiceReference1.IPlayerCallback))]
    public interface IPlayer {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPlayer/InitPlayer")]
        void InitPlayer(string username);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPlayer/InitPlayer")]
        System.Threading.Tasks.Task InitPlayerAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayer/SubmitTicket", ReplyAction="http://tempuri.org/IPlayer/SubmitTicketResponse")]
        bool SubmitTicket(Sub.ServiceReference1.Ticket ticket);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlayer/SubmitTicket", ReplyAction="http://tempuri.org/IPlayer/SubmitTicketResponse")]
        System.Threading.Tasks.Task<bool> SubmitTicketAsync(Sub.ServiceReference1.Ticket ticket);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPlayerCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IPlayer/SummaryArrived")]
        void SummaryArrived(Sub.ServiceReference1.Summary message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPlayerChannel : Sub.ServiceReference1.IPlayer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PlayerClient : System.ServiceModel.DuplexClientBase<Sub.ServiceReference1.IPlayer>, Sub.ServiceReference1.IPlayer {
        
        public PlayerClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public PlayerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public PlayerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PlayerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public PlayerClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void InitPlayer(string username) {
            base.Channel.InitPlayer(username);
        }
        
        public System.Threading.Tasks.Task InitPlayerAsync(string username) {
            return base.Channel.InitPlayerAsync(username);
        }
        
        public bool SubmitTicket(Sub.ServiceReference1.Ticket ticket) {
            return base.Channel.SubmitTicket(ticket);
        }
        
        public System.Threading.Tasks.Task<bool> SubmitTicketAsync(Sub.ServiceReference1.Ticket ticket) {
            return base.Channel.SubmitTicketAsync(ticket);
        }
    }
}
