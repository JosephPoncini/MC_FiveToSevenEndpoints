using MC_FiveToSevenEndpoints.Services.ReverseItNumeric;
using Microsoft.AspNetCore.Mvc;

namespace MC_FiveToSevenEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItNumericController : ControllerBase
{
    private readonly IReverseItNumericService _reverseItNumericService;

    public ReverseItNumericController(IReverseItNumericService reverseItNumericService)
    {
        _reverseItNumericService = reverseItNumericService;
    }

    [HttpGet]
    [Route("Numerical/{num}")]
    public string ReverseItNumMaching(string num)
    {
        return _reverseItNumericService.ReverseItNumMaching(num);
    }
}
