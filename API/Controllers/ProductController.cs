using Application.DTOs;
using Domain;
using Domain.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private IProductService _productService;
    
    public ProductController(IProductService service)
    {
        _productService = service;
    }

    [HttpGet]
    public List<Box> getBoxes()
    {
        return _productService.GetAllBoxes();
    }

    [HttpPost]
    public ActionResult<Box> CreateNewBox(PostBoxDTO dto)
    {
        try
        {
            var result = _productService.createNewBox(dto);
            return Created("product/" + result.Id, result);
        }
        catch (ValidationException e)
        {
            return BadRequest(e.Message);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.ToString());
        }
    }
}