﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Init.SIGePro.Protocollo.DocEr.Verticalizzazioni;
using Init.SIGePro.Protocollo.DocEr.Autenticazione;
using Init.SIGePro.Protocollo.ProtocolloInterfaces;
using Init.SIGePro.Protocollo.Logs;
using Init.SIGePro.Protocollo.Serialize;
using Init.SIGePro.Protocollo.ProtocolloServices;

namespace Init.SIGePro.Protocollo.DocEr.ProtocollazioneRegistrazione.Protocollazione
{
    public class Protocollazione : BaseProtocollazioneRegistrazione
    {
        ProtocollazioneService _protocollazioneWrapper;

        public long IdUnitaDocumentale { get; private set; }

        public Protocollazione(ProtocollazioneService protocollazioneWrapper, VerticalizzazioniConfiguration vert, IAuthenticationService authWrapper, IDatiProtocollo datiProto, ProtocolloLogs logs, ProtocolloSerializer serializer, ResolveDatiProtocollazioneService datiProtoSrv)
            : base(vert, authWrapper, datiProto, logs, serializer, datiProtoSrv)
        {
            _protocollazioneWrapper = protocollazioneWrapper;
        }

        public esito Protocolla()
        {
            IdUnitaDocumentale = CreaUnitaDocumentale();
            string segnatura = CreaSegnatura();

            var response = _protocollazioneWrapper.Protocollazione(AuthWrapper.Token, IdUnitaDocumentale, segnatura);
            return response;
        }
    }
}
