package com.paevolution.appioproducer.core.repository.helper;

import org.apache.commons.lang3.StringUtils;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Component;

import lombok.extern.slf4j.Slf4j;

@Component
@Slf4j
public class MessageToSendQueryHelper {

    private static final String ORACLE = "oracle";
    private static final String MYSQL = "mysql";
    @Value("${spring.datasource.driver-class-name}")
    private String driverClassName;

    ///
    ///
    private String selectQueryMessageToSend() {

	return "SELECT " + "ISTANZE.IDCOMUNE," + "ISTANZE.CODICECOMUNE," + "ISTANZE.SOFTWARE," + "ISTANZE.CODICEISTANZA,"
		+ "STATIISTANZA.FKCODCOMPORTAMENTO AS CODICESTATO," + "ISTANZE.NUMEROPROTOCOLLO," + "ISTANZE.DATAPROTOCOLLO,"
		+ "ISTANZE.NUMEROISTANZA," + "ISTANZE.DATA," + "ISTANZE.LAVORI," + "CONFIGURAZIONE.DENOMINAZIONE AS DENOMINAZIONE_SERVIZIO,"
		+ "CONFIGURAZIONE_APP_IO.URL_PORTALE_SERVIZI," + "TRIM(DESTINATARIO.NOMINATIVO || ' ' || DESTINATARIO.NOME) AS DESTINATARIO,"
		+ "DESTINATARIO.CODICEANAGRAFE AS DESTINATARIO_CODICEANAGRAFE," + "DESTINATARIO.CODICEFISCALE AS DESTINATARIO_CODICEFISCALE,"
		+ "MOVIMENTI.CODICEMOVIMENTO," + "MOVIMENTI.MOVIMENTO " + "FROM " + "MOVIMENTI " + "   INNER JOIN ISTANZE ON "
		+ "        MOVIMENTI.IDCOMUNE = ISTANZE.IDCOMUNE AND MOVIMENTI.CODICEISTANZA = ISTANZE.CODICEISTANZA "
		+ "   INNER JOIN STATIISTANZA ON "
		+ "        ISTANZE.IDCOMUNE = STATIISTANZA.IDCOMUNE AND ISTANZE.SOFTWARE = STATIISTANZA.SOFTWARE AND ISTANZE.CHIUSURA = STATIISTANZA.CODICESTATO "
		+ "   INNER JOIN ANAGRAFE DESTINATARIO ON "
		+ "        ISTANZE.IDCOMUNE = DESTINATARIO.IDCOMUNE AND ISTANZE.CODICERICHIEDENTE = DESTINATARIO.CODICEANAGRAFE AND DESTINATARIO.TIPOANAGRAFE = 'F' "
		+ "   INNER JOIN CONFIGURAZIONE_APP_IO ON "
		+ "        ISTANZE.IDCOMUNE = CONFIGURAZIONE_APP_IO.IDCOMUNE AND ISTANZE.CODICECOMUNE = CONFIGURAZIONE_APP_IO.CODICECOMUNE AND ISTANZE.SOFTWARE = CONFIGURAZIONE_APP_IO.SOFTWARE "
		+ "   LEFT  JOIN CONFIGURAZIONE ON "
		+ "        ISTANZE.IDCOMUNE = CONFIGURAZIONE.IDCOMUNE AND ISTANZE.SOFTWARE = CONFIGURAZIONE.SOFTWARE "
		+ "   LEFT  JOIN MOVIMENTI_IO_COMUNICAZIONI ON " + "        ISTANZE.IDCOMUNE = MOVIMENTI_IO_COMUNICAZIONI.IDCOMUNE AND "
		+ "        ISTANZE.CODICECOMUNE = MOVIMENTI_IO_COMUNICAZIONI.CODICECOMUNE AND "
		+ "        ISTANZE.SOFTWARE = MOVIMENTI_IO_COMUNICAZIONI.SOFTWARE  AND "
		+ "        MOVIMENTI.CODICEMOVIMENTO = MOVIMENTI_IO_COMUNICAZIONI.CODICEMOVIMENTO AND "
		+ "        ISTANZE.CODICERICHIEDENTE = MOVIMENTI_IO_COMUNICAZIONI.CODICEANAGRAFE " + "WHERE "
		+ "MOVIMENTI_IO_COMUNICAZIONI.MESSAGE_ID IS NULL AND " + "MOVIMENTI.PUBBLICA = 1 AND "
		+ compareWithSYSDATEQuery("MOVIMENTI.DATAPROTOCOLLO") + "UNION " + "SELECT " + "ISTANZE.IDCOMUNE, " + " ISTANZE.CODICECOMUNE,"
		+ "ISTANZE.SOFTWARE," + "ISTANZE.CODICEISTANZA," + "STATIISTANZA.FKCODCOMPORTAMENTO AS CODICESTATO," + "ISTANZE.NUMEROPROTOCOLLO,"
		+ "ISTANZE.DATAPROTOCOLLO," + "ISTANZE.NUMEROISTANZA," + "ISTANZE.DATA," + "ISTANZE.LAVORI,"
		+ "CONFIGURAZIONE.DENOMINAZIONE AS DENOMINAZIONE_SERVIZIO," + "CONFIGURAZIONE_APP_IO.URL_PORTALE_SERVIZI,"
		+ "TRIM(DESTINATARIO.NOMINATIVO || ' ' || DESTINATARIO.NOME) AS DESTINATARIO,"
		+ "DESTINATARIO.CODICEANAGRAFE AS DESTINATARIO_CODICEANAGRAFE," + "DESTINATARIO.CODICEFISCALE AS DESTINATARIO_CODICEFISCALE,"
		+ "MOVIMENTI.CODICEMOVIMENTO," + "MOVIMENTI.MOVIMENTO " + "FROM " + "MOVIMENTI " + "   INNER JOIN ISTANZE ON "
		+ "        MOVIMENTI.IDCOMUNE = ISTANZE.IDCOMUNE AND MOVIMENTI.CODICEISTANZA = ISTANZE.CODICEISTANZA "
		+ "   INNER JOIN STATIISTANZA ON "
		+ "        ISTANZE.IDCOMUNE = STATIISTANZA.IDCOMUNE AND ISTANZE.SOFTWARE = STATIISTANZA.SOFTWARE AND ISTANZE.CHIUSURA = STATIISTANZA.CODICESTATO "
		+ "   INNER JOIN ANAGRAFE DESTINATARIO ON "
		+ "        ISTANZE.IDCOMUNE = DESTINATARIO.IDCOMUNE AND ISTANZE.CODICEPROFESSIONISTA = DESTINATARIO.CODICEANAGRAFE AND DESTINATARIO.TIPOANAGRAFE = 'F' "
		+ "   INNER JOIN CONFIGURAZIONE_APP_IO ON "
		+ "        ISTANZE.IDCOMUNE = CONFIGURAZIONE_APP_IO.IDCOMUNE AND ISTANZE.CODICECOMUNE = CONFIGURAZIONE_APP_IO.CODICECOMUNE AND ISTANZE.SOFTWARE = CONFIGURAZIONE_APP_IO.SOFTWARE "
		+ "   LEFT  JOIN CONFIGURAZIONE ON "
		+ "        ISTANZE.IDCOMUNE = CONFIGURAZIONE.IDCOMUNE AND ISTANZE.SOFTWARE = CONFIGURAZIONE.SOFTWARE "
		+ "   LEFT  JOIN MOVIMENTI_IO_COMUNICAZIONI ON " + "        ISTANZE.IDCOMUNE = MOVIMENTI_IO_COMUNICAZIONI.IDCOMUNE AND "
		+ "        ISTANZE.CODICECOMUNE = MOVIMENTI_IO_COMUNICAZIONI.CODICECOMUNE AND "
		+ "        ISTANZE.SOFTWARE = MOVIMENTI_IO_COMUNICAZIONI.SOFTWARE  AND "
		+ "        MOVIMENTI.CODICEMOVIMENTO = MOVIMENTI_IO_COMUNICAZIONI.CODICEMOVIMENTO AND "
		+ "        ISTANZE.CODICEPROFESSIONISTA = MOVIMENTI_IO_COMUNICAZIONI.CODICEANAGRAFE " + "WHERE "
		+ "MOVIMENTI_IO_COMUNICAZIONI.MESSAGE_ID IS NULL AND " + "MOVIMENTI.PUBBLICA = 1 AND "
		+ compareWithSYSDATEQuery("MOVIMENTI.DATAPROTOCOLLO");
    }

    ///+ "TRUNC(MOVIMENTI.DATAPROTOCOLLO) = TRUNC(SYSDATE) ";
    private String selectQueryMessageToSend2 = "SELECT " + "ISTANZE.IDCOMUNE," + "ISTANZE.CODICECOMUNE," + "ISTANZE.SOFTWARE,"
	    + "ISTANZE.CODICEISTANZA," + "ISTANZE.FOGLIO AS CODICESTATO," + "ISTANZE.NUMEROPROTOCOLLO," + "ISTANZE.DATAPROTOCOLLO,"
	    + "ISTANZE.NUMEROISTANZA," + "ISTANZE.DATA," + "ISTANZE.LAVORI," + "ISTANZE.PARTICELLA AS DENOMINAZIONE_SERVIZIO," + "ISTANZE.SUB,"
	    + "ISTANZE.CODICESETTORE AS DESTINATARIO," + "ISTANZE.CODICERICHIEDENTE AS DESTINATARIO_CODICEANAGRAFE,"
	    + "ISTANZE.CODICEATTIVITA AS DESTINATARIO_CODICEFISCALE," + "ISTANZE.PROGREGAUT," + "ISTANZE.CIVICO " + "FROM " + "ISTANZE " + "WHERE "
	    + "IDCOMUNE='E256' AND SOFTWARE='SS' AND CODICERICHIEDENTE=96";

    public String buildQuery() {

	StringBuffer sql = new StringBuffer();
	sql = sql.append(selectQueryMessageToSend());
	return sql.toString();
    }

    private String compareWithSYSDATEQuery(String date) {

	StringBuilder builder = new StringBuilder();
	if (StringUtils.contains(this.driverClassName, ORACLE)) {
	    builder = builder.append("TRUNC(").append(date).append(") = TRUNC(SYSDATE) ");
	    log.debug("compareWithSYSDateQuery# Oracle Database TRUNC() and SYSDATE functions: {}", new String(builder));
	} else if (StringUtils.contains(this.driverClassName, MYSQL)) {
	    builder = builder.append("DATE(").append(date).append(") = DATE(SYSDATE()) ");
	    log.debug("compareWithSYSDateQuery# MySQL Database DATE() and SYS() functions: {}", new String(builder));
	}
	return new String(builder);
    }
}
