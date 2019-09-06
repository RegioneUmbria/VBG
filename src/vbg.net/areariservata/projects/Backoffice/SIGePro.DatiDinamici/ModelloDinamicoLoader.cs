﻿// -----------------------------------------------------------------------
// <copyright file="ModelloDinamicoLoader.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Init.SIGePro.DatiDinamici
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Init.SIGePro.DatiDinamici.Interfaces;
	using Init.SIGePro.DatiDinamici.Scripts;

	/// <summary>
	/// TODO: Update summary.
	/// </summary>
	public class ModelloDinamicoLoader : Init.SIGePro.DatiDinamici.IModelloDinamicoLoader
	{
        public enum TipoModelloDinamicoEnum
        {
            Frontoffice,
            Backoffice
        }

		IDyn2DataAccessProvider _dataAccessProvider;
		string _idComune;
		int _idModello;
		ModelloDinamicoBase _modello;
        TipoModelloDinamicoEnum _tipoModelloDinamico;

		public IDyn2DataAccessProvider DataAccessProvider
		{
			get { return this._dataAccessProvider; }
		}

		public string Idcomune 
		{
			get { return this._idComune; } 
		}

		public string Token
		{
			get { return this._dataAccessProvider.GetToken(); }
		}

		public string NomeModello
		{
			get { return GetD2Modello().Descrizione; }
		}

		public void SetModello(ModelloDinamicoBase modello)
		{
			this._modello = modello;
			this._idModello = modello.IdModello;
		}

		public ModelloDinamicoLoader(IDyn2DataAccessProvider dataAccessProvider, string idComune, TipoModelloDinamicoEnum tipoModello)
		{
			this._dataAccessProvider = dataAccessProvider;
			this._idComune = idComune;
			this._tipoModelloDinamico = tipoModello;
		}

		IDyn2Modello _d2modello;

		private IDyn2Modello GetD2Modello()
		{
			if (this._d2modello == null)
			{
				var mgrModelli = _dataAccessProvider.GetModelliManager();
				this._d2modello = mgrModelli.GetById(this._idComune, this._idModello);
			}

			return this._d2modello;
		}

		public ModelloDinamicoBase.FlagsModello GetFlags()
		{
			var d2Modello = GetD2Modello();

			var readOnlyWeb = d2Modello.FlgReadonlyWeb.GetValueOrDefault(0) == 1;
			var storicizza = d2Modello.FlgStoricizza.GetValueOrDefault(0) == 1;
			var modelloMultiplo = d2Modello.Modellomultiplo.GetValueOrDefault(0) == 1;

			return new ModelloDinamicoBase.FlagsModello(readOnlyWeb, storicizza, modelloMultiplo);
		}

		public ModelloDinamicoBase.ScriptsModello GetScripts()
		{
			ScriptCampoDinamico scriptCaricamento = null;
			ScriptCampoDinamico scriptModifica = null;
			ScriptCampoDinamico scriptSalvataggio = null;

			// Carica lo script del modello
			var mgr = _dataAccessProvider.GetScriptModelliManager();

			// Script caricamento
			var script = mgr.GetById(this._idComune, this._idModello, TipoScriptEnum.Funzioni);

			var funzioniCondivise = script == null ? String.Empty : script.GetTestoScript();

			script = mgr.GetById(this._idComune, this._idModello, TipoScriptEnum.Caricamento);

			if (script != null && !String.IsNullOrEmpty(script.GetTestoScript()))
				scriptCaricamento = new ScriptCampoDinamico(this._modello, script.GetTestoScript(), funzioniCondivise);

			// Script Salvataggio
			script = mgr.GetById(this._idComune, this._idModello, TipoScriptEnum.Salvataggio);

			if (script != null && !String.IsNullOrEmpty(script.GetTestoScript()))
				scriptSalvataggio = new ScriptCampoDinamico(this._modello, script.GetTestoScript(), funzioniCondivise);

			// Script Modifica
			script = mgr.GetById(this._idComune, this._idModello, TipoScriptEnum.Modifica);

			if (script != null && !String.IsNullOrEmpty(script.GetTestoScript()))
				scriptModifica = new ScriptCampoDinamico(this._modello, script.GetTestoScript(), funzioniCondivise);

			return new ModelloDinamicoBase.ScriptsModello(scriptCaricamento, scriptSalvataggio, scriptModifica);
		}

		public ModelloDinamicoBase.StrutturaModello GetStrutturaModello()
		{
			var righe = new List<RigaModelloDinamico>();
			var righeMultiple = new List<RigaModelloDinamico>();
			var campi = new List<CampoDinamicoBase>();
			var gruppi = new GruppoRigheCollection();

			var strutturaRighe		= GetStrutturaRighe();
			var listaCampiModello	= GetListaCampi();
			var listaTestiModello	= GetListaTesti();

			// Crea le righe del modello popolando la collection m_righe
			foreach (var dettaglio in strutturaRighe)
			{
				var posVerticaleCorretta = dettaglio.Posverticale.GetValueOrDefault(0);
				var posOrizzontaleCorretta = dettaglio.Posorizzontale.GetValueOrDefault(0) - 1;

                // TODO: Trovare un modo migliore per generare le righe perché questo spreca troppi cicli
                while (righe.Count <= dettaglio.Posverticale)
					righe.Add(new RigaModelloDinamico(posVerticaleCorretta));

                var riga = righe[posVerticaleCorretta];

                // Tipo riga
                riga.TipoRiga = (TipoRigaEnum)dettaglio.FlgMultiplo.GetValueOrDefault(0);

                if (riga.TipoRiga != TipoRigaEnum.Singola)
                {
                    if (!righeMultiple.Contains(riga))
                    {
                        righeMultiple.Add(riga);
                    }
                }

                // Flag spezza tabella
                riga.InterrompiTabellaDopo = dettaglio.FlgSpezzaTabella.GetValueOrDefault(0) == 1;

                // Campo contenuto nel dettaglio
                CampoDinamicoBase campo = null;

				if (dettaglio.FkD2cId.HasValue)
				{
					// campo dinamico
					var dyn2Campo = listaCampiModello[dettaglio.FkD2cId.Value];
					campo = new CampoDinamico(this._modello, dyn2Campo, posOrizzontaleCorretta, posVerticaleCorretta);
				}
				else
				{
					// campo testuale
					var dyn2Testo = listaTestiModello[dettaglio.FkD2mdtId.Value];
					campo = new CampoDinamicoTestuale(this._modello, dyn2Testo);
				}				

				riga[posOrizzontaleCorretta] = campo;
				campi.Add(campo);
			}


			// Dopo avere popolato tutte le righe cerca di organizzare i gruppi in cui è strutturato il modello.
			// Un gruppo è un insieme di una o più righe consecutive con flag riga multipla == true
			var indiceGruppo = 0;
			var rigaMultiplaTrovata = false;

			foreach (var riga in righe)
			{
				if (riga.NumeroColonne == 0)
					continue;

				if (rigaMultiplaTrovata)
				{
                    if (riga.TipoRiga != TipoRigaEnum.Singola)
					{
						gruppi.AggiungiRigaAGruppo(indiceGruppo, riga);
					}
					else
					{
						indiceGruppo++;
						rigaMultiplaTrovata = false;
					}
				}
				else
				{
					if (riga.TipoRiga != TipoRigaEnum.Singola)
					{
						rigaMultiplaTrovata = true;
						gruppi.AggiungiRigaAGruppo(indiceGruppo, riga);
					}
				}
			}

			return new ModelloDinamicoBase.StrutturaModello(righeMultiple, righe, campi, gruppi);
		}

		private IEnumerable<IDyn2DettagliModello> GetStrutturaRighe()
		{
			var mgr = this._dataAccessProvider.GetDettagliModelloManager();

			return mgr.GetList(this._idComune, this._idModello);
		}

		private Utils.SerializableDictionary<int, IDyn2Campo> GetListaCampi()
		{
			var mgr = this._dataAccessProvider.GetCampiManager();

			return mgr.GetListaCampiDaIdModello(this._idComune, this._idModello);
		}

		private Utils.SerializableDictionary<int, IDyn2TestoModello> GetListaTesti()
		{
			var mgr = this._dataAccessProvider.GetTestoModelloManager();

			return mgr.GetListaTestiDaIdModello(this._idComune, this._idModello);
		}


		public bool GetModelloFrontoffice()
		{
			return this._tipoModelloDinamico == TipoModelloDinamicoEnum.Frontoffice;
		}
	}
}
