using Microsoft.AspNetCore.Mvc;

namespace SDPCompulsoryAssignment.Controllers;

[ApiController]
[Route(("[Controller]"))]
public class BoxController : ControllerBase
{
    [HttpGet]
    public object HelloWorld()
    {
        return "hello world";
    }
}