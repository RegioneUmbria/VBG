﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Init.SIGePro.Manager.RegoleService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://gruppoinit.it/sigepro/definitions/regole", ConfigurationName="RegoleService.Regole")]
    public interface Regole {
        
        // CODEGEN: Generating message contract since the operation GetRegola is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="GetRegola", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EsitoOperazioneType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AllegatoBaseType))]
        Init.SIGePro.Manager.RegoleService.GetRegolaResponse GetRegola(Init.SIGePro.Manager.RegoleService.GetRegolaRequest request);
        
        // CODEGEN: Generating message contract since the operation GetParametroRegola is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="GetParametroRegola", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EsitoOperazioneType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AllegatoBaseType))]
        Init.SIGePro.Manager.RegoleService.GetParametroRegolaResponse GetParametroRegola(Init.SIGePro.Manager.RegoleService.GetParametroRegolaRequest request);
        
        // CODEGEN: Generating message contract since the operation GetComuniESoftwarePerRegola is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="GetComuniESoftwarePerRegola", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EsitoOperazioneType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AllegatoBaseType))]
        Init.SIGePro.Manager.RegoleService.GetComuniESoftwarePerRegolaResponse GetComuniESoftwarePerRegola(Init.SIGePro.Manager.RegoleService.GetComuniESoftwarePerRegolaRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://gruppoinit.it/sigepro/schemas/messages/regole")]
    public partial class RegolaRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string tokenField;
        
        private string softwareField;
        
        private string nomeRegolaField;
        
        private bool recuperaParametriField;
        
        private bool recuperaParametriFieldSpecified;
        
        private string codiceComuneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
                this.RaisePropertyChanged("token");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string software {
            get {
                return this.softwareField;
            }
            set {
                this.softwareField = value;
                this.RaisePropertyChanged("software");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string nomeRegola {
            get {
                return this.nomeRegolaField;
            }
            set {
                this.nomeRegolaField = value;
                this.RaisePropertyChanged("nomeRegola");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool recuperaParametri {
            get {
                return this.recuperaParametriField;
            }
            set {
                this.recuperaParametriField = value;
                this.RaisePropertyChanged("recuperaParametri");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool recuperaParametriSpecified {
            get {
                return this.recuperaParametriFieldSpecified;
            }
            set {
                this.recuperaParametriFieldSpecified = value;
                this.RaisePropertyChanged("recuperaParametriSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string codiceComune {
            get {
                return this.codiceComuneField;
            }
            set {
                this.codiceComuneField = value;
                this.RaisePropertyChanged("codiceComune");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://gruppoinit.it/sigepro/schemas/messages/base")]
    public partial class EsitoOperazioneType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int esitoField;
        
        private ErroreBackofficeType[] listaErroriField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int esito {
            get {
                return this.esitoField;
            }
            set {
                this.esitoField = value;
                this.RaisePropertyChanged("esito");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("listaErrori", Order=1)]
        public ErroreBackofficeType[] listaErrori {
            get {
                return this.listaErroriField;
            }
            set {
                this.listaErroriField = value;
                this.RaisePropertyChanged("listaErrori");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://gruppoinit.it/sigepro/schemas/messages/base")]
    public partial class ErroreBackofficeType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codiceField;
        
        private string descrizioneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string codice {
            get {
                return this.codiceField;
            }
            set {
                this.codiceField = value;
                this.RaisePropertyChanged("codice");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string descrizione {
            get {
                return this.descrizioneField;
            }
            set {
                this.descrizioneField = value;
                this.RaisePropertyChanged("descrizione");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://gruppoinit.it/sigepro/schemas/messages/base")]
    public partial class AllegatoBaseType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string idField;
        
        private string descrizioneField;
        
        private string fileNameField;
        
        private string mimeTypeField;
        
        private byte[] binaryDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=0)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string descrizione {
            get {
                return this.descrizioneField;
            }
            set {
                this.descrizioneField = value;
                this.RaisePropertyChanged("descrizione");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string fileName {
            get {
                return this.fileNameField;
            }
            set {
                this.fileNameField = value;
                this.RaisePropertyChanged("fileName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string mimeType {
            get {
                return this.mimeTypeField;
            }
            set {
                this.mimeTypeField = value;
                this.RaisePropertyChanged("mimeType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=4)]
        public byte[] binaryData {
            get {
                return this.binaryDataField;
            }
            set {
                this.binaryDataField = value;
                this.RaisePropertyChanged("binaryData");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://gruppoinit.it/sigepro/schemas/messages/regole")]
    public partial class ParametroRegolaRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string tokenField;
        
        private string softwareField;
        
        private string nomeRegolaField;
        
        private string nomeParametroField;
        
        private string codiceComuneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
                this.RaisePropertyChanged("token");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string software {
            get {
                return this.softwareField;
            }
            set {
                this.softwareField = value;
                this.RaisePropertyChanged("software");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string nomeRegola {
            get {
                return this.nomeRegolaField;
            }
            set {
                this.nomeRegolaField = value;
                this.RaisePropertyChanged("nomeRegola");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string nomeParametro {
            get {
                return this.nomeParametroField;
            }
            set {
                this.nomeParametroField = value;
                this.RaisePropertyChanged("nomeParametro");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string codiceComune {
            get {
                return this.codiceComuneField;
            }
            set {
                this.codiceComuneField = value;
                this.RaisePropertyChanged("codiceComune");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://gruppoinit.it/sigepro/schemas/messages/regole")]
    public partial class ParametroRegolaResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("errore", typeof(ErroreBackofficeType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("parametro", typeof(ParametroType), Order=0)]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://gruppoinit.it/sigepro/schemas/messages/regole")]
    public partial class ParametroType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private object descrizioneField;
        
        private string valoreField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public object descrizione {
            get {
                return this.descrizioneField;
            }
            set {
                this.descrizioneField = value;
                this.RaisePropertyChanged("descrizione");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string valore {
            get {
                return this.valoreField;
            }
            set {
                this.valoreField = value;
                this.RaisePropertyChanged("valore");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://gruppoinit.it/sigepro/schemas/messages/regole")]
    public partial class ComuniESoftwareType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codiceComuneField;
        
        private string softwareField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string codiceComune {
            get {
                return this.codiceComuneField;
            }
            set {
                this.codiceComuneField = value;
                this.RaisePropertyChanged("codiceComune");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string software {
            get {
                return this.softwareField;
            }
            set {
                this.softwareField = value;
                this.RaisePropertyChanged("software");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://gruppoinit.it/sigepro/schemas/messages/regole")]
    public partial class ComuniESoftwarePerRegolaRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string tokenField;
        
        private string nomeRegolaField;
        
        private string nomeParametroField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
                this.RaisePropertyChanged("token");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string nomeRegola {
            get {
                return this.nomeRegolaField;
            }
            set {
                this.nomeRegolaField = value;
                this.RaisePropertyChanged("nomeRegola");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string nomeParametro {
            get {
                return this.nomeParametroField;
            }
            set {
                this.nomeParametroField = value;
                this.RaisePropertyChanged("nomeParametro");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://gruppoinit.it/sigepro/schemas/messages/regole")]
    public partial class RegolaResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool attivaField;
        
        private ParametroType[] listaParametriField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool attiva {
            get {
                return this.attivaField;
            }
            set {
                this.attivaField = value;
                this.RaisePropertyChanged("attiva");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("listaParametri", Order=1)]
        public ParametroType[] listaParametri {
            get {
                return this.listaParametriField;
            }
            set {
                this.listaParametriField = value;
                this.RaisePropertyChanged("listaParametri");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRegolaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRegolaRequest", Namespace="http://gruppoinit.it/sigepro/schemas/messages/regole", Order=0)]
        public Init.SIGePro.Manager.RegoleService.RegolaRequest GetRegolaRequest1;
        
        public GetRegolaRequest() {
        }
        
        public GetRegolaRequest(Init.SIGePro.Manager.RegoleService.RegolaRequest GetRegolaRequest1) {
            this.GetRegolaRequest1 = GetRegolaRequest1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRegolaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRegolaResponse", Namespace="http://gruppoinit.it/sigepro/schemas/messages/regole", Order=0)]
        public Init.SIGePro.Manager.RegoleService.RegolaResponse GetRegolaResponse1;
        
        public GetRegolaResponse() {
        }
        
        public GetRegolaResponse(Init.SIGePro.Manager.RegoleService.RegolaResponse GetRegolaResponse1) {
            this.GetRegolaResponse1 = GetRegolaResponse1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetParametroRegolaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetParametroRegolaRequest", Namespace="http://gruppoinit.it/sigepro/schemas/messages/regole", Order=0)]
        public Init.SIGePro.Manager.RegoleService.ParametroRegolaRequest GetParametroRegolaRequest1;
        
        public GetParametroRegolaRequest() {
        }
        
        public GetParametroRegolaRequest(Init.SIGePro.Manager.RegoleService.ParametroRegolaRequest GetParametroRegolaRequest1) {
            this.GetParametroRegolaRequest1 = GetParametroRegolaRequest1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetParametroRegolaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetParametroRegolaResponse", Namespace="http://gruppoinit.it/sigepro/schemas/messages/regole", Order=0)]
        public Init.SIGePro.Manager.RegoleService.ParametroRegolaResponse GetParametroRegolaResponse1;
        
        public GetParametroRegolaResponse() {
        }
        
        public GetParametroRegolaResponse(Init.SIGePro.Manager.RegoleService.ParametroRegolaResponse GetParametroRegolaResponse1) {
            this.GetParametroRegolaResponse1 = GetParametroRegolaResponse1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetComuniESoftwarePerRegolaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetComuniESoftwarePerRegolaRequest", Namespace="http://gruppoinit.it/sigepro/schemas/messages/regole", Order=0)]
        public Init.SIGePro.Manager.RegoleService.ComuniESoftwarePerRegolaRequest GetComuniESoftwarePerRegolaRequest1;
        
        public GetComuniESoftwarePerRegolaRequest() {
        }
        
        public GetComuniESoftwarePerRegolaRequest(Init.SIGePro.Manager.RegoleService.ComuniESoftwarePerRegolaRequest GetComuniESoftwarePerRegolaRequest1) {
            this.GetComuniESoftwarePerRegolaRequest1 = GetComuniESoftwarePerRegolaRequest1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetComuniESoftwarePerRegolaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetComuniESoftwarePerRegolaResponse", Namespace="http://gruppoinit.it/sigepro/schemas/messages/regole", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("configurazioni", IsNullable=false)]
        public Init.SIGePro.Manager.RegoleService.ComuniESoftwareType[] GetComuniESoftwarePerRegolaResponse1;
        
        public GetComuniESoftwarePerRegolaResponse() {
        }
        
        public GetComuniESoftwarePerRegolaResponse(Init.SIGePro.Manager.RegoleService.ComuniESoftwareType[] GetComuniESoftwarePerRegolaResponse1) {
            this.GetComuniESoftwarePerRegolaResponse1 = GetComuniESoftwarePerRegolaResponse1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RegoleChannel : Init.SIGePro.Manager.RegoleService.Regole, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RegoleClient : System.ServiceModel.ClientBase<Init.SIGePro.Manager.RegoleService.Regole>, Init.SIGePro.Manager.RegoleService.Regole {
        
        public RegoleClient() {
        }
        
        public RegoleClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RegoleClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegoleClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegoleClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Init.SIGePro.Manager.RegoleService.GetRegolaResponse Init.SIGePro.Manager.RegoleService.Regole.GetRegola(Init.SIGePro.Manager.RegoleService.GetRegolaRequest request) {
            return base.Channel.GetRegola(request);
        }
        
        public Init.SIGePro.Manager.RegoleService.RegolaResponse GetRegola(Init.SIGePro.Manager.RegoleService.RegolaRequest GetRegolaRequest1) {
            Init.SIGePro.Manager.RegoleService.GetRegolaRequest inValue = new Init.SIGePro.Manager.RegoleService.GetRegolaRequest();
            inValue.GetRegolaRequest1 = GetRegolaRequest1;
            Init.SIGePro.Manager.RegoleService.GetRegolaResponse retVal = ((Init.SIGePro.Manager.RegoleService.Regole)(this)).GetRegola(inValue);
            return retVal.GetRegolaResponse1;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Init.SIGePro.Manager.RegoleService.GetParametroRegolaResponse Init.SIGePro.Manager.RegoleService.Regole.GetParametroRegola(Init.SIGePro.Manager.RegoleService.GetParametroRegolaRequest request) {
            return base.Channel.GetParametroRegola(request);
        }
        
        public Init.SIGePro.Manager.RegoleService.ParametroRegolaResponse GetParametroRegola(Init.SIGePro.Manager.RegoleService.ParametroRegolaRequest GetParametroRegolaRequest1) {
            Init.SIGePro.Manager.RegoleService.GetParametroRegolaRequest inValue = new Init.SIGePro.Manager.RegoleService.GetParametroRegolaRequest();
            inValue.GetParametroRegolaRequest1 = GetParametroRegolaRequest1;
            Init.SIGePro.Manager.RegoleService.GetParametroRegolaResponse retVal = ((Init.SIGePro.Manager.RegoleService.Regole)(this)).GetParametroRegola(inValue);
            return retVal.GetParametroRegolaResponse1;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Init.SIGePro.Manager.RegoleService.GetComuniESoftwarePerRegolaResponse Init.SIGePro.Manager.RegoleService.Regole.GetComuniESoftwarePerRegola(Init.SIGePro.Manager.RegoleService.GetComuniESoftwarePerRegolaRequest request) {
            return base.Channel.GetComuniESoftwarePerRegola(request);
        }
        
        public Init.SIGePro.Manager.RegoleService.ComuniESoftwareType[] GetComuniESoftwarePerRegola(Init.SIGePro.Manager.RegoleService.ComuniESoftwarePerRegolaRequest GetComuniESoftwarePerRegolaRequest1) {
            Init.SIGePro.Manager.RegoleService.GetComuniESoftwarePerRegolaRequest inValue = new Init.SIGePro.Manager.RegoleService.GetComuniESoftwarePerRegolaRequest();
            inValue.GetComuniESoftwarePerRegolaRequest1 = GetComuniESoftwarePerRegolaRequest1;
            Init.SIGePro.Manager.RegoleService.GetComuniESoftwarePerRegolaResponse retVal = ((Init.SIGePro.Manager.RegoleService.Regole)(this)).GetComuniESoftwarePerRegola(inValue);
            return retVal.GetComuniESoftwarePerRegolaResponse1;
        }
    }
}
