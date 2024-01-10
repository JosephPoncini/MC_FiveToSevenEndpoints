using MC_FiveToSevenEndpoints.Services.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace MC_FiveToSevenEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    private readonly IOddOrEvenService _oddOrEvenService;

    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }
    
    [HttpGet]
    [Route("InputInteger/{num}")]
    public string OddOrEvenMachine(string num){
        return _oddOrEvenService.OddOrEvenMachine(num);
    }
}
