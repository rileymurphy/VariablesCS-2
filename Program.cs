using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCupsOfCoffee = 2;
            var fullName = "Riley Murphy";
            var today = "August 22nd, 2022";
            Console.WriteLine($"Today, {today}, {fullName} drank {numberOfCupsOfCoffee} cups of coffee.");
            Console.WriteLine("Today I drank " + numberOfCupsOfCoffee + " cups of coffee.");

        }
    }
}
