﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 

namespace Init.SIGePro.Protocollo.EGrammata.Segnatura.GetProtoInput
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("EstremiXIdentificazioneUD", Namespace = "", IsNullable = false)]
    public partial class EstremiXIdentificazioneUDType
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EstremiRegNum", typeof(EstremiRegNumType))]
        [System.Xml.Serialization.XmlElementAttribute("IdUD", typeof(string), DataType = "integer")]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EstremiRegNumType
    {

        private EstremiRegNumTypeCategoriaRegistro categoriaRegistroField;

        private string siglaRegistroField;

        private string annoField;

        private string numeroField;

        /// <remarks/>
        public EstremiRegNumTypeCategoriaRegistro CategoriaRegistro
        {
            get
            {
                return this.categoriaRegistroField;
            }
            set
            {
                this.categoriaRegistroField = value;
            }
        }

        /// <remarks/>
        public string SiglaRegistro
        {
            get
            {
                return this.siglaRegistroField;
            }
            set
            {
                this.siglaRegistroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Anno
        {
            get
            {
                return this.annoField;
            }
            set
            {
                this.annoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Numero
        {
            get
            {
                return this.numeroField;
            }
            set
            {
                this.numeroField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum EstremiRegNumTypeCategoriaRegistro
    {

        /// <remarks/>
        PG,

        /// <remarks/>
        PP,

        /// <remarks/>
        R,

        /// <remarks/>
        E,

        /// <remarks/>
        A,

        /// <remarks/>
        I,
    }
}