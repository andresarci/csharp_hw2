namespace InchesToCentimetersInteractive;

class Program
{
    static void Main()
    {
        Console.WriteLine("Convert Inches to Centimeters");
        Console.WriteLine("Please insert the amount of inches you want to convert");
        string enter = Console.ReadLine();
        double number = int.Parse(enter);
        double result = number * 2.54;
        Console.WriteLine($"The result is {result} cm");
    }
}
