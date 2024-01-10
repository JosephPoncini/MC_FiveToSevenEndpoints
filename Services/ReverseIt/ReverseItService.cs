namespace MC_FiveToSevenEndpoints.Services.ReverseIt;

public class ReverseItService : IReverseItService
{
    public string ReverseItAlpha(string numstring)
    {
        string result = "";
        for (int i = numstring.Length-1; i > -1; i--)
        {
            result += numstring[i];
        }
        return result;
    }

    public string ReverseItNum(string numstring)
    {
        if (Double.TryParse(numstring, out double number))
        {
            string result = "";
            for (int i = numstring.Length-1; i > -1; i--)
            {
                result += numstring[i];
            }
            return result;
        }

        return $"{numstring} is an invalid input. Try again :(";
    }
}
