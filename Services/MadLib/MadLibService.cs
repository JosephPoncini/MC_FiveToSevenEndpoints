namespace MC_FiveToSevenEndpoints.Services.MadLib
{
    public class MadLibService : IMadLibService
    {
        public string MadLibMachine(string name, string noun, string verb, string adjective, string mood)
        {
            return $"There once an individual named {name.ToUpper()}!!! {name} was a {noun} and one day this {noun} {verb} a dragon. The locals praised {name} as {adjective} and this made {name} very {mood}! The End.";
        }
    }
}