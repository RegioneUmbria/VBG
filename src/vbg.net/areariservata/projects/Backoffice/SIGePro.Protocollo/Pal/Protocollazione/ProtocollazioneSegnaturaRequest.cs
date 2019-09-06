﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Xml.Serialization;
// 
// Codice sorgente generato automaticamente da xsd, versione=4.6.1055.0.
// 

namespace Init.SIGePro.Protocollo.Pal.Protocollazione
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Protocollazione", Namespace = "", IsNullable = false)]
    public partial class ProtocollazioneType
    {
        public IntestazioneType Intestazione { get; set; }

        public DocumentiType Documenti { get; set; }

        public ProtocollazioneType()
        {

        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    public partial class IntestazioneType
    {
        public string Ente { get; set; }

        public string Aoo { get; set; }

        public string ModelloOrganizzativo { get; set; }

        public string TipoProtocollo { get; set; }

        public string Oggetto { get; set; }

        public string Classifica { get; set; }

        //[System.Xml.Serialization.XmlArrayItemAttribute("Mittenti", IsNullable = false)]
        //[XmlIgnore]
        //public MittentiType Mittenti { get; set; }

        

        [System.Xml.Serialization.XmlArrayItemAttribute("Mittente", IsNullable = false )]
        public MittenteType[] Mittenti { get; set; }


        //[System.Xml.Serialization.XmlArrayItemAttribute("Destinatari", IsNullable = true)]
        public DestinatariType Destinatari { get; set; }

        //[System.Xml.Serialization.XmlArrayItemAttribute("Fascicoli", IsNullable = true)]
        public FascicoliType Fascicoli { get; set; }

        public AssegnatariType Assegnatari { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AssegnatariType
    {
        [System.Xml.Serialization.XmlElementAttribute("Assegnatario", IsNullable = false)]
        public AssegnatarioType Assegnatario { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AssegnatarioType
    {
        public string Tipo { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Persona", typeof(PersonaType))]
        [System.Xml.Serialization.XmlElementAttribute("Settore", typeof(SettoreType))]
        public object Item { get; set; }
    }

    /// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class MittentiType
    //{
    //    [System.Xml.Serialization.XmlArrayItemAttribute("Mittente", IsNullable = false)]
    //    public MittenteType[] Mittente { get; set; }
    //}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MittenteType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MittenteEsterno", typeof(MittenteEsternoType))]
        [System.Xml.Serialization.XmlElementAttribute("MittenteInterno", typeof(MittenteInternoType))]
        public object Item { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MittenteEsternoType
    {
        public string Tipo { get; set; }

        public string Denominazione { get; set; }

        public string Mail { get; set; }

        public string Indirizzo { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentoType
    {
        public string Nome { get; set; }

        public string Tipo { get; set; }

        public string Riferimento { get; set; }

        public string URL { get; set; }

        [XmlIgnore]
        public byte[] Oggetto { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DocumentiType
    {
        public DocumentoType Documento { get; set; }

        public AllegatiType Allegati { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AllegatiType
    {
        [System.Xml.Serialization.XmlElementAttribute("Documento", IsNullable = false)]
        public DocumentoType[] Documento { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DestinatariType
    {
        [System.Xml.Serialization.XmlElementAttribute("Destinatario", IsNullable = false)]
        public DestinatarioType[] Destinatario{ get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DestinatarioType
    {
        public string Tipo { get; set; }

        public string Denominazione { get; set; }

        public string Mail { get; set; }

        public string Indirizzo { get; set; }

        public string TipoPosta { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FascicoliType
    {
        public string[] Fascicolo { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class MittenteInternoType
    {
        public string Tipo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Persona", typeof(PersonaType))]
        [System.Xml.Serialization.XmlElementAttribute("Settore", typeof(SettoreType))]
        public object Item { get; set; }
    }

    /// <remarks/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    //public partial class MittenteInternoTypePersona
    //{
    //    public string Ruolo { get; set; }

    //    public string Utente { get; set; }
    //}

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PersonaType
    {
        public string Ruolo { get; set; }

        public string Utente { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SettoreType
    {
        public string Organigramma { get; set; }
    }


}