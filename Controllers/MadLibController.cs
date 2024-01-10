using MC_FiveToSevenEndpoints.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace MC_FiveToSevenEndpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    private readonly IMadLibService _madLibService;

    public MadLibController(IMadLibService madLibService)
    {
        _madLibService = madLibService;
    }

    [HttpGet]
    [Route("MadLibGen/{name}/{noun}/{past_tense_verb}/{adjective}/{mood}")]
    public string MadLibMachine(string name, string noun, string past_tense_verb, string adjective, string mood){
        return _madLibService.MadLibMachine(name, noun, past_tense_verb, adjective, mood);
    }
}
