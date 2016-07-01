
			using System;
			using System.IO;
			using Init.SIGePro.Data;
			using PersonalLib2.Data;

			namespace Init.SIGePro.Verticalizzazioni
			{
				/**************************************************************************************************************************************
				*
				* Classe generata automaticamente dalla verticalizzazione PROTOCOLLO_IRIDE il 26/08/2014 17.28.01
				* NON MODIFICARE DIRETTAMENTE!!!
				*
				***************************************************************************************************************************************/
			
			
				/// <summary>
				/// Abilita il protocollo con IRIDE, si rende necessario togliere il modulo PR dalla tabella COMUNISECURITY.
				/// </summary>
				public partial class VerticalizzazioneProtocolloIride : Verticalizzazione
				{
					private const string NOME_VERTICALIZZAZIONE = "PROTOCOLLO_IRIDE";

                    public VerticalizzazioneProtocolloIride()
                    {

                    }

					public VerticalizzazioneProtocolloIride(string idComuneAlias, string software, string codiceComune) : base(idComuneAlias, NOME_VERTICALIZZAZIONE , software, codiceComune){}
					
					
					/// <summary>
					/// Percorso completo del WS di fascicolazione Es. http://www.comune/ulisse/iride/web_services/WSFascicolo/WSFascicolo.asmx
					/// </summary>
					public string Urlfasc
					{
						get{ return GetString("URLFASC");}
						set{ SetString("URLFASC" , value); }
					}
					
					/// <summary>
					/// Parametro che in Iride specifica se aggiornare la classifica del documento se diversa da quella del fascicolo
					/// </summary>
					public string Aggiornaclassifica
					{
						get{ return GetString("AGGIORNACLASSIFICA");}
						set{ SetString("AGGIORNACLASSIFICA" , value); }
					}
					
					/// <summary>
					/// Numero pratica da passare al WS Iride a Ravenna "9999999"
					/// </summary>
					public string Numeropratica
					{
						get{ return GetString("NUMEROPRATICA");}
						set{ SetString("NUMEROPRATICA" , value); }
					}
					
					/// <summary>
					/// Parametro che in Iride specifica se aggiornare le anagrafiche. Possibili valori S o N.
					/// </summary>
					public string Aggiornaanagrafiche
					{
						get{ return GetString("AGGIORNAANAGRAFICHE");}
						set{ SetString("AGGIORNAANAGRAFICHE" , value); }
					}
					
					/// <summary>
					/// Percorso completo del WS Es. http://irideweb/ulisse/iride/web_services/WSprotocollo/wsprotocollo.asmx
					/// </summary>
					public string Url
					{
						get{ return GetString("URL");}
						set{ SetString("URL" , value); }
					}
					
					/// <summary>
					/// Indica il codice di amministrazione da passare al web service di Iride, deve essere fornito dall'amministratore del protocollo. Questo dato indica su quale amministrazione protocollare, infatti Iride può avere un'installazione MultiDB, in questo caso va valorizzato questo dato che, tra le altre cose può indicare se si sta utilizzando un ambiente di Test o di Produzione.
					/// </summary>
					public string Codiceamministrazione
					{
						get{ return GetString("CODICEAMMINISTRAZIONE");}
						set{ SetString("CODICEAMMINISTRAZIONE" , value); }
					}
					
					/// <summary>
					/// Nome della vista da interrogare per la decodifica dei codici istat
					/// </summary>
					public string View
					{
						get{ return GetString("VIEW");}
						set{ SetString("VIEW" , value); }
					}
					
					/// <summary>
					/// Owner della vista da interrogare per la decodifica dei codici istat
					/// </summary>
					public string Owner
					{
						get{ return GetString("OWNER");}
						set{ SetString("OWNER" , value); }
					}
					
					/// <summary>
					/// Stringa di connessione della vista da interrogare per la decodifica dei codici istat
					/// </summary>
					public string Connectionstring
					{
						get{ return GetString("CONNECTIONSTRING");}
						set{ SetString("CONNECTIONSTRING" , value); }
					}
					
					/// <summary>
					/// Provider della vista da interrogare per la decodifica dei codici istat
					/// </summary>
					public string Provider
					{
						get{ return GetString("PROVIDER");}
						set{ SetString("PROVIDER" , value); }
					}
					
					/// <summary>
					/// Consente di disabilitare la funzionalità di creazione delle copie su Iride (se = 1). Inserito in quanto l'invio della notifica tramite il movimento dell'istanza creava automaticamente anche la copia sul sistema di protocollazione Iride, e questo può creare alcuni disagi per i clienti che gestiscono manualmente le pratiche o che abbiano già creato il protocollo su Iride, come nel caso della Bassa Romagna. NB. L'utilizzo di questo parametro può portare a qualche problema durante la funzionalità di leggi protocollo, infatti se valorizzato a 1, i dati inviati tramite notifica STC sulla nuova istanza su nuovo software non saranno compresi di IDPROTOCOLLO, questo significa che, in presenza di più copie (su IRIDE) con stessa numerazione ma con ID diverso, nel momento della lettura di un protocollo senza ID può essere riportato quello con ID sbagliato, in teoria comunque i dati dei protocolli con diversi ID ma con stessa numerazione dovrebbero essere gli stessi.
					/// </summary>
					public string DisabilitaCreacopie
					{
						get{ return GetString("DISABILITA_CREACOPIE");}
						set{ SetString("DISABILITA_CREACOPIE" , value); }
					}
					
					/// <summary>
					/// Indica il mezzo di default da passare al web service di Iride, non è un dato obbligatorio quindi può essere omesso. Questo dato, se valorizzato, viene proposto di default nella maschera di protocollazione nel dropdown riguardante i mezzi e se lo stesso valore è presente nella tabella PROTOCOLLO_MEZZI, viene inviato al web service anche quando la protocollazione è automatica, quindi proveniente da un frontoffice o dal backoffice se impostata la configurazione di protocollazione automatica. NB. se la tabella PROTOCOLLO_MEZZI è vuota il drop down mezzi, nella maschera di protocollazione, non viene visualizzato, ignorando quindi il valore di questo parametro.
					/// </summary>
					public string MezzoDefault
					{
						get{ return GetString("MEZZO_DEFAULT");}
						set{ SetString("MEZZO_DEFAULT" , value); }
					}
					
					/// <summary>
					/// Attivando il pulsante c'è la possibilità di comunicare al software INTRANOS (Comune di Ravenna) che un documento deve essere firmato. Ogni successivo cambiamento di stato compiuto in INTRANOS + IRIDE viene comunicato al Backoffice tramite WebService (Es: "Il documento è stato firmato", "Il documento è stato protocollato", "Il documento è stato inviato"). I cambiamenti di stato vengono scritti nel backoffice nella sezione eventi del movimento e, nel caso di protocollazione, viene riportato in automatico il numero di protocollo nel movimento. Accetta valori S o N
					/// </summary>
					public string MostraMettiAllaFirma
					{
						get{ return GetString("MOSTRA_METTI_ALLA_FIRMA");}
						set{ SetString("MOSTRA_METTI_ALLA_FIRMA" , value); }
					}
					
					/// <summary>
					/// Valido solo per Iride2, è un tag che indica che tipo di comportamento deve assumere il recapito EMAIL, se il tag NON è presente oppure 
/// è presente con un qualsiasi valore diverso da S, il ws si comporta come ha sempre fatto 
/// (inserisce anagrafica se non esiste o va in aggiornamento sul tipo recapito indicato), 
/// se il tag è presente con il valore S esegue le seguenti operazioni:
/// a)	se il recapito per quel tipo e quel valore (considerando la valutazione case insensitive) esiste non si esegue nulla
/// b)	se il recapito per quel tipo esiste ma con valore diverso occorre :
/// se non esiste un "TipoRecapito" X col valore attuale del recapito se ne inserisce uno nuovo dove X e’ il primo disponibile  e 
/// successivamente si aggiorna il recapito con il "valorerecapito", se invece esiste lo stesso recapito sarà classificato come 
/// primo della lista.
					/// </summary>
					public string SwapEmail
					{
						get{ return GetString("SWAP_EMAIL");}
						set{ SetString("SWAP_EMAIL" , value); }
					}
					
					/// <summary>
					/// Indicare in questo parametro l'endpoint da utilizzare per usare il servizio di invio posta elettronica certificata di Iride, sarà proprio questo servizio che si occuperà di inviare la PEC
					/// </summary>
					public string UrlPec
					{
						get{ return GetString("URL_PEC");}
						set{ SetString("URL_PEC" , value); }
					}
					
					/// <summary>
					/// Indicare il mezzo da utilizzare se si vuole inviare la PEC richiamando il web service PosteWeb di Iride. Se il protocollo è in partenza e sono presenti dei destinatari esterni (che non abbiano scrivanie su Iride) è necessario indicare il mezzo per cui, al destinatario, venga inviata anche una PEC tramite il servizio PostePec di Iride indicato nel parametro URL_PEC, se sarà utilizzato quindi il mezzo indicato in questo parametro il sistema si occuperà di chiamare quindi il servizio di invio pec di iride
					/// </summary>
					public string MezzoPec
					{
						get{ return GetString("MEZZO_PEC");}
						set{ SetString("MEZZO_PEC" , value); }
					}
					
					/// <summary>
					/// Inserire in questo parametro il valore relativo al mittente che invia la mail pec in fase di protocollazione in partenza, questo parametro è legato all'altro parametro URL_PEC in quanto, se non presente quest'ultimo, MITTENTE_PEC non viene utilizzato
					/// </summary>
					public string MittentePec
					{
						get{ return GetString("MITTENTE_PEC");}
						set{ SetString("MITTENTE_PEC" , value); }
					}

                    /// <summary>
                    /// Serve per indicare in quale formato deve essere inviata la data di fascicolazione al web service. Maggioli ha creato un altro web service compatibile con Iride (ProtocolloSoap e DocWsFascicoli), solo che la data deve avere formato yyyy-MM-dd altrimenti non viene riconosciuta. Quindi, solo nel momento in cui vengono usati questi web service, il formato data deve essere impostato a yyyy-MM-dd, in generale, comunque, il componente PROTOCOLLO_IRIDE andrà ad impostare la data in base a quanto scritto in questo parametro, quindi, se viene impostato dd-MM-yyyy il sistema invierà ad esempio 23-10-2014, che nel caso specifico di questo web service, restituirà errore, evitare quindi di inserire ulteriori formati. Nel caso del vecchio Iride, non va impostato.
                    /// </summary>
                    public string FormatoDataFasc
                    {
                        get { return GetString("FORMATO_DATA_FASC"); }
                        set { SetString("FORMATO_DATA_FASC", value); }
                    }

                    /// <summary>
                    /// Inserire in questo parametro la stringa che viene restituita dal web service nn fase di protocollazione avvenuta correttamente. Iride restituisce un messaggio anche in caso di protocollazione avvenuta correttamente, il messaggio viene successivamente inserito nei warning quindi va eliminata la stringa restituita in caso di protocollazione OK.
                    /// </summary>
                    public string WarningDaEliminare
                    {
                        get { return GetString("WARNING_DA_ELIMINARE"); }
                        set { SetString("WARNING_DA_ELIMINARE", value); }
                    }

                    /// <summary>
                    /// Questo parametro serve per indicare al plugin del protocollo per capire se la lettura del protocollo deve essere fatta invocando il metodo LeggiProtocollo oppure LeggiDocumento, nel primo caso la chiamata viene fatta passando il numero e l'anno del protocollo, nel secondo l'id del documento, di default, se valorizzato il campo FKIDPROTOCOLLO delle ISTANZE o MOVIMENTO viene invocato il metodo LeggiDocumento, valorizzando questo parametro a 1 il sistema forza la chiamata sempre utilizzando il metodo LeggiProtocollo, questo perchè il nuovo ws retrocompatibile IRIDE di Maggioli ha un bug su leggi documento che non ritorna gli allegati.
                    /// </summary>
                    public string UsaNumAnnoLeggi
                    {
                        get { return GetString("USA_NUM_ANNO_LEGGI"); }
                        set { SetString("USA_NUM_ANNO_LEGGI", value); }
                    }

				}
			}
			