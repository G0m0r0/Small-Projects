package com.amdocs.repository;
import org.springframework.data.repository.CrudRepository;
import com.amdocs.model.Product;
public interface ProductRepository extends CrudRepository<Product, Integer>
{
}
