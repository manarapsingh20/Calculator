using System;

namespace ManarapCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    do
                    {
                        Console.WriteLine(" _____________________");
                        Console.WriteLine("|  _________________  |");
                        Console.WriteLine("| |                 | |");
                        Console.WriteLine("| |_________________| |");
                        Console.WriteLine("|  __ __ __ __ __ __  |");
                        Console.WriteLine("| |   |   |   | | √ | |");
                        Console.WriteLine("| |___|___|___| |___| |");
                        Console.WriteLine("| | 7 | 8 | 9 | | + | |");
                        Console.WriteLine("| |___|___|___| |___| |");
                        Console.WriteLine("| | 4 | 5 | 6 | | - | |");
                        Console.WriteLine("| |___|___|___| |___| |");
                        Console.WriteLine("| | 1 | 2 | 3 | | x | |");
                        Console.WriteLine("| |___|___|___| |___| |");
                        Console.WriteLine("| | . | 0 | = | | / | |");
                        Console.WriteLine("| |___|___|___| |___| |");
                        Console.WriteLine("|_____________________|");

                        do
                        {     
                            Console.WriteLine("Enter your first number:");
                        double firstNumber = Convert.ToDouble(Console.ReadLine());
                            try
                            {
                                firstNumber = Convert.ToInt32(Console.ReadLine());
                            }

                            catch (Exception e)
                            {
                                Console.WriteLine("Nonono not a number");
                                continue;
                            }
                            break;

                        } while (true);
                        Console.WriteLine(" ");

                        Console.WriteLine("What operation would you like to use? (+,-,*,/,^,√)");
                        String operation = Console.ReadLine();
                        Console.WriteLine(" ");


                        if (operation == "+")
                        {
                            do
                            {

                                Console.WriteLine("Enter your second number:");
                                Convert.ToDouble(Console.ReadLine());

                                try
                                {
                                    Console.WriteLine("Enter your second number:");
                                    Double secondNumber = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Your answer is:");
                                    double firstNumber = 0;
                                    Console.WriteLine(firstNumber + secondNumber);
                                    Console.WriteLine(" ");
                                    firstNumber = Convert.ToInt32(Console.ReadLine());
                                }

                                catch (Exception e)
                                {
                                    Console.WriteLine("Nonono not a number");
                                    continue;
                                }
                                break;

                            } while (true);
                        }

                        try
                        {
                           int  firstNumber = Convert.ToInt32(Console.ReadLine());
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Nonono not a number");
                            continue;
                        }
                        break;


                        if (operation == "-")
                        {
                            Console.WriteLine("Enter your second number:");
                            Double secondNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(" ");
                            Console.WriteLine("Your answer is:");
                            double firstNumber = 0; 
                            Console.WriteLine(firstNumber - secondNumber);
                            Console.WriteLine(" ");
                        }

                        try
                        {
                           firstNumber = Convert.ToInt32(Console.ReadLine());
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Nonono not a number");
                            continue;
                        }
                        break;


                        if (operation == "*")
                        {
                            Console.WriteLine("Enter your second number:");
                            Double secondNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(" ");
                            Console.WriteLine("Your answer is:");
                            Console.WriteLine(firstNumber * secondNumber);
                            Console.WriteLine(" ");
                        }


                        try
                        {
                            firstNumber = Convert.ToInt32(Console.ReadLine());
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Nonono not a number");
                            continue;
                        }
                        break;


                        if (operation == "/")
                        {
                            Console.WriteLine("Enter your second number:");
                            Double secondNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(" ");
                            Console.WriteLine("Your answer is:");
                            Console.WriteLine(firstNumber / secondNumber);
                            Console.WriteLine(" ");
                        }

                        try
                        {
                            firstNumber = Convert.ToInt32(Console.ReadLine());
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Nonono not a number");
                            continue;
                        }
                        break;


                        if (operation == "^")
                        {
                            Console.WriteLine("Enter your second number:");
                            Double secondNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine(" ");
                            Console.WriteLine("Your answer is:");
                            Console.WriteLine(Math.Pow(firstNumber, secondNumber));
                            Console.WriteLine(" ");
                        }

                     
                        if (operation == "√")
                        {
                            Console.WriteLine("Your answer is:");
                            Console.WriteLine(Math.Sqrt(firstNumber));
                            Console.WriteLine(" ");
                        }

                        try
                        {
                            firstNumber = Convert.ToInt32(Console.ReadLine());
                        }

                        catch (Exception e)
                        {
                            Console.WriteLine("Nonono not a number");
                            continue;
                        }
                        break;


                        Console.WriteLine("Would you like to continue? y/n");
                        string end = Console.ReadLine();

                        if (end == "n")
                        {
                            Console.WriteLine("Bye Bye");
                            break;
                        }

                    } while (true);
                   
                }
            }
        }
    }
}
