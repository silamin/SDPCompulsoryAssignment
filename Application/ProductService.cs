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
        return _productRepository.getAllBoxes(); 
    }

    public Box createNewBox(PostBoxDTO dto)
    {
        //Map dto
        var validation = _postValidator.Validate(dto);
        if (!validation.IsValid)
        {
            throw new ValidationException(validation.ToString());
        }
        
        Box box = _mapper.Map<Box>(dto);
        
        
        
        return _productRepository.CreateNewProduct(box);
    }

}