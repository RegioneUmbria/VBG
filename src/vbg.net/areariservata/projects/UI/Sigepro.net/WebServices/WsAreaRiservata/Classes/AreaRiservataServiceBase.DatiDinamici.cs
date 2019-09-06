﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Init.SIGePro.Manager.Logic.DatiDinamici.RicercheSigepro;
using Init.SIGePro.Data;
using Init.SIGePro.Manager.Logic.GestioneDecodifiche;

namespace Sigepro.net.WebServices.WsAreaRiservata.Classes
{
    
	public partial class AreaRiservataServiceBase
	{
        [WebMethod]
		public WsListaModelliDinamiciDomanda GetModelliDinamiciDaInterventoEEndo(string token, DatiDinamiciService.GetModelliDinamiciDaInterventoEEndoRequest request)
		{
			return new DatiDinamiciService().GetModelliDinamiciDaInterventoEEndo(token, request);
		}

		[WebMethod]
		public DatiDinamiciService.StrutturaModelloDinamico GetStrutturaModelloDinamico(string token, int idModello)
		{
			return new DatiDinamiciService().GetStrutturaModelloDinamico(token, idModello);
		}

		[WebMethod]
		public RicercheDatiDinamiciService.RisultatoRicercaDatiDinamici[] GetCompletionListRicerchePlus(string token, int idCampo, string partial, List<ValoreFiltroRicerca> filtri)
		{
            return new DatiDinamiciService().GetCompletionListRicerchePlus(token, idCampo, partial, filtri); 
		}

		[WebMethod]
		public RicercheDatiDinamiciService.RisultatoRicercaDatiDinamici InitializeControlRicerchePlus(string token, int idCampo, string value)
		{
			return new DatiDinamiciService().InitializeControlRicerchePlus(token, idCampo, value); 
		}

        [WebMethod]
        public IstanzeDyn2Dati[] GetDyn2DatiByIdModello(string token, int codiceIstanza, int idModello, int indiceCampo)
        {
            return new DatiDinamiciService().GetDyn2DatiByIdModello(token, codiceIstanza, idModello, indiceCampo);
        }

        [WebMethod]
        public IstanzeDyn2Dati[] GetDyn2DatiByCodiceIstanza(string token, int codiceIstanza )
        {
            return new DatiDinamiciService().GetDyn2DatiByCodiceIstanza(token, codiceIstanza);
        }

        [WebMethod]
        public DecodificaDTO[] GetDecodificheAttive(string token, string tabella)
        {
            return new DatiDinamiciService().GetDecodificheAttive(token, tabella);
        }


        [WebMethod]
        public void RecuperaDocumentiIstanzaCollegata(string token, int codiceIstanzaOrigine, int idDomandaDestinazione)
        {
            new DatiDinamiciService().RecuperaDocumentiIstanzaCollegata(token, codiceIstanzaOrigine, idDomandaDestinazione);
        }
    }
}
