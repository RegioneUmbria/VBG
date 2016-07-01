﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Init.Sigepro.FrontEnd.Contenuti;

namespace Init.Sigepro.FrontEnd.Public
{
	public partial class RicercaInterventiDettaglio : ContenutiBasePage
	{
		public new string IdComune
		{
			get { return Request.QueryString["IdComune"]; }
		}


		public string Id
		{
			get { return Request.QueryString["Id"]; }
		}


		protected void Page_Load(object sender, EventArgs e)
		{

		}

		public string GetUrlStampaPagina()
		{
			return GetUrlBase() + "Public/MostraDettagliIntervento.aspx?idComune=" + IdComune + "&Id=" + Id + "&Print=true";
		}

		public string GetUrlDownloadPagina()
		{
			var downloadUrl = GetUrlStampaPagina();

			return ResolveClientUrl("~/Public/DownloadPage.ashx") + "?IdComune=" + IdComune + "&url=" + Server.UrlEncode(downloadUrl);
		}

		public string GetUrlEndoAttivabili()
		{
			return ResolveClientUrl("~/Public/ListaEndoAttivabili.aspx") + "?IdComune=" + IdComune + "&intervento=" + Id + "&fromAreaRiservata=false";
		}

		public override void DataBind()
		{
		}

		protected void cmdClose_Click(object sender, EventArgs e)
		{
			Response.Redirect("~/Public/RicercaInterventi.aspx?IdComune=" + IdComune + "&Software=" + Software );
		}
	}
}