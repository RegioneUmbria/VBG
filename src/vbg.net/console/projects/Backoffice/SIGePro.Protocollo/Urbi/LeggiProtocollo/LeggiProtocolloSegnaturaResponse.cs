﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 

namespace Init.SIGePro.Protocollo.Urbi.LeggiProtocollo
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("xapirest", Namespace = "", IsNullable = false)]
    public partial class xapirestTypeGetInterrogazioneProtocollo
    {

        private getInterrogazioneProtocollo_ResultType getInterrogazioneProtocollo_ResultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public getInterrogazioneProtocollo_ResultType getInterrogazioneProtocollo_Result
        {
            get
            {
                return this.getInterrogazioneProtocollo_ResultField;
            }
            set
            {
                this.getInterrogazioneProtocollo_ResultField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getInterrogazioneProtocollo_ResultType
    {

        private string rESULTField;

        private string numProtocolliField;

        private SEQ_ProtocolloType sEQ_ProtocolloField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RESULT
        {
            get
            {
                return this.rESULTField;
            }
            set
            {
                this.rESULTField = Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NumProtocolli
        {
            get
            {
                return this.numProtocolliField;
            }
            set
            {
                this.numProtocolliField = Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SEQ_ProtocolloType SEQ_Protocollo
        {
            get
            {
                return this.sEQ_ProtocolloField;
            }
            set
            {
                this.sEQ_ProtocolloField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SEQ_ProtocolloType
    {

        private ProtocolloType protocolloField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ProtocolloType Protocollo
        {
            get
            {
                return this.protocolloField;
            }
            set
            {
                this.protocolloField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ProtocolloType
    {

        private string annoField;

        private string numeroField;

        private string sezioneField;

        private string dataProtocolloField;

        private string oraProtocolloField;

        private string oggettoField;

        private string tipoDocField;

        private string utenteRegistratoreField;

        private string numUffici_DestinatariField;

        private string numUffici_MittentiField;

        private string numCorrispondentiField;

        private string listaCodSogCorrispondentiField;

        private string numDocumentiField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Anno
        {
            get
            {
                return this.annoField;
            }
            set
            {
                this.annoField = Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Sezione
        {
            get
            {
                return this.sezioneField;
            }
            set
            {
                this.sezioneField = Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DataProtocollo
        {
            get
            {
                return this.dataProtocolloField;
            }
            set
            {
                this.dataProtocolloField = Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OraProtocollo
        {
            get
            {
                return this.oraProtocolloField;
            }
            set
            {
                this.oraProtocolloField = Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Oggetto
        {
            get
            {
                return this.oggettoField;
            }
            set
            {
                this.oggettoField = Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TipoDoc
        {
            get
            {
                return this.tipoDocField;
            }
            set
            {
                this.tipoDocField = Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UtenteRegistratore
        {
            get
            {
                return this.utenteRegistratoreField;
            }
            set
            {
                this.utenteRegistratoreField = Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NumUffici_Destinatari
        {
            get
            {
                return this.numUffici_DestinatariField;
            }
            set
            {
                this.numUffici_DestinatariField = string.IsNullOrEmpty(value) ? "0" : Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NumUffici_Mittenti
        {
            get
            {
                return this.numUffici_MittentiField;
            }
            set
            {
                this.numUffici_MittentiField = string.IsNullOrEmpty(value) ? "0" : Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NumCorrispondenti
        {
            get
            {
                return this.numCorrispondentiField;
            }
            set
            {
                this.numCorrispondentiField = Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ListaCodSogCorrispondenti
        {
            get
            {
                return this.listaCodSogCorrispondentiField;
            }
            set
            {
                this.listaCodSogCorrispondentiField = Utility.FormattaValoriDaDeserializzare(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NumDocumenti
        {
            get
            {
                return this.numDocumentiField;
            }
            set
            {
                this.numDocumentiField = Utility.FormattaValoriDaDeserializzare(value);
            }
        }
    }
}