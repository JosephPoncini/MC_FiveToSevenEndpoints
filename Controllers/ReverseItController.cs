using MC_FiveToSevenEndpoints.Services.ReverseIt;
using Microsoft.AspNetCore.Mvc;

namespace MC_FiveToSevenEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItController : ControllerBase
{
    private readonly IReverseItService _reverseItService;

    public ReverseItController(IReverseItService reverseItService)
    {
        _reverseItService = reverseItService;
    }

    [HttpGet]
    [Route("AphaNumerical/{numstring}")]
    public string ReverseItAlpha(string numstring){
        return _reverseItService.ReverseItAlpha(numstring);
    }

    [HttpGet]
    [Route("Numerical/{numstring}")]
    public string ReverseItNum(string numstring){
        return _reverseItService.ReverseItNum(numstring);
    }
}
