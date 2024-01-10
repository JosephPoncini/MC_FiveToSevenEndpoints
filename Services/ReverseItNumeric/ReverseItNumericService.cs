namespace MC_FiveToSevenEndpoints.Services.ReverseItNumeric;
public class ReverseItNumericService : IReverseItNumericService
{
    public string ReverseItNumMaching(string numstring)
    {
        if (Double.TryParse(numstring, out double number))
        {
            string result = "";
            for (int i = numstring.Length - 1; i > -1; i--)
            {
                result += numstring[i];
            }
            return result;
        }

        return $"{numstring} is an invalid input. Try again :(";
    }
}
