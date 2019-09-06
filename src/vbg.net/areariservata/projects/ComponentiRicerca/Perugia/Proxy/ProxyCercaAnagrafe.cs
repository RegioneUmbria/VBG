﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.832
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.42.
// 

namespace Perugia.Proxy
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "CercaSoap", Namespace = "http://s-sviluppo/AnagWS")]
    public partial class Cerca : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback IndividuoOperationCompleted;

        private System.Threading.SendOrPostCallback ElencoOperationCompleted;

        private System.Threading.SendOrPostCallback ComposizioneFamigliaOperationCompleted;

        private System.Threading.SendOrPostCallback FigliErediOperationCompleted;

        private System.Threading.SendOrPostCallback ElencoAnagTribOperationCompleted;

        /// <remarks/>
        public Cerca()
        {
            this.Url = "http://s-sviluppo/AnagWS/Cerca.asmx";
        }

        /// <remarks/>
        public event IndividuoCompletedEventHandler IndividuoCompleted;

        /// <remarks/>
        public event ElencoCompletedEventHandler ElencoCompleted;

        /// <remarks/>
        public event ComposizioneFamigliaCompletedEventHandler ComposizioneFamigliaCompleted;

        /// <remarks/>
        public event FigliErediCompletedEventHandler FigliErediCompleted;

        /// <remarks/>
        public event ElencoAnagTribCompletedEventHandler ElencoAnagTribCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://s-sviluppo/AnagWS/Individuo", RequestNamespace = "http://s-sviluppo/AnagWS", ResponseNamespace = "http://s-sviluppo/AnagWS", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet Individuo(int NumInd)
        {
            object[] results = this.Invoke("Individuo", new object[] {
                    NumInd});
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginIndividuo(int NumInd, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("Individuo", new object[] {
                    NumInd}, callback, asyncState);
        }

        /// <remarks/>
        public System.Data.DataSet EndIndividuo(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public void IndividuoAsync(int NumInd)
        {
            this.IndividuoAsync(NumInd, null);
        }

        /// <remarks/>
        public void IndividuoAsync(int NumInd, object userState)
        {
            if ((this.IndividuoOperationCompleted == null))
            {
                this.IndividuoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIndividuoOperationCompleted);
            }
            this.InvokeAsync("Individuo", new object[] {
                    NumInd}, this.IndividuoOperationCompleted, userState);
        }

        private void OnIndividuoOperationCompleted(object arg)
        {
            if ((this.IndividuoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IndividuoCompleted(this, new IndividuoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://s-sviluppo/AnagWS/Elenco", RequestNamespace = "http://s-sviluppo/AnagWS", ResponseNamespace = "http://s-sviluppo/AnagWS", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet Elenco(string NumInd, string Cognome, string Nome, string Sesso, string DataNascita, string CodiceFiscale, string CartaIdentitaNumero, string RecapitoIndirizzo, string DescrizioneIndirizzo, string NumeroCivicoIndirizzo, string LetteraIndirizzo, string IndicatoreTipoIndividuo)
        {
            object[] results = this.Invoke("Elenco", new object[] {
                    NumInd,
                    Cognome,
                    Nome,
                    Sesso,
                    DataNascita,
                    CodiceFiscale,
                    CartaIdentitaNumero,
                    RecapitoIndirizzo,
                    DescrizioneIndirizzo,
                    NumeroCivicoIndirizzo,
                    LetteraIndirizzo,
                    IndicatoreTipoIndividuo});
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginElenco(string NumInd, string Cognome, string Nome, string Sesso, string DataNascita, string CodiceFiscale, string CartaIdentitaNumero, string RecapitoIndirizzo, string DescrizioneIndirizzo, string NumeroCivicoIndirizzo, string LetteraIndirizzo, string IndicatoreTipoIndividuo, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("Elenco", new object[] {
                    NumInd,
                    Cognome,
                    Nome,
                    Sesso,
                    DataNascita,
                    CodiceFiscale,
                    CartaIdentitaNumero,
                    RecapitoIndirizzo,
                    DescrizioneIndirizzo,
                    NumeroCivicoIndirizzo,
                    LetteraIndirizzo,
                    IndicatoreTipoIndividuo}, callback, asyncState);
        }

        /// <remarks/>
        public System.Data.DataSet EndElenco(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public void ElencoAsync(string NumInd, string Cognome, string Nome, string Sesso, string DataNascita, string CodiceFiscale, string CartaIdentitaNumero, string RecapitoIndirizzo, string DescrizioneIndirizzo, string NumeroCivicoIndirizzo, string LetteraIndirizzo, string IndicatoreTipoIndividuo)
        {
            this.ElencoAsync(NumInd, Cognome, Nome, Sesso, DataNascita, CodiceFiscale, CartaIdentitaNumero, RecapitoIndirizzo, DescrizioneIndirizzo, NumeroCivicoIndirizzo, LetteraIndirizzo, IndicatoreTipoIndividuo, null);
        }

        /// <remarks/>
        public void ElencoAsync(string NumInd, string Cognome, string Nome, string Sesso, string DataNascita, string CodiceFiscale, string CartaIdentitaNumero, string RecapitoIndirizzo, string DescrizioneIndirizzo, string NumeroCivicoIndirizzo, string LetteraIndirizzo, string IndicatoreTipoIndividuo, object userState)
        {
            if ((this.ElencoOperationCompleted == null))
            {
                this.ElencoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnElencoOperationCompleted);
            }
            this.InvokeAsync("Elenco", new object[] {
                    NumInd,
                    Cognome,
                    Nome,
                    Sesso,
                    DataNascita,
                    CodiceFiscale,
                    CartaIdentitaNumero,
                    RecapitoIndirizzo,
                    DescrizioneIndirizzo,
                    NumeroCivicoIndirizzo,
                    LetteraIndirizzo,
                    IndicatoreTipoIndividuo}, this.ElencoOperationCompleted, userState);
        }

        private void OnElencoOperationCompleted(object arg)
        {
            if ((this.ElencoCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ElencoCompleted(this, new ElencoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://s-sviluppo/AnagWS/ComposizioneFamiglia", RequestNamespace = "http://s-sviluppo/AnagWS", ResponseNamespace = "http://s-sviluppo/AnagWS", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet ComposizioneFamiglia(int NumInd)
        {
            object[] results = this.Invoke("ComposizioneFamiglia", new object[] {
                    NumInd});
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginComposizioneFamiglia(int NumInd, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ComposizioneFamiglia", new object[] {
                    NumInd}, callback, asyncState);
        }

        /// <remarks/>
        public System.Data.DataSet EndComposizioneFamiglia(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public void ComposizioneFamigliaAsync(int NumInd)
        {
            this.ComposizioneFamigliaAsync(NumInd, null);
        }

        /// <remarks/>
        public void ComposizioneFamigliaAsync(int NumInd, object userState)
        {
            if ((this.ComposizioneFamigliaOperationCompleted == null))
            {
                this.ComposizioneFamigliaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnComposizioneFamigliaOperationCompleted);
            }
            this.InvokeAsync("ComposizioneFamiglia", new object[] {
                    NumInd}, this.ComposizioneFamigliaOperationCompleted, userState);
        }

        private void OnComposizioneFamigliaOperationCompleted(object arg)
        {
            if ((this.ComposizioneFamigliaCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ComposizioneFamigliaCompleted(this, new ComposizioneFamigliaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://s-sviluppo/AnagWS/FigliEredi", RequestNamespace = "http://s-sviluppo/AnagWS", ResponseNamespace = "http://s-sviluppo/AnagWS", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet FigliEredi(int NumInd)
        {
            object[] results = this.Invoke("FigliEredi", new object[] {
                    NumInd});
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginFigliEredi(int NumInd, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("FigliEredi", new object[] {
                    NumInd}, callback, asyncState);
        }

        /// <remarks/>
        public System.Data.DataSet EndFigliEredi(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public void FigliErediAsync(int NumInd)
        {
            this.FigliErediAsync(NumInd, null);
        }

        /// <remarks/>
        public void FigliErediAsync(int NumInd, object userState)
        {
            if ((this.FigliErediOperationCompleted == null))
            {
                this.FigliErediOperationCompleted = new System.Threading.SendOrPostCallback(this.OnFigliErediOperationCompleted);
            }
            this.InvokeAsync("FigliEredi", new object[] {
                    NumInd}, this.FigliErediOperationCompleted, userState);
        }

        private void OnFigliErediOperationCompleted(object arg)
        {
            if ((this.FigliErediCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.FigliErediCompleted(this, new FigliErediCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://s-sviluppo/AnagWS/ElencoAnagTrib", RequestNamespace = "http://s-sviluppo/AnagWS", ResponseNamespace = "http://s-sviluppo/AnagWS", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet ElencoAnagTrib(string Tipo, string NumInd, string Cognome, string Nome, string CF, string Data)
        {
            object[] results = this.Invoke("ElencoAnagTrib", new object[] {
                    Tipo,
                    NumInd,
                    Cognome,
                    Nome,
                    CF,
                    Data});
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginElencoAnagTrib(string Tipo, string NumInd, string Cognome, string Nome, string CF, string Data, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ElencoAnagTrib", new object[] {
                    Tipo,
                    NumInd,
                    Cognome,
                    Nome,
                    CF,
                    Data}, callback, asyncState);
        }

        /// <remarks/>
        public System.Data.DataSet EndElencoAnagTrib(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }

        /// <remarks/>
        public void ElencoAnagTribAsync(string Tipo, string NumInd, string Cognome, string Nome, string CF, string Data)
        {
            this.ElencoAnagTribAsync(Tipo, NumInd, Cognome, Nome, CF, Data, null);
        }

        /// <remarks/>
        public void ElencoAnagTribAsync(string Tipo, string NumInd, string Cognome, string Nome, string CF, string Data, object userState)
        {
            if ((this.ElencoAnagTribOperationCompleted == null))
            {
                this.ElencoAnagTribOperationCompleted = new System.Threading.SendOrPostCallback(this.OnElencoAnagTribOperationCompleted);
            }
            this.InvokeAsync("ElencoAnagTrib", new object[] {
                    Tipo,
                    NumInd,
                    Cognome,
                    Nome,
                    CF,
                    Data}, this.ElencoAnagTribOperationCompleted, userState);
        }

        private void OnElencoAnagTribOperationCompleted(object arg)
        {
            if ((this.ElencoAnagTribCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ElencoAnagTribCompleted(this, new ElencoAnagTribCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void IndividuoCompletedEventHandler(object sender, IndividuoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IndividuoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal IndividuoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Data.DataSet Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void ElencoCompletedEventHandler(object sender, ElencoCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ElencoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ElencoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Data.DataSet Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void ComposizioneFamigliaCompletedEventHandler(object sender, ComposizioneFamigliaCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ComposizioneFamigliaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ComposizioneFamigliaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Data.DataSet Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void FigliErediCompletedEventHandler(object sender, FigliErediCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FigliErediCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal FigliErediCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Data.DataSet Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void ElencoAnagTribCompletedEventHandler(object sender, ElencoAnagTribCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ElencoAnagTribCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ElencoAnagTribCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Data.DataSet Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}
