﻿using Application.Interfaces;
using AutoMapper.Internal.Mappers;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class ProductRepository: IProductRepository
{
    private readonly ProductDBContext _productDbContext;
    public ProductRepository(ProductDBContext productDbContext)
    {
        _productDbContext = productDbContext;
    }
    public List<Box> GetAllBoxes()
    {
        return _productDbContext.BoxTable.ToList();
    }

    public Box CreateNewProduct(Box box)
    {
        _productDbContext.BoxTable.Add(box);
        _productDbContext.SaveChanges();
        return box; 
    }
    public Box DeleteProduct(int boxId)
    {
        Box boxToRemove = _productDbContext.BoxTable.Find(boxId);
        if (boxToRemove == null)
            return null;
            
        _productDbContext.BoxTable.Remove(boxToRemove);
        _productDbContext.SaveChanges();
        
        return null; 
    }
    public Box EditProduct(Box box)
    {
        Box boxToEdit = _productDbContext.BoxTable.Find(box.Id);
        if (boxToEdit == null)
            return null;
        

        _productDbContext.BoxTable.Update(box);
        _productDbContext.SaveChanges();
        return box;
    }

    public void CreateDb()
    {
        _productDbContext.Database.EnsureDeleted();
        _productDbContext.Database.EnsureCreated();

    }

    public BoxType CreateBoxType(BoxType boxType)
    {
        _productDbContext.BoxTypeTable.Add(boxType);
        _productDbContext.SaveChanges();
        return boxType;

    }

    public List<BoxType> GetAllBoxTypes()
    {
        return _productDbContext.BoxTypeTable.ToList();
    }

    public void UpdateBox(Box box)
    {
        var existingBox = _productDbContext.BoxTable.Where(b => b.Id == box.Id);
        if (existingBox==null)
            return;
            _productDbContext.Update(box);
        _productDbContext.SaveChanges();
    }
}
