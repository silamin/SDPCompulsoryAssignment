using Domain;
using Domain.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class BoxTypeController: ControllerBase
{
    
    private IProductService _productService;
    
    public BoxTypeController(IProductService service)
    {
        _productService = service;
    }
    
    [HttpPost]
    [Route("CreateBoxType")]
    public ActionResult<BoxType> CreateNewBoxType(BoxType boxType)
    {
        try
        { 
            return _productService.CreateNewBoxType(boxType);
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

    [HttpGet]
    public ActionResult<List<BoxType>> getAllBoxTypes()
    {
        return _productService.GetAllBoxTypes();
    }

}