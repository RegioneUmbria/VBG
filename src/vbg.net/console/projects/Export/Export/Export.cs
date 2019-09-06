using System;
using System.Configuration;
using System.Collections;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
//using Init.SIGePro.Data;
//using Init.SIGePro.Manager;
using Init.SIGeProExport.Data;
using Init.SIGeProExport.Manager;
using Init.Utils;
using Parser;
using PersonalLib2.Data;
using Export.Collection;
using Export.Data;
using System.Collections.Generic;
using System.Web;
using System.Globalization;
using Export.Mail;

namespace Export
{
    public class CExport : IDisposable
    {
        private MemorySpace _memory = new MemorySpace();
        private string sFileName = "";
        private FileManager fm = new FileManager();
        private string sDateTime;


        public CExport()
        {
        }


        #region Gestione creazione file (.txt o .xml)

        private void RunCycleDettTrac(List<TRACCIATIDETTAGLIO> alDett)
        {
            int index = 0;
            foreach (TRACCIATIDETTAGLIO dettaglio in alDett)
            {
                index += 1;
 
                //3.2.1.4.1 - Se CFG_TRACCIATIDETTAGLIO.QUERY non è null
                if (!StringChecker.IsStringEmpty(dettaglio.QUERY))
                {
                    //3.2.1.4.1.1 - _memory.replace(CFG_TRACCIATIDETTAGLIO.QUERY)
                    string pQueryDett = _memory.Replace(dettaglio.QUERY.Replace("\r\n", " "));
                    IDbDataAdapter adaptDett;
                    DataSet dsTracciatiDett = new DataSet();
                    try
                    {
                        if (Debug)
                            LogMessage(pQueryDett, FolderPath, IdComune);

                        IDbCommand cmdDett = DataBase.CreateCommand(pQueryDett);
                        DataProviderFactory dpf = new DataProviderFactory(DataBase.Connection);
                        adaptDett = dpf.CreateDataAdapter(cmdDett);
                        adaptDett.Fill(dsTracciatiDett);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Errore generato durante l'esecuzione della query del dettaglio tracciato " + dettaglio.DESCRIZIONE + ". La query è: " + pQueryDett + ". Modulo: Export. Metodo: RunCycleDettTrac. Messaggio: " + ex.Message + "\r\n");
                    }

                    //Verifico se l'esportazione è stata configurata per poter aggiungere una riga null qualora la query
                    //non restituisse alcun record
                    if (Esportazione.INSERISCI_NULLI == "1")
                    {
                        //3.2.1.4.1.2 - se nel dataset non ci sono righe, ne viene aggiunta 1 per impostare a null 
                        //le precedenti variabili inserite nel memory
                        if (dsTracciatiDett.Tables[0].Rows.Count == 0)
                            dsTracciatiDett.Tables[0].Rows.Add(dsTracciatiDett.Tables[0].NewRow());
                    }

                    //3.2.1.4.1.3 - ogni campo letto (select) si aggiunge a _memory (_memory.add). Nei tracciati di dettaglio 
                    // la query può ritornare più righe, in quel caso viene letta solamente la prima
                    if (dsTracciatiDett.Tables[0].Rows.Count > 0)
                        _memory.Add(dsTracciatiDett.Tables[0].Rows[0]);
                }

                string pValore = String.Empty;

                if (!StringChecker.IsStringEmpty(dettaglio.VALORE))
                {
                    //Si calcola il valore da esportare _memory.replace(CFG_TRACCIATIDETTAGLIO.VALORE) (potrebbe contenere variabili &)
                    pValore = _memory.Replace(dettaglio.VALORE);
                }
                else
                {
                    if (dettaglio.OBBLIGATORIO == "1")
                    {
                        //3.2.1.4.2.1 - Se Valore è String.Empty e TRACCIATIDETTAGLIO.OBBLIGATORIO=1 allora Exception
                        throw new Exception("IdTracciato: " + dettaglio.FK_TRACCIATI_ID + ", IdDettaglio: " + dettaglio.ID + ", dato obbligatorio non presente per il campo " + dettaglio.DESCRIZIONE);
                    }
                }

                //se l'esportazione deve creare un file CSV, allora:
                //          - i separatori e l'invio finale vengono aggiunti automaticamente
                //          - se CAMPOTESTO = 1 allora viene aggiunto un prefisso " e un suffisso "
                if (Esportazione.FK_TIPIESPORTAZIONE_CODICE == "CSV")
                {
                    if (dettaglio.CAMPOTESTO == "1" || pValore.IndexOf(";") > -1 || pValore.IndexOf("\"") > -1)
                        pValore = "\"" + pValore.Replace("\"", "\"\"") + "\"";

                    //se è stata scelta l'opzione CAMPOTESTO allora il valore finale deve essere ="<valore>" altrimenti non viene interpretato bene
                    if (dettaglio.CAMPOTESTO == "1")
                        pValore = "=" + pValore;

                    AppendText(pValore, dettaglio);
                    
                    //nell'ultimo dettaglio non va aggiunto il ; finale
                    if (index != alDett.Count)
                        AppendText(";", dettaglio);
                }
                else
                {
                    AppendText(pValore, dettaglio);
                }
            }
        }

        private void RunCycleTrac(List<TRACCIATI> aTrac)
        {
            //2.0 - Ciclo per tutti i tracciati dell'esportazione
            //                 (TracciatiMgr.GetList dove TRACCIATI.Id = IdEsportazione e TRACCIATI.IDCOMUNE = idcomune ordinato per OUT_ORDINE)
            //                 Per ogni tracciato
            foreach (TRACCIATI tracciato in aTrac)
            {
                //estrapolo i dettagli
                TRACCIATIDETTAGLIO td = new TRACCIATIDETTAGLIO();
                td.IDCOMUNE = tracciato.IDCOMUNE;
                td.FK_TRACCIATI_ID = tracciato.ID;
                td.OrderBy = "OUT_ORDINE ASC";

                TracciatiDettMgr tdMgr = new TracciatiDettMgr(DbExport);
                List<TRACCIATIDETTAGLIO> alDett = tdMgr.GetList(td);

                //3.0.1 - Se TRACCIATI.QUERY non è null
                if (!StringChecker.IsStringEmpty(tracciato.QUERY))
                {
                    //       3.1 - Si esegue la query TRACCIATI.QUERY dopo aver invocato il metodo _memory.replace(Query)
                    DataProviderFactory dpf = new DataProviderFactory(DataBase.Connection);
                    string pQuery = _memory.Replace(tracciato.QUERY.Replace("\r\n", " "));
                    IDbDataAdapter adapter;
                    DataSet dsTracciati = new DataSet();

                    try
                    {
                        if (Debug)
                            LogMessage(pQuery, FolderPath, IdComune);

                        IDbCommand cmd = DataBase.CreateCommand(pQuery);
                        adapter = dpf.CreateDataAdapter(cmd);
                        adapter.Fill(dsTracciati);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Errore generato durante l'esecuzione della query del tracciato " + tracciato.DESCRIZIONE + ". La query è: " + pQuery + ". Modulo: Export. Metodo: RunCycleTrac. Messaggio: " + ex.Message + "\r\n");
                    }


                    if (dsTracciati.Tables[0].Rows.Count > 0)
                    {
                        //       3.1.4 - ogni campo letto (select) si aggiunge a _memory (_memory.add)
                        foreach (DataRow drTestata in dsTracciati.Tables[0].Rows)
                        {
                            //Aggiorno il file xml
                            if ((Esportazione.FK_TIPIESPORTAZIONE_CODICE == "XML") && (tracciato.FK_TIPITRACCIATO_CODICE != "FOOTER"))
                                CreateAppFile(tracciato);

                            _memory.Add(drTestata);

                            //Aumento il campo progressivo di _memory se si tratta di un tracciato "DETAIL" (variazione)
                            //if (TypeTrc == "DETAIL")
                            if (tracciato.FK_TIPITRACCIATO_CODICE == "DETAIL")
                            {
                                _memory.ProgressivoRecord++;
                                _memory.Add("PROGRESSIVO_RECORD", _memory.ProgressivoRecord);
                            }

                            //i tracciati di tipo QUERY non hanno dettagli in quanto servono solamente a fare query e se ne possono creare infiniti.
                            if (tracciato.FK_TIPITRACCIATO_CODICE != "QUERY")
                            {
                                RunCycleDettTrac(alDett);
                            }

                            //Aggiorno il file xml
                            if ((Esportazione.FK_TIPIESPORTAZIONE_CODICE == "XML") && (tracciato.FK_TIPITRACCIATO_CODICE != "HEADER") && !string.IsNullOrEmpty(tracciato.OUT_XMLTAG))
                                CreateAppFile(tracciato.OUT_NOMEFILE);

                            //nei file CSV , qualora sia presente la query nel tracciato ciclato, il carattere di fine riga viene aggiunto solo
                            //se la query ritorna risultati
                            if (tracciato.FK_TIPITRACCIATO_CODICE != "QUERY" && Esportazione.FK_TIPIESPORTAZIONE_CODICE == "CSV")
                            {
                                AppendText("\r\n", tracciato);
                            }
                        }
                    }
                }
                else
                {
                    // se non è presente nessuna query nel tracciato e il tracciato non è configurato come QUERY
                    if (tracciato.FK_TIPITRACCIATO_CODICE != "QUERY")
                    {
                        //Aggiorno il file xml
                        if ((Esportazione.FK_TIPIESPORTAZIONE_CODICE == "XML") && (tracciato.FK_TIPITRACCIATO_CODICE != "FOOTER"))
                            CreateAppFile(tracciato);

                        RunCycleDettTrac(alDett);

                        //Aggiorno il file xml se l'esportazione è di tipo xml
                        if ((Esportazione.FK_TIPIESPORTAZIONE_CODICE == "XML") && (tracciato.FK_TIPITRACCIATO_CODICE != "HEADER") && !string.IsNullOrEmpty(tracciato.OUT_XMLTAG))
                            CreateAppFile(tracciato.OUT_NOMEFILE);

                        //ggiungo il carattere di fine riga se si tratta di un CSV
                        if (Esportazione.FK_TIPIESPORTAZIONE_CODICE == "CSV")
                        {
                            AppendText("\r\n", tracciato);
                        }
                    }
                }


            }
        }

        //Deve essere utilizzato solamente per le esportazioni di tipo XML
        private void RunSection()
        {
            RunSection(null);
        }

        private void RunSection(string sTypeTrc)
        {
            //TypeTrc = sTypeTrc;
            TRACCIATI trac = new TRACCIATI();
            try
            {
                trac.IDCOMUNE = IdComune;
                trac.FK_ESP_ID = _IdEsportazione.ToString();

                if (!string.IsNullOrEmpty(sTypeTrc))
                {
                    if (sTypeTrc == "DETAIL" || sTypeTrc == "QUERY")
                        trac.OthersWhereClause.Add("FK_TIPITRACCIATO_CODICE IN ('DETAIL','QUERY')");
                    else
                        trac.FK_TIPITRACCIATO_CODICE = sTypeTrc;
                }
                

                trac.OrderBy = "OUT_ORDINE ASC";

                TracciatiMgr trMgr = new TracciatiMgr(DbExport);
                List<TRACCIATI> al = trMgr.GetList(trac);

                RunCycleTrac(al);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore generato durante l'elaborazione di un tracciato di tipo: " + sTypeTrc + " .Modulo: Export. Metodo: RunSection. Messaggio: " + ex.Message + "\r\n");
            }
        }

        public byte[] Run(string xmlText)
        {
            byte[] arByte;
            try
            {
                sDateTime = DateTime.Now.Ticks.ToString();
                FolderPath = FolderPath + IdComune + "_" + sDateTime + "\\";
                fm.FolderPath = FolderPath;

                //Salvataggio del file di input
                if (!string.IsNullOrEmpty(xmlText))
                {
                    CreateDirectory();
                    FileStream fileInput = new FileStream(FolderPath + "Input.log", FileMode.Create, FileAccess.ReadWrite);
                    StreamUtils.BulkTransfer(StreamUtils.StringToStream(xmlText), fileInput);
                    fileInput.Close();
                }

                //1.0 - Ciclo per gli elementi del file XML
                //      (si utilizza il dataset tornato da XmlParser.Parse)
                XMLParser xmlP = new XMLParser();

                xmlP.XmlSchema = Esportazione.INPUT_XSD;
                xmlP.XmlText = xmlText;

                DataSet ds = xmlP.Parse();

                CreateDirectory();
                LogMessage("Creazione file zip e relativo byte array iniziata!", FolderPath, IdComune);

                //Vengono caricati nell'oggetto memory gli eventuali parametri dell'esportazione
                //e si aggiunge il primo elemento del dataset a _memory
                MemoryInitialize(ds);

                if (Debug)
                    LogMessage("Sono stati passati " + ds.Tables[0].Rows.Count.ToString() + " elementi da analizzare", FolderPath, IdComune);

                //Oggetto usato per conservare i dati derivanti dall'intestazione
                if (Esportazione.FK_TIPIESPORTAZIONE_CODICE != "XML")
                {
                    RunSection("HEADER");
                }


                //1.2 - Viene creato un file per ogni nome file presente in ESPORTAZIONI.OUT_NOMEFILE e TRACCIATI.OUT_NOMEFILE (Select OUT_NOMEFILE From ESPORTAZIONI Where ID=x UNION Select OUT_NOMEFILE From TRACCIATI Where FK_ESP_ID=x Group By OUT_NOMEFILE)
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (Debug)
                        LogMessage("Codice: " + dr["CODICE"].ToString(), FolderPath, IdComune);

                    //Verifico se l'esportazione è stata configurata per poter annullare tutti i dati (tranne quelli di input)
                    //al termine di ogni pratica
                    if (Esportazione.ANNULLA_DATI == "1")
                        MemoryInitialize(ds);

                    //1.2.1 - ogni elemento del dataset si aggiunge a _memory
                    _memory.Add(dr);

                    //Nuove modifiche per creare file XML
                    switch (Esportazione.FK_TIPIESPORTAZIONE_CODICE)
                    {
                        case "XML":
                            {
                                //nel caso di xml, tutti i tracciati vengono ciclati per ogni record passato anche quelli "HEADER" e "FOOTER"
                                RunSection();
                                break;
                            }
                        default:
                            {
                                RunSection("DETAIL");
                                break;
                            }
                    }

                }

                //Verifico se l'esportazione è stata configurata per poter annullare tutti i dati (tranne quelli di input)
                //al termine di ogni pratica
                if (Esportazione.ANNULLA_DATI == "1")
                    MemoryInitialize(ds);

                //Numero totale delle pratiche da elaborare
                //_memory.RecordCount = ds.Tables[0].Rows.Count;
                //_memory.Add("RECORD_COUNT",_memory.RecordCount);
                if (Esportazione.FK_TIPIESPORTAZIONE_CODICE != "XML")
                    RunSection("FOOTER");

                CloseOpenFile();

                //Verifico se occorre zippare
                if (Zip)
                    arByte = CreateZip(fm);
                else
                    arByte = fm.CreateByteArray(Esportazione.OUT_NOMEFILE);

                if ((!string.IsNullOrEmpty(MailDestinatario)))
                {
                    if (Debug)
                        LogMessage("Preparazione e invio della mail contenente l'esportazione", FolderPath, IdComune);
                    //Invio per mail il risultato dell'esportazione
                    SendMail(arByte);
                }

                LogMessage("Creazione file zip e relativo byte array terminata con successo!", FolderPath, IdComune);
            }
            catch (Exception ex)
            {
                LogMessage("Creazione file zip e relativo byte array terminata con errore! " + ex.Message, FolderPath, IdComune);
                throw ex;
            }

            return arByte;
        }

        private void MemoryInitialize(DataSet ds)
        {
            _memory = new MemorySpace();

            //Vengono caricati nell'oggetto memory gli eventuali parametri dell'esportazione
            if (ParametriCollection != null)
            {
                foreach (Parametro elem in ParametriCollection)
                {
                    _memory.Add(elem.NOME, elem.VALORE);
                }
            }

            //1.1 - si aggiunge il primo elemento del dataset a _memory
            //TODO: ds.Tables[0].Rows potrebbe non avere righe
            if( ds != null && ds.Tables[0].Rows.Count > 0 )
                _memory.Add(ds.Tables[0].Rows[0]);
        }

        private void SendMail(byte[] arByte)
        {
            #region 1 Messaggio

            SIGeProMailMessage message = new SIGeProMailMessage();
            message.CorpoMail = "In allegato trova il file .zip dell'esportazione";
            message.Destinatari = MailDestinatario;
            message.Oggetto = "Esportazione: " + Esportazione.DESCRIZIONE;

            #endregion

            #region 2. Attachments

            BinaryObject obj = new BinaryObject();

            obj.FileContent = arByte;
            obj.FileName = IdComune + "_" + sDateTime + ".zip";
            message.Attachments = new BinaryObject[1];
            message.Attachments[0] = obj;

            #endregion

            #region 3. Invio

            string webServiceUrl = WebServiceMail;
            SmtpMailSender SMTPms = new SmtpMailSender();
            SMTPms.Url = webServiceUrl;
            SMTPms.Send(_Token, "TT", message);

            #endregion
        }

        private void AppendText(string pValore, TRACCIATI tracciato)
        {
            fm.AppendTxt(GetFileName(tracciato), pValore);
        }

        private void AppendText(string pValore, TRACCIATIDETTAGLIO dettaglio)
        {
            if (dettaglio != null)
                pValore = PadValue(pValore, Convert.ToInt32(dettaglio.LUNGHEZZA));

            try
            {
                switch (Esportazione.FK_TIPIESPORTAZIONE_CODICE)
                {
                    case "XML":
                        {
                            fm.AppendXml(GetFileName(dettaglio.FK_TRACCIATI_ID_001), string.IsNullOrEmpty(dettaglio.OUT_XMLTAG) ? dettaglio.OUT_XMLTAG : ReplaceSpace(dettaglio.OUT_XMLTAG), pValore);
                            break;
                        }
                    default:
                        {
                            //3.2.1.4.3.2 - Si apre in append il file TRACCIATI.OUT_NOMEFILE (o ESPORTAZIONI.OUTNOMEFILE) e si scrive il valore calcolato dal passo 3.2.1.4.2
                            //fm.Append(GetFileName(tracciato),pValore);
                            fm.AppendTxt(GetFileName(dettaglio.FK_TRACCIATI_ID_001), pValore);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errore generato durante la scrittura del file di tipo " + Esportazione.FK_TIPIESPORTAZIONE_CODICE + ". Modulo: Export. Metodo: CreateAppFile. Messaggio: " + ex.Message + "\r\n");
            }
        }

        private void CreateAppFile(TRACCIATI tracciato)
        {
            try
            {
                fm.CreateAppendXml(GetFileName(tracciato), string.IsNullOrEmpty(Esportazione.OUT_XMLTAG) ? Esportazione.OUT_XMLTAG : ReplaceSpace(Esportazione.OUT_XMLTAG.Trim()), string.IsNullOrEmpty(tracciato.OUT_XMLTAG) ? tracciato.OUT_XMLTAG : ReplaceSpace(tracciato.OUT_XMLTAG.Trim()));
            }
            catch (Exception ex)
            {
                throw new Exception("Errore generato durante la scrittura del file xml. Modulo: Export. Metodo: CreateAppFile. Messaggio: " + ex.Message + "\r\n");
            }
        }

        private void CreateAppFile(string sFileName)
        {
            try
            {
                fm.AppendXml(sFileName);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore generato durante la scrittura del file xml. Modulo: Export. Metodo: CreateAppFile. Messaggio: " + ex.Message + "\r\n");
            }
        }

        private string GetFileName(TRACCIATI tracciato)
        {
            sFileName = Esportazione.OUT_NOMEFILE;
            if ((tracciato.OUT_NOMEFILE != null) && (tracciato.OUT_NOMEFILE != ""))
                sFileName = tracciato.OUT_NOMEFILE;

            return sFileName;
        }

        private string ReplaceSpace(string sValue)
        {
            return sValue.Replace(" ", "_");
        }

        public void CloseOpenFile()
        {
            switch (Esportazione.FK_TIPIESPORTAZIONE_CODICE)
            {

                //3.2.1.4.4 - Se ESPORTAZIONI.FK_TIPIESPORTAZIONE_CODICE="XML" 
                case "XML":
                    {
                        fm.CloseXml();
                        break;
                    }
                ////3.2.1.4.3 - Se ESPORTAZIONI.FK_TIPIESPORTAZIONE_CODICE="TXT"
                default:
                    {
                        fm.CloseTxt();
                        break;
                    }
            }
        }

        private void CreateDirectory()
        {
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);
        }

        private byte[] CreateZip(FileManager fm)
        {
            ArrayList pLstFile = fm.GetFileList("*." + Esportazione.FK_TIPIESPORTAZIONE_CODICE);

            return fm.Zip(IdComune + "_" + DateTime.Now.Ticks.ToString(), 9, pLstFile);
        }

        #endregion


        public CListaEsportazione GetListExp()
        {
            return GetListExp(null);
        }

        public CListaEsportazione GetListExp(string sContext)
        {
            CListaEsportazione pListEsportazione = new CListaEsportazione();
            EsportazioniCollection pList = new EsportazioniCollection();
            try
            {
                string cmdText = "SELECT " +
                                    "ESPORTAZIONI.ID, ESPORTAZIONI.IDCOMUNE " +
                                 "FROM " +
                                    "ESPORTAZIONI " +
                                 "WHERE " +
                                    "ESPORTAZIONI.IDCOMUNE IN ('" + IdComune + "','DEFB') AND " +
                                    "ESPORTAZIONI.FLG_ABILITATA = 1 ";

                if (!string.IsNullOrEmpty(sContext))
                {
                    cmdText += "AND ESPORTAZIONI.FK_TIPICONTESTOESP_CODICE = '" + sContext + "' ";
                }

                cmdText += "ORDER BY " +
                                    "ESPORTAZIONI.DESCRIZIONE ASC";

                using (IDbCommand cmd = DbExport.CreateCommand(cmdText))
                {
                    IDataAdapter adapter = DbExport.CreateDataAdapter(cmd);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        CEsportazione pEsportazione = GetExpDetail(dr["IDCOMUNE"].ToString(), dr["ID"].ToString());
                        pList.Add(pEsportazione);
                    }
                }

                pListEsportazione.LISTAESPORTAZIONI = pList;

                string sFileName = "ListExp_" + DateTime.Now.Ticks.ToString() + ".xml";
                Serializza(pListEsportazione, sFileName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return pListEsportazione;
        }

        public CEsportazione GetExpDetail(string idcomune, string idesportazione)
        {
            CEsportazione pEsportazione = new CEsportazione();

            try
            {

                ESPORTAZIONI esp = new EsportazioniMgr(DbExport).GetById(idcomune, idesportazione);

                pEsportazione.ID = esp.ID;
                pEsportazione.IDCOMUNE = esp.IDCOMUNE;
                pEsportazione.DESCRIZIONE = esp.DESCRIZIONE;
                pEsportazione.CONTESTO = esp.FK_TIPICONTESTOESP_CODICE;

                PARAMETRIESPORTAZIONE pParEsp = new PARAMETRIESPORTAZIONE();
                pParEsp.IDCOMUNE = pEsportazione.IDCOMUNE;
                pParEsp.FK_ESP_ID = pEsportazione.ID;
                ParametriEsportazioneMgr pParEspMgr = new ParametriEsportazioneMgr(DbExport);
                List<PARAMETRIESPORTAZIONE> pListParEsp = pParEspMgr.GetList(pParEsp);

                if (pListParEsp.Count != 0)
                    pEsportazione.LISTAPARAMETRI = new ParametriCollection();

                foreach (PARAMETRIESPORTAZIONE elem in pListParEsp)
                {
                    Parametro pParametro = new Parametro();
                    pParametro.NOME = elem.NOME;
                    pParametro.DESCRIZIONE = elem.DESCRIZIONE;
                    pEsportazione.LISTAPARAMETRI.Add(pParametro);
                }


                string sFileName = "ExpDetail_" + DateTime.Now.Ticks.ToString() + ".xml";
                Serializza(pEsportazione, sFileName);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return pEsportazione;
        }

        public CEsportazione GetExpDetail()
        {
            return GetExpDetail(Esportazione.IDCOMUNE, Esportazione.ID);
        }

        private string PadValue(string pValue, int pLength)
        {
            string retVal = pValue;

            if (pLength > 0)
            {
                if (retVal.Length > pLength)
                    retVal = retVal.Substring(0, pLength);
            }

            retVal = retVal.PadRight(pLength, Convert.ToChar(" "));

            return retVal;
        }

        private void LogMessage(string sMessageLog, string sFolder, string sIdComune)
        {
            DateTime pDt = DateTime.Now;
            string sDay = DateTime.Now.Day.ToString();
            string sMonth = DateTime.Now.Month.ToString();
            string sYear = DateTime.Now.Year.ToString();
            string sDate = pDt.ToString("G", DateTimeFormatInfo.InvariantInfo);
            //Creo una nuova istanza di un FileStream
            FileStream pFs = new FileStream(sFolder + "Log_" + sDay + "_" + sMonth + "_" + sYear + ".log", FileMode.Append, FileAccess.Write);
            //Creo una nuova istanza di un StreamWriter
            StreamWriter pSw = new StreamWriter(pFs);
            string sMessage = "[" + sDate + "]: " + " \tComune: " + sIdComune + " \tMessaggio:  " + sMessageLog;
            pSw.WriteLine(sMessage);
            //Chiudo l'istanza dello StreamWriter
            pSw.Flush();
            pSw.Close();
        }

        private void Serializza(object pExport, string sFileName)
        {
            FileStream pFs = null;
            StreamWriter sw = null;
            try
            {
                XmlSerializer pXmlSerializer = new XmlSerializer(pExport.GetType());

                if (!Directory.Exists(FolderPath))
                    Directory.CreateDirectory(FolderPath);
                pFs = new FileStream(FolderPath + sFileName, FileMode.Create, FileAccess.ReadWrite);
                sw = new StreamWriter(pFs);
                pXmlSerializer.Serialize(sw, pExport);
                pFs.Seek(0, SeekOrigin.Begin);

                //Verifico la validità del file xml
                switch (pExport.GetType().Name)
                {
                    case "CListaEsportazione":
                        ValidateXml(pFs, "ListExp.xsd");
                        break;
                    case "CEsportazione":
                        ValidateXml(pFs, "GetEsportazione.xsd");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante la serializzazione della classe " + pExport.GetType().Name + ". Metodo: Serializza, modulo: Export. " + ex.Message + "\r\n");
            }
            finally
            {
                //Già chiuso in seguito alla validazione
                if (pFs != null)
                    pFs.Close();
            }
        }

        //Codice per effettuare la validazione
        private bool b_success;
        private string sMessage = "";
        /// <summary>
        /// Metodo usato per validare il file segnatura.xml in base al file xsd
        /// </summary>
        /// <param name="pStream">File xml da validare</param>
        private void ValidateXml(FileStream pStream, string sFileName)
        {
            XmlValidatingReader vreader = null;
            try
            {
                b_success = true;
                pStream.Seek(0, SeekOrigin.Begin);
                XmlTextReader reader = new XmlTextReader(pStream);

                //Creo un validating reader.
                vreader = new XmlValidatingReader(reader);

                XmlSchemaCollection xsc = new XmlSchemaCollection();

                xsc.Add(null, SchemaPath + sFileName);
                //Valido usando lo schema conservato nello schema collection.
                vreader.Schemas.Add(xsc);

                vreader.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
                //Leggo e valido il file xml.
                while (vreader.Read()) { }
                if (!b_success)
                    throw new Exception(sMessage);
            }
            catch (Exception ex)
            {
                throw new Exception("Errore generato durante la validazione. " + ex.Message + "\r\n");
            }
            finally
            {
                //pStream.Seek(0,SeekOrigin.Begin);
                //Chiudo il reader.
                if (vreader != null)
                    vreader.Close();
            }
        }

        private void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            b_success = false;
            sMessage = "Errore di validazione: " + args.Message + "\r\n";
        }

        private bool _bZip = true;
        public bool Zip
        {
            get { return _bZip; }
            set { _bZip = value; }
        }

        private string _ente = null;
        public string Ente
        {
            get { return _ente; }
            set { _ente = value; }
        }

        private int _IdEsportazione = -1;
        public int IdEsportazione
        {
            get { return _IdEsportazione; }
            set { _IdEsportazione = value; }
        }

        private string _MailDestinatario;
        public string MailDestinatario
        {
            get { return _MailDestinatario; }
            set { _MailDestinatario = value; }
        }

        private int _CodiceResponsabile = -1;
        public int CodiceResponsabile
        {
            get { return _CodiceResponsabile; }
            set { _CodiceResponsabile = value; }
        }

        private DataBase _DbExport = null;
        public DataBase DbExport
        {
            get
            {
                if (_DbExport == null)
                {
                    ProviderType initialProviderType = (ProviderType)Enum.Parse(typeof(ProviderType), ProviderType, true);
                    _DbExport = new DataBase(ConnStringExport, initialProviderType);
                }

                return _DbExport;
            }
        }

        private DataBase _DataBase;
        public DataBase DataBase
        {
            get { return _DataBase; }
            set { _DataBase = value; }
        }

        private ESPORTAZIONI _Esportazione = new ESPORTAZIONI();
        public ESPORTAZIONI Esportazione
        {
            get
            {
                if (_IdEsportazione > -1)
                {
                    if (_Esportazione.ID != _IdEsportazione.ToString())
                    {
                        EsportazioniMgr expMgr = new EsportazioniMgr(DbExport);
                        _Esportazione = expMgr.GetById(_IdComune, _IdEsportazione.ToString());
                        if (_Esportazione == null)
                            throw new Exception("L'esportazione selezionata non esiste");
                    }
                    return _Esportazione;
                }
                else
                {
                    throw new Exception("Attenzione, Impossibile utilizzare la proprietà \"Esportazione\" se non si imposta prima \"IdEsportazione\"");
                }
            }
        }

        private string _WebServiceMail = String.Empty;
        public string WebServiceMail
        {
            get
            {
                if (string.IsNullOrEmpty(_WebServiceMail))
                    _WebServiceMail = ConfigurationManager.AppSettings["WSMAIL"];

                if (string.IsNullOrEmpty(_WebServiceMail))
                    throw new Exception("Parametro WSMAIL non presente oppure uguale ad una stringa vuota nel config!!");

                return _WebServiceMail;
            }
            set { _WebServiceMail = value; }
        }

        private string _Token = String.Empty;
        public string Token
        {
            get { return _Token; }
            set { _Token = value; }
        }

        private string _ConnStringExport = String.Empty;
        public string ConnStringExport
        {
            get
            {
                if (string.IsNullOrEmpty(_ConnStringExport))
                    _ConnStringExport = ConfigurationManager.AppSettings["CONNECTIONSTRING_CONFIG"];

                if (string.IsNullOrEmpty(_ConnStringExport))
                    throw new Exception("Parametro CONNECTIONSTRING_CONFIG non presente oppure uguale ad una stringa vuota nel config!!");

                return _ConnStringExport;
            }
            set { _ConnStringExport = value; }
        }

        private string _ProviderType = String.Empty;
        public string ProviderType
        {
            get
            {
                if (string.IsNullOrEmpty(_ProviderType))
                    _ProviderType = ConfigurationManager.AppSettings["PROVIDERTYPE_CONFIG"];

                if (string.IsNullOrEmpty(_ProviderType))
                    throw new Exception("Parametro PROVIDERTYPE_CONFIG non presente oppure uguale ad una stringa vuota nel config!!");

                return _ProviderType;
            }
            set { _ProviderType = value; }
        }

        private string _IdComune = String.Empty;
        public string IdComune
        {
            get { return _IdComune; }
            set { _IdComune = value; }
        }

        private string sFolderPath = String.Empty;
        public string FolderPath
        {
            get
            {
                if (string.IsNullOrEmpty(sFolderPath))
                    sFolderPath = HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["FILE_PATH"]);

                if (string.IsNullOrEmpty(sFolderPath))
                    throw new Exception("Parametro FILE_PATH non presente oppure uguale ad una stringa vuota nel config!!");
                else
                {
                    if (!sFolderPath.EndsWith(@"\"))
                        sFolderPath += @"\";
                }


                return sFolderPath;
            }
            set { sFolderPath = value; }
        }

        private string sSchemaPath = String.Empty;
        public string SchemaPath
        {
            get
            {
                if (string.IsNullOrEmpty(sSchemaPath))
                    sSchemaPath = HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["SCHEMA_PATH"]);

                if (string.IsNullOrEmpty(sSchemaPath))
                    throw new Exception("Parametro SCHEMA_PATH non presente oppure uguale ad una stringa vuota nel config!!");
                else
                {
                    if (!sSchemaPath.EndsWith(@"\"))
                        sSchemaPath += @"\";
                }


                return sSchemaPath;
            }
            set { sSchemaPath = value; }
        }

        private ParametriCollection pParColl = null;
        public ParametriCollection ParametriCollection
        {
            get { return pParColl; }
            set { pParColl = value; }
        }

        private bool bDebug = false;
        public bool Debug
        {
            get { return bDebug; }
            set { bDebug = value; }
        }

        public void Dispose()
        {
            if (_DataBase != null)
                DataBase.Dispose();
            if (_DbExport != null)
                DbExport.Dispose();
            if (_memory.Count != 0)
                _memory.Clear();
            if ((fm.TXT.pLstFile.Count != 0) || (fm.XML.pLstFile.Count != 0))
                CloseOpenFile();
        }

    }
}
