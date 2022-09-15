package com.amdocs.model;

import org.springframework.stereotype.Repository;

import javax.persistence.*;

@Entity
@Table
public class Category {
    @Id
    @Column
    @GeneratedValue
    private int id;

    @Column
    // @Column(nullable = false,length = 120,unique = true)
    private String name;
}
