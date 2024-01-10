namespace MC_FiveToSevenEndpoints.Services.MadLib;

public interface IMadLibService
{
    string MadLibMachine(string name, string noun, string verb, string adjective, string mood);
}
