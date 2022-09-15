package com.amdocs.controller;

import java.util.List;

import com.amdocs.model.Product;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;
import com.amdocs.service.ProductService;

@RestController
@RequestMapping("/api")
public class ProductController {
    @Autowired
    ProductService productService;

    @GetMapping("/product")
    private List<Product> getAllProduct() {

        return productService.getAllProduct();
    }

    @GetMapping("/product/{id}")
    private Product getProduct(@PathVariable("id") int id) {
        return productService.getProductById(id);
    }

    @DeleteMapping("/product/{id}")
    private void deleteProduct(@PathVariable("id") int id) {
        productService.delete(id);
    }

    @PostMapping("/product")
    private int saveProduct(@RequestBody Product product) {
        productService.saveOrUpdate(product);
        return product.getId();
    }
}
