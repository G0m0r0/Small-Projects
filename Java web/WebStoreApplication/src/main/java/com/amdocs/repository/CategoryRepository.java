package com.amdocs.repository;
import com.amdocs.model.Category;
import org.springframework.data.repository.CrudRepository;

public interface CategoryRepository extends CrudRepository<Category, Integer>
{
}