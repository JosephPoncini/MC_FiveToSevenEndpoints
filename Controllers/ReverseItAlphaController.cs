using MC_FiveToSevenEndpoints.Services.ReverseItAlpha;
using Microsoft.AspNetCore.Mvc;

namespace MC_FiveToSevenEndpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class ReverseItAlphaController : ControllerBase
{
    private readonly IReverseItAlphaService _reverseItAlphaService;

    public ReverseItAlphaController(IReverseItAlphaService reverseItAlphaService)
    {
        _reverseItAlphaService = reverseItAlphaService;
    }

    [HttpGet]
    [Route("AphaNumerical/{numstring}")]
    public string ReverseItAlphaMachine(string numstring){

        return _reverseItAlphaService.ReverseItAlphaMachine(numstring);
    }
}
