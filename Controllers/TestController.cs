using Microsoft.AspNetCore.Mvc;

namespace Deploy_Azure_Trybe_Web_API.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{ 

    [HttpGet]
    public ActionResult<string> Get()
    {
        return "Teste";
    }
}
