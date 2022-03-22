using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] {"values1","values2"};
    }

    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        return "Les Jackson";
    }
}
