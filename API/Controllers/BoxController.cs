using Application.DTOs;
using Domain;
using Domain.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class BoxController : ControllerBase
{
    private IProductService _productService;
    
    public BoxController(IProductService service)
    {
        _productService = service;
    }

    [HttpGet]
    [Route("GetAllBoxes")]
    public List<Box> GetBoxes()
    {
        return _productService.GetAllBoxes();
    }

    [HttpPost]
    [Route("CreateNewBox")]
    public ActionResult<Box> CreateNewBox(PostBoxDTO dto)
    {
        try
        {
            var result = _productService.CreateNewBox(dto);
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
    
    [HttpPost]
    [Route("CreateDb")]
    public string CreateDb()
    {
        _productService.CreateDb();
        return "database created";
    }
    
}