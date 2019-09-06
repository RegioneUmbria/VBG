using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Init.Sigepro.FrontEnd.Reserved
{
	public partial class ErroreAccessoPagina : ReservedBasePage
	{
		public enum TipoErroreEnum
		{
			ErroreNonDefinito= 0,
			PermessiNonDisponibili = 1,
			IstanzaGiaPresentata = 2,
			AccessoNegato = 3
		}

		public static void Mostra(string idComune, string software, TipoErroreEnum tipoErrore)
		{
			var url = $"~/Reserved/ErroreAccessoPagina.aspx?Software={software}&IdComune={idComune}&Codice={tipoErrore}";
			HttpContext.Current.Response.Redirect(url);
		}

		TipoErroreEnum TipoErrore
		{
			get 
			{ 
				var tipoErrore = Request.QueryString["Codice"];

				if (String.IsNullOrEmpty(tipoErrore))
					return TipoErroreEnum.ErroreNonDefinito;

				return (TipoErroreEnum)Enum.Parse(typeof(TipoErroreEnum),tipoErrore);
			
			}
		}

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
				DataBind();
		}

		public override void DataBind()
		{
			string msg = "Si � verificato un errore durante l'apertura dell'istanza";

			switch (TipoErrore)
			{
				case TipoErroreEnum.PermessiNonDisponibili:
					msg = "Non si dispone dei permessi necessari per accedere ai dati dell'istanza";
					break;

				case TipoErroreEnum.IstanzaGiaPresentata:
					msg = "La domanda � gi� stata presentata";
					break;

				case TipoErroreEnum.AccessoNegato:
					msg = "Non si dispone delle autorizzazioni necessarie per accedere a questa funzionalit�";
                    //this.Master.MostraMenuNavigazione = false;
					this.Title = "Accesso negato";
					break;

				default:
					msg = "Errore non definito, contattare il servizio di assistenza";
					break;



			}

			ltrErrore.Text = msg;
		}
	}
}
