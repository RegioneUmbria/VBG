package com.paevolution.appioproducer.ws.client.model;
/*
 * AppIOGateway API Connettore ad IO Italia
 *
 * The version of the OpenAPI document: v0.0.1
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech Do not edit the class manually.
 */

import java.util.Objects;

import javax.validation.constraints.Null;

import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;

import io.swagger.annotations.ApiModelProperty;

/**
 * CreatedMessageResponse
 */
@JsonPropertyOrder({ CreatedMessageResponse.JSON_PROPERTY_MESSAGE_ID })
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-03-18T11:12:23.623+01:00[Europe/Berlin]")
public class CreatedMessageResponse {

    public static final String JSON_PROPERTY_MESSAGE_ID = "message_id";
    private String messageId;

    public CreatedMessageResponse messageId(String messageId) {

	this.messageId = messageId;
	return this;
    }

    /**
     * L&#39;identificativo univoco del messaggio creato.
     * 
     * @return messageId
     **/
    @Null
    @ApiModelProperty(value = "L'identificativo univoco del messaggio creato.")
    @JsonProperty(JSON_PROPERTY_MESSAGE_ID)
    @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
    public String getMessageId() {

	return messageId;
    }

    public void setMessageId(String messageId) {

	this.messageId = messageId;
    }

    @Override
    public boolean equals(java.lang.Object o) {

	if (this == o) {
	    return true;
	}
	if (o == null || getClass() != o.getClass()) {
	    return false;
	}
	CreatedMessageResponse createdMessageResponse = (CreatedMessageResponse) o;
	return Objects.equals(this.messageId, createdMessageResponse.messageId);
    }

    @Override
    public int hashCode() {

	return Objects.hash(messageId);
    }

    @Override
    public String toString() {

	StringBuilder sb = new StringBuilder();
	sb.append("class CreatedMessageResponse {\n");
	sb.append("    messageId: ").append(toIndentedString(messageId)).append("\n");
	sb.append("}");
	return sb.toString();
    }

    /**
     * Convert the given object to string with each line indented by 4 spaces (except the first line).
     */
    private String toIndentedString(java.lang.Object o) {

	if (o == null) {
	    return "null";
	}
	return o.toString().replace("\n", "\n    ");
    }
}
