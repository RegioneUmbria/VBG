# Changelog

## VNEXT

### Backoffice

### Area riservata

### Nodo pagamenti

- Integrazione con Easy Bridge (Progetti e Soluzioni)

-----

## 2.110

### 2.110 Backoffice

- Adeguamenti CDS su funzionalità Commissioni Conferenze
   [(documentazione)](../configurazione/commissioni-conferenze/README.md)

- Ottimizzazioni Bollettazione. La funzionalità Bollettazione è stata rivista per ottimizzare le fasi di visualizzazione interfaccia inserimento dati.

- Aggiunto manuale installazione / utilizzo del Configuratore Calcoli
   [(Installazione)](../configurazione/configuratore-calcoli/guida-aggiornamento/2.110/README.md)
   [(Manuale d'uso)](../configurazione/configuratore-calcoli/README.md)

### 2.110 .net

- Area riservata
  - Integrazione con SIT Eagle
- Backoffice
  - Possibilità di utilizzare servizi iniettati nelle formule (a patto che il servizio sia registrato)

### 2.110 App Ambulanti

- Possibilità di aggiornare lo stato pagamenti
- Possibilità di scaricare la ricevuta di un pagamento (se il connettore lo supporta)

## 2.109

### 2.109 Backoffice

- Integrazione con gestionale esterno per la gestione delle determine
   [(documentazione)](../configurazione/integrazione-gestionale-atti/README.md)
- Causali oneri - Integrazione nodo pagamenti gestione del parametro **codice tassonomia**

### 2.109 Nodo pagamenti

- Integrazione JCITY.Gov di Maggioli [(documentazione)](../configurazione/nodo-pagamenti/J-cityGov.md)
- Connettore SILFI Pagamenti OTF Modello 1 lato frontend
- Connettore PayER gestione codice tassonomia Modello 1

## 2.108

### 2.108 Backoffice

- Amministrazioni collegate
  [(documentazione)](../configurazione/amministrazioni/README.md)
- Modifica a notifica STC automatica (modifica per pratiche Dichiarazione Conformità - **DICO**)

  Aggiunti flag per creazione zip logico con i documenti della pratica, per protocollare o meno i documenti, e per sovrascrivere il destinatario della protocollazione
  [(documentazione)](../configurazione/funzionalita-trasversali/gestione-domande-dico.md)

## 2.107

### 2.107 Backoffice

- **SCADENZARIO OPERATORI**: nuova sezione *"ONERI"*

- Protocollo URBI: implementazione metodo fascicolazione
     [(documentazione)](../configurazione/protocollazione/urbi.md)

## 2.106

### 2.106 Backoffice

- Accesso agli atti: possibilità di associare pratiche di altri moduli software
- Integrazione protocollo **IT@LSOFT**
     [(documentazione)](../configurazione/protocollazione/italsoft.md)

### Area riservata/Backend ASP.NET

- Consultare la [Guida all'aggiornamento dell'area riservata](../configurazione/area-riservata/guida-aggiornamento/) per aggiornare alla versione 2.106

## 2.105

### 2.105 Backoffice

- Integrazione con i servizi di protocollazione sviluppati da Kibernetes
     [(documentazione)](../configurazione/protocollazione/kibernetes.md)

### 2.105 Area riservata

- Visualizzazione dei documenti dei movimenti nell'accesso agli atti [(documentazione)](../configurazione/accesso-agli-atti/)

## 2.104

### 2.104 Backoffice

- Integrazione con i servizi di protocollazione sviluppati da E-Lios
     [(documentazione)](../configurazione/protocollazione/elios.md)
- Aggiunta la possibilità di trasformare in PDF gli allegati passati al protocollo tramite il parametro [(TRASFORMA_IN_PDF)](../configurazione/protocollazione/protocollo_attivo.md)
- Aggiunta la possibilità di indicare quali tipologie di file vanno protocollate in base all'estensione tramite il parametro [(ESTENSIONI_AMMESSE)](../configurazione/protocollazione/protocollo_attivo.md)

## 2.103

### 2.103 Backoffice

- Funzionalità per gestione calcolo coefficienti concorsi
- Accesso agli atti: gestione dei documenti con dati sensibili
 [(documentazione)](../configurazione/accesso-agli-atti/README.md)

### 2.103 Area riservata

- Accesso agli atti: gestione dei documenti con dati sensibili. Non saranno visualizzabili i documenti contrassegnati nel back cone "Dato sensibile"
 [(documentazione)](../configurazione/accesso-agli-atti/README.md)
- Accesso agli atti: visualizzazione dei movimenti e dei relativi files
 [(documentazione)](../configurazione/accesso-agli-atti/README.md)

## 2.102

### 2.102 Backoffice

- Funzionalità per la verifica degli esiti tornati da Anagrafe tributaria
  [(documentazione)](../configurazione/anagrafe-tributaria/readme.md)

## 2.101

### Area riservata / Console

- Funzionalità "Paga dopo" su integrazioni pagamenti [(documentazione)](../configurazione/area-riservata/presentazione-domanda/pagamenti/nodo-pagamenti/README.md)

## 2.100

### 2.100 Backoffice

- Bollettazione gestione delle ricevute di ritorno per le comunicazioni massive
- Lettura casella MAIL da folder differente da INBOX
  Gestita tramite nuovo parametro verticalizzazioni **NLA-RICEZIONE-PEC.CARTELLA-MAIL**

### 2.100 Area riservata

- Integrazione Con SIT ACI Emilia Romagna

### 2.100 Nodo pagamenti

- Integrazione OpenWeb - PagoPa di Dedagroup
  [(documentazione)](../configurazione/nodo-pagamenti/open-web.md)

## 2.99

### 2.99 Backoffice

- Rielaborazione massiva delle schede dinamiche
- Modifiche a integrazione RFC63 autenticazione con certificato
- Ottimizzazioni pagina elaborazione istanza

## 2.98

### 2.98 Backoffice

- Rubrica indirizzario per funzionalità invio mail dai movimenti
  [(documentazione)](../configurazione/gestione-istanze/movimenti/invio-mail.md)
- FVG SUAP IN RETE gestione della nuova struttura DatiCAtastaliFT
- Esportazioni Pentaho Export generico delle pratiche con i dati delle schede dinamiche
- Connettore SPID Spid Gateway Solution di Progetti e Soluzioni
  [(documentazione)](../configurazione/SPID/connettori/spid-gateway-solution.md)

## 2.97

### 2.97 Backoffice

- Evolutiva nell'integrazione col protocollo JIride: è possibile attivare tale protocollo anche come protocollo storico
     [(documentazione)](../configurazione/protocollazione/jiride.md)

### 2.97 Area riservata

- Gestione commissioni: [(documentazione)](../configurazione/area-riservata/commissioni-conferenze/README.md)

  - Un parere può essere espresso una sola volta per ciascuna - pratica
  - Protocollazione dei pareri espressi sulla pratica
  - Accesso alle commissioni tramite PIN

- Intestatario posizione debitoria

  - Quando vengono create le posizioni debitorie vengono assegnate al soggetto richiedente. È possibile tramite il parametro di verticalizzazione NODO_PAGAMENTI.SOGGETTO_PENDENZA sovrascrivere questo comportamento per associare la pendenza all'azienda. Lo stesso comportamento è stato implementato in console.

### 2.97 Nodo pagamenti

- Integrazione con FVGPAY
  [(documentazione)](../configurazione/nodo-pagamenti/fvgpay.md)

-----

## 2.96

### 2.96 Backoffice

- Evolutiva backoffice sul campo oggetto del protocollo
    [(documentazione)](../configurazione/segnaposti/segnaposto-dati-dinamici.md)
- Evoluzione Integrazione Protocollo Civilia Next
    [(documentazione)](../configurazione/protocollazione/civilianext.md)

### 2.96 Area riservata

- Evolutiva Area Riservata: step gradimento del servizio
   [(documentazione)](../configurazione/area-riservata/questionario-gradimento/)

### 2.96 Nodo pagamenti

- GOVPAY Modifica interfaccia con PagoPa per la gestione del campo "Unità operativa"
   [(documentazione)](../configurazione/nodo-pagamenti/govpay.md)

### App Ambulanti

- Evolutiva software per rendere fruibile la mappa in maniera statica all'interno della webapp dei vigili e degli spuntisti

-----

## 2.95

### 2.95 Area riservata

- Gestione etichette su campi visura
- Possibilità di visualizzare posizione archivio
  [(documentazione)](../configurazione/area-riservata/visura/README.md)

### 2.95 App vigili

- Visualizzazione mappa statica del mercato

## 2.94

### 2.94 Backoffice

- Sviluppo componente proxy per comunicazioni tra enti di installazioni differenti
  [(documentazione)](../configurazione/stc/nla-proxy/README.md)
- Commissioni e Conferenze - comunicazioni massive
  [(documentazione)](../configurazione/commissioni-conferenze/README.md#comunicazioni-massive)
- Autorizzazioni/concessioni - Gestione data anzianità [(documentazione)](../configurazione/autorizzazioni-concessioni/data-anzianita.md)

## 2.93

### 2.93 Area riservata

- Commissioni e conferenze: invio parere e verbale
  [(documentazione)](../configurazione/area-riservata/commissioni-conferenze/README.md)

## 2.92

### 2.92 Backoffice

- Evoluzione funzionalità commissioni e conferenze
  [(documentazione)](../configurazione/commissioni-conferenze/README.md)

### 2.92 Area riservata

- Funzionalità commissioni e conferenze
  [(documentazione)](../configurazione/area-riservata/commissioni-conferenze/README.md)

- Step Anagrafe: è data la possibilità di modificare le etichette dello step anagrafe (per gli utenti opportunamente configurati)

## 2.91

### 2.91 Backoffice

- Funzionalità zip logico
  [(documentazione)](../configurazione/zip%20logico/README.md)

## 2.90

### 2.90 Backoffice

- Funzionalità per spostamento pratiche massivamente da una voce dell'albero
  [(documentazione)](../configurazione/gestione-istanze/cambio-intervento-massivo/README.md)
- Firma digitale remota ARUBA, possibilità di firmare il file in modalità congiunta o parallela
  [(documentazione)](../configurazione/firma-digitale/firma-remota-aruba/README.md)

## 2.89

### 2.89 Backoffice

- Nuovo Tag MailTipo **[ALLEGATI_MOVIMENTO]** che stampa la lista dei nomi file presenti come allegati del movimento.
  Viene formattato come una lista puntata nella mail

- Gestione Obbligato in Solido in presenza di integrazione con un sistema dei pagamenti
  [(documentazione)](../configurazione/gestione-istanze/posizioni-debitorie-istanzeoneri/obbligato-in-solido/README.md)

## 2.88

### 2.88 Backoffice

- COSAP suolo pubblico e pubblicità - integrazione con Software Esatto
  [(documentazione)](../configurazione/calcolo-cosap/comune-trieste/README.md)
- Gestione movimenti: possibilità di aggiungere soggetti che possono effettuare il movimento e possibilità di far effettuare il movimento solo a quei soggetti
  [(documentazione)](../configurazione/area-riservata/movimenti-frontoffice/)
- Gestione della tabella PEOPLEPROCSPORTELLI
  [(documentazione)](../configurazione/people/README.md)
- Visura: possibilità di specificare il livello visura in base al tipo soggetto
- Possibilità di spostare voci dell'albero degli interventi da una cartella ad un altra
  [(documentazione)](../configurazione/modifica-albero-interventi/README.md)

### 2.88 Area riservata

- Gestire la visibilità e le funzionalità nella scrivania virtuale in base alla tipologia di soggetto che accede
- Modificata logica di filtro dei movimenti da fare (vedi BO)
- Modifica per campi "Multi Lista Valori"

### 2.88 Nodo pagamenti

- connettore PAGOUMBRIA
  - implementazione recupero avviso di pagamento
  - connettore pagombria implementazione generazione IUV

## 2.87

### 2.87 Backoffice

- Funzionalità **COMUNICAZIONI MASSIVE**
  integrazione delle comunicazioni massive nella Bollettazione
  [(documentazione)](../configurazione/bollettazione/comunicazioni-massive.md)

### 2.87 Area riservata

- Funzionalità "Già pagato" negli oneri integrati con nodo pagamenti
- Soggetti che possono eseguire i movimenti [(documentazione)](../configurazione/area-riservata/movimenti-frontoffice/)

### 2.87 Nodo pagamenti

- Funzionalità "Paga più tardi" per connettore PagoUmbria

## 2.86

### 2.86 Area riservata

- Gestione degli endoprocedimenti collegati
  [(documentazione)](../configurazione/area-riservata/presentazione-domanda/gestione-endoprocedimenti/README.md)

### 2.86 Backoffice

- Implementazione della webcomponent delle posizioni debitorie, possibilità di implementare il pagamento offline
  [(documentazione)](../configurazione/posizioni-debitorie/README.md)
- Aggiornamento della data di scadenza di una posizione debitoria

  È possibile, qualora il connettore specifico supporti la modifica della data di scadenza, aggiornare da interfaccia la data di scadenza di una posizione debitoria. Per modificare la data scadenza la posizione debitoria non deve essere pagata o annullata.
  [(documentazione)](../configurazione/posizioni-debitorie/README.md#modifica-data-scadenza)

- Gestione pagamenti fuori canale PAGOPA

  Possibilità di segnare le posizioni debitorie come pagate con altri mezzi rispetto PagoPA
  [(documentazione)](../configurazione/posizioni-debitorie/README.md)

- Creazione posizioni debitorie Azienda al posto del richiedente come titolare

  [(documentazione)](../configurazione/nodo-pagamenti/configurazione-nodo-pagamenti.md#configurazione-soggetto-debitore)

### 2.86 Nodo pagamenti

- Integrazione con il sistema dei pagamenti PayER nel frontoffice Modello 1
  [(documentazione)](../configurazione/nodo-pagamenti/payer.md)

## 2.85

### 2.85 Backoffice

- Gestione da interfaccia delle tabelle DECODIFICHE
  [(documentazione)](../configurazione/decodifiche/README.md)

### 2.85 Nodo Pagamenti

- Implementazione connettore nodo pagamenti Unicredit
  [(documentazione)](../configurazione/nodo-pagamenti/unicredit-easypa.md)
- Implementazione connettore nodo pagamenti GovPay
  [(documentazione)](../configurazione/nodo-pagamenti/govpay.md)

## 2.84

### 2.84 Backoffice

- Gestione affitto autorizzazioni/concessioni
  [(documentazione)](../configurazione/autorizzazioni-concessioni/README.md)
- Evolutiva smistamento pratiche complesse ricevute da Accesso Unitario
  [(documentazione)](../configurazione/accesso-unitario/smistamento-pratiche/README.md)

## 2.83

### 2.83 Area riservata

- Visualizzazione campo **Anno** e **Fabbricato** su ricerche delle **pratiche presentate**
- Nuova gestione degli url di accesso alla console per installazioni multicomune
  [(documentazione)](../configurazione/area-riservata/url-accesso-console/README.md)

### 2.83 Backoffice

- Movimenti: invio notifica via mail/PEC ad amministrazione
  [(documentazione)](../configurazione/movimenti-notifiche-mailservice/README.md)
- Gestione calcolo delle aree in base al km della localizzazione
- Integrazione con il sistema di registrazione delle ordinanze di occupazione suolo pubblico
  [(documentazione)](../configurazione/ordinanze/modena/README.md)

### 2.83 Console

- Gestione dei link specifici per comune su nuova **domanda(console)** e su **Domande in sospeso(Console)**

### 2.83 Nodo Pagamenti

- Implementazione dei servizi Sincroni nel connettore nodo pagamenti Piemonte Pay
  [(documentazione)](../configurazione/nodo-pagamenti/README.md)

## 2.82

### 2.82 Backoffice

- (.net) PROTOCOLLO_SIGEDO, cambiato l'operatore che si occupa di inserire il protocollo quando la protocollazione è automatica
- (.net) correzioni problematiche ANAGRAFE MAGGIOLI

### 2.82 Area riservata

- Fix su integrazione con nodo pagamenti
- Gestione metadati su caricamento oggetti

### 2.82 Console.net

- Fix su integrazione con nodo pagamenti

## 2.81

### 2.81 Backoffice

- Gestione della generazione debito Fattura comune di Modena
  [(documentazione)](../configurazione/calcolo-cosap/README.md)
- Controllo firma documento prima di protocollare
  [(documentazione)](../configurazione/protocollazione/protocollo_attivo.md)
- Conversione automatica dei documenti in fase di firma
  [(documentazione)](../configurazione/firma-digitale/conversione-automatica-pdf-firma.md)
- Autorizzazioni Accessi gestione delle proroghe - ripristino contatore accessi  
  Da ora è possibile ripristinare il contatore degli accessi quando viene autorizzata una proroga
- Implementazioni e verifiche Procedi Marche
  [(documentazione)](../configurazione/procedimarche/README.md)
- Forzare il documento principale firmato in fase di protocollazione ( parametro FLUSSI_VER_FIRMA_DOC_PRINC della verticalizzazione PROTOCOLLO_ATTIVO )
  [(documentazione)](../configurazione/protocollazione/protocollo_attivo.md)
- Storicizzazione degli oggetti
  [(documentazione)](../configurazione/funzionalita-trasversali/README.md)
- Posizioni debitorie da istanze oneri
  [(documentazione)](../configurazione/gestione-istanze/posizioni-debitorie-istanzeoneri/README.md)

### 2.81 Area riservata

- Moduli FVG: modificata visualizzazione del PDF di riepilogo in modo da riflettere lo stato di visualizzazione delle varie schede

## 2.80

### 2.80 Backoffice

- Gestione mercati occasionali secondo specifiche CSI Piemonte
- Implementazione nuovo calcolo importi pagamento posteggi aree mercatali 2021
- Implementazione pagamento concessionari su occupazione giornaliera delle aree mercatali
- Calcolo importi COSAP su schede dinamiche secondo specifiche CSI Piemonte (distributori carburante, concessioni stradali, mezzi pubblicitari)
- Bollettazione: Integrazione con MIP per Invio/riconciliazione
- Gestione account e-mail multicomune per le installazioni con comuni associati
- Scelta dell'account mail per le comunicazioni automatiche dai movimenti
- Adeguamento del backoffice al nuovo Accettatore Unico di Regione Toscana
- Condivisione documentale in fase di protocollazione
- Possibilità di visualizzare le pratiche con errore in base ai comuni configurati per l'operatore
- Contenuti regionali Friuli: possibilità di allineare solamente gli endoprocedimenti con i contenuti regionali

### 2.80 Area riservata

- FIX implementazione integrazione con pagamenti NEXI Bassilichi versione 3.1
- Step di benvenuto: configurazione da backend dei comuni da mostrare nella lista dei comuni associati

## Versioni precedenti alla 2.80

[Changelog delle versioni precedenti alla 2.79](../risorse/versioni-precedenti.md)