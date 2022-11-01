﻿using Domain;

namespace Application.Interfaces;

public interface IProductRepository
{
    public List<Box> GetAllBoxes();
    public Box? DeleteProduct(int boxId);
    public Box EditProduct(Box box);
    public Box CreateNewProduct(Box box);
    public void CreateDb();
    BoxType CreateBoxType(BoxType boxType);
    List<BoxType> GetAllBoxTypes();
    public Boolean IfExists(string name);
}