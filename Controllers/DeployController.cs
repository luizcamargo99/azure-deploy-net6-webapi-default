using Microsoft.AspNetCore.Mvc;

namespace AzureDeploy.Controllers;

[ApiController]
[Route("[controller]")]
public class DeployController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
       return "Estou realizando o deploy da minha API utilizando Azure";
    }
}
