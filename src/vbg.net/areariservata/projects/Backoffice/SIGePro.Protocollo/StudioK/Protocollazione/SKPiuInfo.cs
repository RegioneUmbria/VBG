﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Init.SIGePro.Protocollo.StudioK.Protocollazione
{
    using System.Xml.Serialization;

    // 
    // This source code was auto-generated by xsd, Version=4.0.30319.33440.
    // 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class CustomMetadata
    {

        private CustomMetadataIntestazione intestazioneField;

        private string versioneField;

        /// <remarks/>
        public CustomMetadataIntestazione Intestazione
        {
            get
            {
                return this.intestazioneField;
            }
            set
            {
                this.intestazioneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versione
        {
            get
            {
                return this.versioneField;
            }
            set
            {
                this.versioneField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class CustomMetadataIntestazione
    {

        private CustomMetadataIntestazioneFlusso flussoField;

        private bool flussoFieldSpecified;

        private CustomMetadataIntestazioneEMail eMailField;

        private bool eMailFieldSpecified;

        private CustomMetadataIntestazioneAccompagnatoria accompagnatoriaField;

        private bool accompagnatoriaFieldSpecified;

        private CustomMetadataIntestazioneClassificazione[] classificazioneField;

        private CustomMetadataIntestazioneAssegnazione[] assegnazioneField;

        /// <remarks/>
        public CustomMetadataIntestazioneFlusso Flusso
        {
            get
            {
                return this.flussoField;
            }
            set
            {
                this.flussoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlussoSpecified
        {
            get
            {
                return this.flussoFieldSpecified;
            }
            set
            {
                this.flussoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CustomMetadataIntestazioneEMail eMail
        {
            get
            {
                return this.eMailField;
            }
            set
            {
                this.eMailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eMailSpecified
        {
            get
            {
                return this.eMailFieldSpecified;
            }
            set
            {
                this.eMailFieldSpecified = value;
            }
        }

        /// <remarks/>
        public CustomMetadataIntestazioneAccompagnatoria Accompagnatoria
        {
            get
            {
                return this.accompagnatoriaField;
            }
            set
            {
                this.accompagnatoriaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccompagnatoriaSpecified
        {
            get
            {
                return this.accompagnatoriaFieldSpecified;
            }
            set
            {
                this.accompagnatoriaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Classificazione")]
        public CustomMetadataIntestazioneClassificazione[] Classificazione
        {
            get
            {
                return this.classificazioneField;
            }
            set
            {
                this.classificazioneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Assegnazione")]
        public CustomMetadataIntestazioneAssegnazione[] Assegnazione
        {
            get
            {
                return this.assegnazioneField;
            }
            set
            {
                this.assegnazioneField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public enum CustomMetadataIntestazioneFlusso
    {

        /// <remarks/>
        E,

        /// <remarks/>
        U,

        /// <remarks/>
        I,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public enum CustomMetadataIntestazioneEMail
    {

        /// <remarks/>
        S,

        /// <remarks/>
        N,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public enum CustomMetadataIntestazioneAccompagnatoria
    {

        /// <remarks/>
        S,

        /// <remarks/>
        N,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class CustomMetadataIntestazioneClassificazione
    {

        private string categoriaField;

        private string classeField;

        private string annoFascicoloField;

        private string numeroFascicoloField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Categoria
        {
            get
            {
                return this.categoriaField;
            }
            set
            {
                this.categoriaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Classe
        {
            get
            {
                return this.classeField;
            }
            set
            {
                this.classeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string AnnoFascicolo
        {
            get
            {
                return this.annoFascicoloField;
            }
            set
            {
                this.annoFascicoloField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string NumeroFascicolo
        {
            get
            {
                return this.numeroFascicoloField;
            }
            set
            {
                this.numeroFascicoloField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class CustomMetadataIntestazioneAssegnazione
    {

        private string assegnatoAField;

        private string assegnatoDaField;

        /// <remarks/>
        public string AssegnatoA
        {
            get
            {
                return this.assegnatoAField;
            }
            set
            {
                this.assegnatoAField = value;
            }
        }

        /// <remarks/>
        public string AssegnatoDa
        {
            get
            {
                return this.assegnatoDaField;
            }
            set
            {
                this.assegnatoDaField = value;
            }
        }
    }
}