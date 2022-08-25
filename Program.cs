using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 2;
            var fullName = "Riley Murphy";
            var today = DateTime.Now;
            Console.WriteLine($"As of {today}, {fullName} drank {numberOfCupsOfCoffee} cups of coffee.");

            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            if (userName == "Alice")
            {
                Console.WriteLine($"Haayyy Alice!");
            }
            else
            {
                Console.WriteLine($"INTRUDER ALERT!!!");
            }

            Console.WriteLine("Enter first number.");
            var firstNumberAsString = Console.ReadLine();
            var firstOperand = double.Parse(firstNumberAsString);

            Console.WriteLine("Enter second number.");
            var secondNumberAsString = Console.ReadLine();
            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            Console.WriteLine($"The sum of these numbers is {sum}. ");

            var difference = firstOperand - secondOperand;
            Console.WriteLine($"The difference of {firstOperand} and {secondOperand} is {difference}. ");

            var product = firstOperand * secondOperand;
            Console.WriteLine($"The product of these numbers is {product}. ");

            var quotient = firstOperand / secondOperand;
            Console.WriteLine($"The quotient of {firstOperand} and {secondOperand} is {quotient}.");

            var remainder = firstOperand % secondOperand;
            Console.WriteLine($"The remainder of {firstOperand} and {secondOperand} is {remainder}. ");


        }
    }
}
