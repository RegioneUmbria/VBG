ALTER TABLE SERVIZI MODIFY CODICECOMUNE VARCHAR2(6 BYTE);
ALTER TABLE SERVIZI MODIFY SOFTWARE VARCHAR2(2 BYTE);
ALTER TABLE MESSAGGI ADD IDENTIFICATIVO_SERVIZIO VARCHAR2(50 BYTE) NOT NULL ENABLE;
ALTER TABLE MESSAGGI MODIFY CODICECOMUNE VARCHAR2(6 BYTE);
ALTER TABLE MESSAGGI MODIFY SOFTWARE VARCHAR2(2 BYTE);
DROP INDEX IDX_SERVIZI_01;
ALTER TABLE SERVIZI DROP CONSTRAINT UKDOA63WLB8QPNVK6YUCGOSQIWS;
ALTER TABLE MESSAGGI DROP COLUMN CODICECOMUNE;
ALTER TABLE MESSAGGI DROP COLUMN SOFTWARE;
ALTER TABLE SERVIZI DROP COLUMN CODICECOMUNE;
ALTER TABLE SERVIZI DROP COLUMN SOFTWARE;
