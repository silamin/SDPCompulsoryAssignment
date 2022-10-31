using System.ComponentModel.DataAnnotations;
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain;
using Domain.Interfaces;
using FluentValidation;
using ValidationException = System.ComponentModel.DataAnnotations.ValidationException;

namespace Application;

public class ProductService : IProductService
{
    private IProductRepository _productRepository;
    private IMapper _mapper;
    private IValidator<PostBoxDTO> _postValidator;

    public ProductService(IProductRepository _productRepository,IMapper _mapper,IValidator<PostBoxDTO> _postValidator)
    {
        this._productRepository = _productRepository;
        this._mapper = _mapper;
        this._postValidator = _postValidator;
    }
    
    public List<Box> GetAllBoxes()
    {
        return _productRepository.GetAllBoxes(); 
    }

    public Box CreateNewBox(PostBoxDTO dto)
    {
        var validation = _postValidator.Validate(dto);
        if (_productRepository.IfExists(dto.Name))
        {
            throw new ValidationException("Name is already taken");
        }
        if (!validation.IsValid)
        {
            throw new ValidationException(validation.ToString());
        }
        
        var box = _mapper.Map<Box>(dto);
        box.CreationDate= DateTime.Now.ToString("M/d/yyyy"); ;
        return _productRepository.CreateNewProduct(box);

    }

    public void CreateDb()
    {
        _productRepository.CreateDb();
    }

    public BoxType CreateNewBoxType(BoxType boxType)
    {
        return _productRepository.CreateBoxType(boxType);
    }

    public List<BoxType> GetAllBoxTypes()
    {
        return _productRepository.GetAllBoxTypes();
    }
}