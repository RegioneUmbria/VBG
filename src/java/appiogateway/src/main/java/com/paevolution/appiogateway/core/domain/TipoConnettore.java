package com.paevolution.appiogateway.core.domain;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

import javax.persistence.CascadeType;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonBackReference;
import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import lombok.AccessLevel;
import lombok.Data;
import lombok.NoArgsConstructor;
import lombok.Setter;

@Data
@NoArgsConstructor
@Entity
@Table(name = "TIPO_CONNETTORE")
public class TipoConnettore implements Serializable {

    private static final long serialVersionUID = -667907919228486743L;
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    @Setter(AccessLevel.NONE)
    private Long id;
    @Column(name = "NOME", nullable = false, length = 200, unique = true)
    @Setter(AccessLevel.NONE)
    private String nome;
    @JsonBackReference
    @OneToMany(mappedBy = "tipoConnettore", cascade = CascadeType.ALL, orphanRemoval = true)
    @Setter(AccessLevel.NONE)
    @JsonIgnoreProperties({ "hibernateLazyInitializer", "handler" })
    private List<Servizi> servizis = new ArrayList<>();
}