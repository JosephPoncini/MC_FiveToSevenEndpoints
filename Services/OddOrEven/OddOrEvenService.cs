namespace MC_FiveToSevenEndpoints.Services.OddOrEven;

public class OddOrEvenService : IOddOrEvenService
{
    public string OddOrEvenMachine(string num)
    {
        if(int.TryParse(num, out int number)){
            
            string result = "even";

            if(number%2 == 1){
                result = "odd";
            }

            return $"{num} is {result}";

        }
        
        return $"{num} is an invalid input. Try again :(";
    }
}
