package com.amdocs.model;

import javax.persistence.*;

@Entity
@Table
public class Product {
    @Id
    @Column
    @GeneratedValue
    private int id;
    @Column
    //  @Column(nullable = false,length = 30)
    private String name;
    @Column
    private double price;
    @Column
    private String description;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }
}