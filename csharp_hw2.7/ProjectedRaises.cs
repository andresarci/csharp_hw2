//using System
using static System.Console;
namespace csharp_hw2._7;

class Program
{
    static void Main()
    {
        WriteLine("This is the current salary for each employee");
        float employee1 = 4000;
        float employee2 = 4200;
        float employee3 = 3700;
        WriteLine($"The current salary of Jhon is {employee1}");
        WriteLine($"The current salary of Sophia is {employee2}");
        WriteLine($"The current salary of Mark is {employee3}");
        {
            WriteLine("Those are the next year's salary for each employee");
            float expected1 = employee1 * 1.04f;
            WriteLine($"Jhon's Salary: {expected1}");
            float expected2 = employee2 * 1.04f;
            WriteLine($"Sophia's Salary: {expected2}");
            float expected3 = employee3 * 1.04f;
            WriteLine($"Mark's Salary: {expected3}");
        }
    }
}
