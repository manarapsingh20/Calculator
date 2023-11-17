using System;

namespace ManarapCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("What operation would you like to use? (+,-,*,/)");
            String operation = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Enter your second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            Console.WriteLine("Your answer is:");

            if (operation == "+") 
            {
                Console.WriteLine(firstNumber + secondNumber);
            }

            if (operation == "-") 
            {
                Console.WriteLine(firstNumber - secondNumber);
            }

            if (operation == "*") 
            {
                Console.WriteLine(firstNumber * secondNumber);
            }

            if (operation == "/") 
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
        }
    }
}
