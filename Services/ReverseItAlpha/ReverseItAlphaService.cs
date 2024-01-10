namespace MC_FiveToSevenEndpoints.Services.ReverseItAlpha;
public class ReverseItAlphaService : IReverseItAlphaService
{
    public string ReverseItAlphaMachine(string numstring)
    {
        string result = "";
        for (int i = numstring.Length - 1; i > -1; i--)
        {
            result += numstring[i];
        }
        return result;
    }
}
