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
    public List<Box> getBoxes()
    {
        return _productService.GetAllBoxes();
    }

    [HttpPost]
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
        return "databse created";
    }

    [HttpDelete]
    [Route("{boxId}")]
    public bool DeleteBox([FromRoute] int boxId)
    {
        _productService.DeleteBox(boxId);
        return true;
    }

    [HttpPatch]
    [Route("{box.Id}")]
    public void UpdateBox(Box box)
    {
        _productService.UpdateBox(box);
    }

}