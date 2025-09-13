using static System.Console;
namespace MoveEstimates;

class Program
{
    static void Main()
    {
        WriteLine("Welcome to our Estimate calculator");
        WriteLine("Our base tariff is $200, we charge $250 per hour and $2 per mile");
        WriteLine("Please insert the numbers of service's hour you need");
        string hours = ReadLine();
        WriteLine("Please inser the distance in miles of your route");
        string miles = ReadLine();
            int workhour = 250;
            int route = 2;

            double chargeperhour = int.Parse(hours) * workhour;
            double chargepermile = int.Parse(miles) * route;
            double total = 200 + chargeperhour + chargepermile;
        WriteLine($"The charge for {hours} hours is ${chargeperhour}");
        WriteLine($"The charge for {miles} miles is ${chargepermile}");
        WriteLine($"Adding our base rate, your total will be ${total}");
        WriteLine("Please let us know your decision");
    }
}
