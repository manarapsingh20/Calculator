using System;

namespace ManarapCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continue_program = true;
           
            while(continue_program == true)
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
           
            Console.WriteLine("do you want to continue (Y/N)");
            String result = Console.ReadLine();
           
            if (result == "Y"){
                continue_program = true;
            }
            if(result == "N")
            {
                continue_program = false;
            }
        }
        }
    }
}

    }
}
