/***************************************************************
 * Program Name: The Ultimate Calculator
 * Date: November 29, 2023
 * Author: Manarap
 * Purpose: A simple 13-operations calculator (+,-,*,/,%,power/exponents, sqaure root, absolute value, celing, floor, a random number generator, Circumference of a circle calcualtor, and the perimter of a right triangle)
 * 
 * *********************************************************************/




using System;

namespace TheUltimateCalculator
{

    class Program
    {

        static void Main(string[] args)
        {

            //Variable Decalrations:
            //----------------------
            double x = 0;
            double y = 0;
            double z =0;
            double sideA =0;
            double sideB =0;
            double hypotenuse =0;
            double answer = 0;
            char oper;
            char choice;
            String name;
            Random rdm = new Random();




            //Start screen that will tell user to maximize their screen
            //------------------------------------------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please maximize your screen for the best experience, then press any key to start.");
            Console.ReadKey();
            Console.Clear();

            //Beggining Splash Screen that will be left out if user wants to use the caculator again
            //------------------------------------------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine(" /$$      /$$           /$$ ");
            Console.WriteLine("| $$  /$ | $$          | $$");
            Console.WriteLine("| $$ /$$$| $$  /$$$$$$ | $$  /$$$$$$$  /$$$$$$  /$$$$$$/$$$$   /$$$$$$");
            Console.WriteLine("| $$/$$ $$ $$ /$$__  $$| $$ /$$_____/ /$$__  $$| $$_  $$_  $$ /$$__  $$");
            Console.WriteLine("| $$$$_  $$$$| $$$$$$$$| $$| $$      | $$  \\ $$| $$ \\ $$ \\ $$| $$$$$$$$");
            Console.WriteLine("| $$$/ \\  $$$| $$_____/| $$| $$      | $$  | $$| $$ | $$ | $$| $$_____/");
            Console.WriteLine("| $$/   \\  $$|  $$$$$$$| $$|  $$$$$$$|  $$$$$$/| $$ | $$ | $$|  $$$$$$$");
            Console.WriteLine("|__/     \\__/ \\_______/|__/ \\_______/ \\______/ |__/ |__/ |__/ \\_______/");
            System.Threading.Thread.Sleep(400);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(" /$$$$$$$$");
            Console.WriteLine("|__  $$__/");
            Console.WriteLine("   | $$  /$$$$$$");
            Console.WriteLine("   | $$ /$$__  $$");
            Console.WriteLine("   | $$| $$  \\ $$ ");
            Console.WriteLine("   | $$| $$  | $$ ");
            Console.WriteLine("   | $$|  $$$$$$/");
            Console.WriteLine("   |__/ \\______/ ");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(" /$$$$$$$$ /$$");
            Console.WriteLine("|__  $$__/| $$");
            Console.WriteLine("   | $$   | $$$$$$$   /$$$$$$");
            Console.WriteLine("   | $$   | $$__  $$ /$$__  $$");
            Console.WriteLine("   | $$   | $$  \\ $$| $$$$$$$$");
            Console.WriteLine("   | $$   | $$  | $$| $$_____/");
            Console.WriteLine("   | $$   | $$  | $$|  $$$$$$$");
            Console.WriteLine("   |__/   |__/  |__/ \\_______/");
            System.Threading.Thread.Sleep(600);

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(" /$$   /$$ /$$   /$$     /$$                           /$$");
            Console.WriteLine("| $$  | $$| $$  | $$    |__/                          | $$");
            Console.WriteLine("| $$  | $$| $$ /$$$$$$   /$$ /$$$$$$/$$$$   /$$$$$$  /$$$$$$    /$$$$$$");
            Console.WriteLine("| $$  | $$| $$|_  $$_/  | $$| $$_  $$_  $$ |____  $$|_  $$_/   /$$__  $$");
            Console.WriteLine("| $$  | $$| $$  | $$    | $$| $$ \\ $$ \\ $$  /$$$$$$$  | $$    | $$$$$$$$");
            Console.WriteLine("| $$  | $$| $$  | $$ /$$| $$| $$ | $$ | $$ /$$__  $$  | $$ /$$| $$_____/");
            Console.WriteLine("|  $$$$$$/| $$  |  $$$$/| $$| $$ | $$ | $$|  $$$$$$$  |  $$$$/|  $$$$$$$");
            Console.WriteLine(" \\______/ |__/   \\___/  |__/|__/ |__/ |__/ \\_______/   \\___/   \\_______/");
            System.Threading.Thread.Sleep(600);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("  /$$$$$$            /$$                     /$$             /$$");
            Console.WriteLine(" /$$__  $$          | $$                    | $$            | $$");
            Console.WriteLine("| $$  \\__/  /$$$$$$ | $$  /$$$$$$$ /$$   /$$| $$  /$$$$$$  /$$$$$$    /$$$$$$   /$$$$$$");
            Console.WriteLine("| $$       |____  $$| $$ /$$_____/| $$  | $$| $$ |____  $$|_  $$_/   /$$__  $$ /$$__  $$");
            Console.WriteLine("| $$        /$$$$$$$| $$| $$      | $$  | $$| $$  /$$$$$$$  | $$    | $$  \\ $$| $$  \\__/");
            Console.WriteLine("| $$    $$ /$$__  $$| $$| $$      | $$  | $$| $$ /$$__  $$  | $$ /$$| $$  | $$| $$");
            Console.WriteLine("|  $$$$$$/|  $$$$$$$| $$|  $$$$$$$|  $$$$$$/| $$|  $$$$$$$  |  $$$$/|  $$$$$$/| $$");
            Console.WriteLine(" \\______/  \\_______/|__/ \\_______/ \\______/ |__/ \\_______/   \\___/   \\______/ |__/");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(800);


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press any key to start");
            Console.ReadKey();
            Console.Clear();


            //Get user's name
            //-----------------------
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hey buddy, what's your name?");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("           ___________    ____");
            Console.WriteLine("    ______/   \\__//   \\__/____\\");
            Console.WriteLine("  _/   \\_/  :           //____\\\\");
            Console.WriteLine(" /|      :  :  ..      /        \\");
            Console.WriteLine("| |     ::     ::      \\        /");
            Console.WriteLine("| |     :|     ||     \\ \\______/");
            Console.WriteLine("| |     ||     ||      |\\  /  |");
            Console.WriteLine(" \\|     ||     ||      |   / | \\");
            Console.WriteLine("  |     ||     ||      |  / /_\\ \\");
            Console.WriteLine("  | ___ || ___ ||      | /  /    \\");
            Console.WriteLine("   \\_-_/  \\_-_/ | ____ |/__/      \\");
            Console.WriteLine("                _\\_--_/    \\      /");
            Console.WriteLine("               /____             /");
            Console.WriteLine("              /     \\           /");
            Console.WriteLine("              \\______\\_________/");
            Console.WriteLine("");

            name = Console.ReadLine();
            Console.Clear();

            //Start of program loop:
            //--------------------------
            do
            {



                //Get operation choice from user:
                //--------------------------------

                do
                {
                    Console.WriteLine(@"
────── The Ultimate Calculator ──────
┌────────────────────────────────────────┐
│ sqrt - Square Root │
│ floor or f - floor │
│ ceil or c - ceiling │
│ abs or a- absolute value │
│ circumference or cir - │
│ circumfrence of circle with radius x │
│ ~ - random decimal between x and y │ 
│ + - addition │
│ - - subtraction │
│ * - multiplication │
│ / - division │
│ % - modulus │
│ ^ - power │
│ righttriangleperimeter or rtp - │
│ perimeter of right triangle │
│ with base x and height y │
└────────────────────────────────────────┘
");
                    Console.Write("Hey, " + name + ". What type of operation would you like to perform (+,-,*,/,%,^,sqrt,a,c,f,~,circumference,righttriangleperimeter)? \n");


                    //logical error-checking
                    //------------------------
                    try
                    {
                        oper = Convert.ToChar(Console.ReadLine());
                    }

                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("That wasn't one of the operations " + name);
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("                                   :oooooooooo:");
                        Console.WriteLine("                        ::oOOOOooo:::::ooooO88Oo:");
                        Console.WriteLine("                     :oOOo:                   :oO8O:");
                        Console.WriteLine("                  :O8O:                           oO8o");
                        Console.WriteLine("                O8O:                                 :OO:");
                        Console.WriteLine("              o8o                                      :8o");
                        Console.WriteLine("             88:                                         O8:");
                        Console.WriteLine("           o8o                                            :8o");
                        Console.WriteLine("          8O:                                               oO");
                        Console.WriteLine("         8o                                                  oO");
                        Console.WriteLine("        8o                                                    Oo");
                        Console.WriteLine("      :8o                                              :      :8:");
                        Console.WriteLine("     :8:                                               :       :8:");
                        Console.WriteLine("    :8:                                               :o        oO");
                        Console.WriteLine("    O::o                                              oo         8:");
                        Console.WriteLine("   :o:ooO                                             oo         o8");
                        Console.WriteLine("   8    oo                                            :o          8o");
                        Console.WriteLine("  oo     8o                                            OO:        :8");
                        Console.WriteLine("  8      o8:                                            O8O:       8:");
                        Console.WriteLine(" :o      :88                                             :8O       :O");
                        Console.WriteLine(" o:     ::88:                                             O8        8");
                        Console.WriteLine(" 8       888:                                             O8o       O");
                        Console.WriteLine(":8       :88:                                             888Ooo:   oo");
                        Console.WriteLine("oo       oO8:                                             888888o   :O");
                        Console.WriteLine("Oo       O88           :oO88O:            oO88Oo:         O8888O    :O");
                        Console.WriteLine("O:  ::   :88      :oO888888888:          8888888888OOo:    8888:    :O");
                        Console.WriteLine("O:  :o    8o   o88888888888888:          88888888888888O:   o88     :O");
                        Console.WriteLine("Oo   oo  oO  o888888888888888O           8888888888888888o   88     :O");
                        Console.WriteLine(":O    O: oo  8888888888888888:          o88888888888888888   88     :O");
                        Console.WriteLine(" 8    :o:8:  8888888888888888:::         :8888888888888888  o888o:::8O");
                        Console.WriteLine(" O:   :88:   O88888888888888888           O888888888888888  o88888888O");
                        Console.WriteLine("  o   :8O    o888888888888888O            O88888888888888O   88888888o");
                        Console.WriteLine("  O:  :8:    88888888888888O:      :      O888888888888888   O8888888:");
                        Console.WriteLine("  :O  :8     88888888888888       o88:    :o88888888888888    8888888");
                        Console.WriteLine("   OoooO    :8888888888O:8o      :8O88       :O8888888888o     O888oo");
                        Console.WriteLine("    888:     8888888o:  8O       :8o88O         O888888O:          :");
                        Console.WriteLine("    :88       oOOo:   :O:        :8:888          8o");
                        Console.WriteLine("     88              o:          88oO88o      :: :oo            :");
                        Console.WriteLine("     88::               oo      O88O:888o    O8o:   :   ::     : :");
                        Console.WriteLine("     8o o:                     o88oo O888    :8        :88   :: ::");
                        Console.WriteLine("     oO  oo     o              O8o : O888     :o       oO8o ::  O");
                        Console.WriteLine("      O:  Oo  ::o              OO    OO :             :oO88 O::O:");
                        Console.WriteLine("       O  :8: :88o             OO    Oo             :O888O  8OO:");
                        Console.WriteLine("       oo  Oo  O888o           :O:o:  :            o8888o  :O");
                        Console.WriteLine("        :O888  :88888           :o  Oo            o8888o   8:");
                        Console.WriteLine("           :8:  O8888               8            :O888O   :8");
                        Console.WriteLine("           Oo  :8888               o             :888    :O");
                        Console.WriteLine("            :O   o888  ::                         o88:    Oo");
                        Console.WriteLine("            :O    O88OO8oOOoOOoOooOooOOOOOOOOOO88O88O     O:");
                        Console.WriteLine("            OO     888:: o :o: o  o   O: 8: O o::o 8:     8");
                        Console.WriteLine("           :8O     :88o:  :    :  :      ::        8      O");
                        Console.WriteLine("           O8o      Oo:8oo:    :          :   :::oo8     :O");
                        Console.WriteLine("           88o      Oo O :ooOOOoOO:OO   :8O:O O  o O     :O");
                        Console.WriteLine("           88o      Oo :      o:o: :o    Oo : :  o       :O");
                        Console.WriteLine("           88O       :oo:oo:o o :  :: oo :: o O::o       o:");
                        Console.WriteLine("           888         :::::oO8O8OoO8O88oOOoo:         :Oo");
                        Console.WriteLine("            O88Oo::               ::                  :O");
                        Console.WriteLine("             :oO8888o                               :Oo");
                        Console.WriteLine("                 :o88o                      oo    o8O:");
                        Console.WriteLine("                    O8o                     Oo  o88o");
                        Console.WriteLine("                     o8O     Oo    o           o88");
                        Console.WriteLine("                      :88o        O:          O88");
                        Console.WriteLine("                        O88o     :8o        o88O");
                        Console.WriteLine("                          o88ooOO888O::::oO88O:");
                        Console.WriteLine("                            o8888888888888Oo");

                        System.Threading.Thread.Sleep(500);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        continue;
                    }


                    Console.Clear();

                    // More logical error-checking
                    //------------------------
                    if (oper != '+' && oper != '-' && oper != '*' && oper != '/' && oper != '%' && oper != '^' && oper != "sqrt" && oper != "abs" && oper != 'c' && oper != 'f' && oper != "cir" && oper != 'a' && oper != "ceil" && oper != "floor" && oper != '~' && oper != "circumference" && oper != "riaghttriangleperimeter" && oper != "rtp")
                    {

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("That wasn't one of the choices " + name);
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("                                   :oooooooooo:");
                        Console.WriteLine("                        ::oOOOOooo:::::ooooO88Oo:");
                        Console.WriteLine("                     :oOOo:                   :oO8O:");
                        Console.WriteLine("                  :O8O:                           oO8o");
                        Console.WriteLine("                O8O:                                 :OO:");
                        Console.WriteLine("              o8o                                      :8o");
                        Console.WriteLine("             88:                                         O8:");
                        Console.WriteLine("           o8o                                            :8o");
                        Console.WriteLine("          8O:                                               oO");
                        Console.WriteLine("         8o                                                  oO");
                        Console.WriteLine("        8o                                                    Oo");
                        Console.WriteLine("      :8o                                              :      :8:");
                        Console.WriteLine("     :8:                                               :       :8:");
                        Console.WriteLine("    :8:                                               :o        oO");
                        Console.WriteLine("    O::o                                              oo         8:");
                        Console.WriteLine("   :o:ooO                                             oo         o8");
                        Console.WriteLine("   8    oo                                            :o          8o");
                        Console.WriteLine("  oo     8o                                            OO:        :8");
                        Console.WriteLine("  8      o8:                                            O8O:       8:");
                        Console.WriteLine(" :o      :88                                             :8O       :O");
                        Console.WriteLine(" o:     ::88:                                             O8        8");
                        Console.WriteLine(" 8       888:                                             O8o       O");
                        Console.WriteLine(":8       :88:                                             888Ooo:   oo");
                        Console.WriteLine("oo       oO8:                                             888888o   :O");
                        Console.WriteLine("Oo       O88           :oO88O:            oO88Oo:         O8888O    :O");
                        Console.WriteLine("O:  ::   :88      :oO888888888:          8888888888OOo:    8888:    :O");
                        Console.WriteLine("O:  :o    8o   o88888888888888:          88888888888888O:   o88     :O");
                        Console.WriteLine("Oo   oo  oO  o888888888888888O           8888888888888888o   88     :O");
                        Console.WriteLine(":O    O: oo  8888888888888888:          o88888888888888888   88     :O");
                        Console.WriteLine(" 8    :o:8:  8888888888888888:::         :8888888888888888  o888o:::8O");
                        Console.WriteLine(" O:   :88:   O88888888888888888           O888888888888888  o88888888O");
                        Console.WriteLine("  o   :8O    o888888888888888O            O88888888888888O   88888888o");
                        Console.WriteLine("  O:  :8:    88888888888888O:      :      O888888888888888   O8888888:");
                        Console.WriteLine("  :O  :8     88888888888888       o88:    :o88888888888888    8888888");
                        Console.WriteLine("   OoooO    :8888888888O:8o      :8O88       :O8888888888o     O888oo");
                        Console.WriteLine("    888:     8888888o:  8O       :8o88O         O888888O:          :");
                        Console.WriteLine("    :88       oOOo:   :O:        :8:888          8o");
                        Console.WriteLine("     88              o:          88oO88o      :: :oo            :");
                        Console.WriteLine("     88::               oo      O88O:888o    O8o:   :   ::     : :");
                        Console.WriteLine("     8o o:                     o88oo O888    :8        :88   :: ::");
                        Console.WriteLine("     oO  oo     o              O8o : O888     :o       oO8o ::  O");
                        Console.WriteLine("      O:  Oo  ::o              OO    OO :             :oO88 O::O:");
                        Console.WriteLine("       O  :8: :88o             OO    Oo             :O888O  8OO:");
                        Console.WriteLine("       oo  Oo  O888o           :O:o:  :            o8888o  :O");
                        Console.WriteLine("        :O888  :88888           :o  Oo            o8888o   8:");
                        Console.WriteLine("           :8:  O8888               8            :O888O   :8");
                        Console.WriteLine("           Oo  :8888               o             :888    :O");
                        Console.WriteLine("            :O   o888  ::                         o88:    Oo");
                        Console.WriteLine("            :O    O88OO8oOOoOOoOooOooOOOOOOOOOO88O88O     O:");
                        Console.WriteLine("            OO     888:: o :o: o  o   O: 8: O o::o 8:     8");
                        Console.WriteLine("           :8O     :88o:  :    :  :      ::        8      O");
                        Console.WriteLine("           O8o      Oo:8oo:    :          :   :::oo8     :O");
                        Console.WriteLine("           88o      Oo O :ooOOOoOO:OO   :8O:O O  o O     :O");
                        Console.WriteLine("           88o      Oo :      o:o: :o    Oo : :  o       :O");
                        Console.WriteLine("           88O       :oo:oo:o o :  :: oo :: o O::o       o:");
                        Console.WriteLine("           888         :::::oO8O8OoO8O88oOOoo:         :Oo");
                        Console.WriteLine("            O88Oo::               ::                  :O");
                        Console.WriteLine("             :oO8888o                               :Oo");
                        Console.WriteLine("                 :o88o                      oo    o8O:");
                        Console.WriteLine("                    O8o                     Oo  o88o");
                        Console.WriteLine("                     o8O     Oo    o           o88");
                        Console.WriteLine("                      :88o        O:          O88");
                        Console.WriteLine("                        O88o     :8o        o88O");
                        Console.WriteLine("                          o88ooOO888O::::oO88O:");
                        Console.WriteLine("                            o8888888888888Oo");

                        System.Threading.Thread.Sleep(500);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();

                        continue;

                    }
                    break;



                } while (true);

                // Get side A from the user
                // -------------------------------------
                do
                {

                    Console.Write("Enter the side A for your triangle " + name + ": ");
                    try
                    {
                        sideA = Convert.ToDouble(Console.ReadLine());

                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Please write down the side A again " + name);
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("                                   :oooooooooo:");
                        Console.WriteLine("                        ::oOOOOooo:::::ooooO88Oo:");
                        Console.WriteLine("                     :oOOo:                   :oO8O:");
                        Console.WriteLine("                  :O8O:                           oO8o");
                        Console.WriteLine("                O8O:                                 :OO:");
                        Console.WriteLine("              o8o                                      :8o");
                        Console.WriteLine("             88:                                         O8:");
                        Console.WriteLine("           o8o                                            :8o");
                        Console.WriteLine("          8O:                                               oO");
                        Console.WriteLine("         8o                                                  oO");
                        Console.WriteLine("        8o                                                    Oo");
                        Console.WriteLine("      :8o                                              :      :8:");
                        Console.WriteLine("     :8:                                               :       :8:");
                        Console.WriteLine("    :8:                                               :o        oO");
                        Console.WriteLine("    O::o                                              oo         8:");
                        Console.WriteLine("   :o:ooO                                             oo         o8");
                        Console.WriteLine("   8    oo                                            :o          8o");
                        Console.WriteLine("  oo     8o                                            OO:        :8");
                        Console.WriteLine("  8      o8:                                            O8O:       8:");
                        Console.WriteLine(" :o      :88                                             :8O       :O");
                        Console.WriteLine(" o:     ::88:                                             O8        8");
                        Console.WriteLine(" 8       888:                                             O8o       O");
                        Console.WriteLine(":8       :88:                                             888Ooo:   oo");
                        Console.WriteLine("oo       oO8:                                             888888o   :O");
                        Console.WriteLine("Oo       O88           :oO88O:            oO88Oo:         O8888O    :O");
                        Console.WriteLine("O:  ::   :88      :oO888888888:          8888888888OOo:    8888:    :O");
                        Console.WriteLine("O:  :o    8o   o88888888888888:          88888888888888O:   o88     :O");
                        Console.WriteLine("Oo   oo  oO  o888888888888888O           8888888888888888o   88     :O");
                        Console.WriteLine(":O    O: oo  8888888888888888:          o88888888888888888   88     :O");
                        Console.WriteLine(" 8    :o:8:  8888888888888888:::         :8888888888888888  o888o:::8O");
                        Console.WriteLine(" O:   :88:   O88888888888888888           O888888888888888  o88888888O");
                        Console.WriteLine("  o   :8O    o888888888888888O            O88888888888888O   88888888o");
                        Console.WriteLine("  O:  :8:    88888888888888O:      :      O888888888888888   O8888888:");
                        Console.WriteLine("  :O  :8     88888888888888       o88:    :o88888888888888    8888888");
                        Console.WriteLine("   OoooO    :8888888888O:8o      :8O88       :O8888888888o     O888oo");
                        Console.WriteLine("    888:     8888888o:  8O       :8o88O         O888888O:          :");
                        Console.WriteLine("    :88       oOOo:   :O:        :8:888          8o");
                        Console.WriteLine("     88              o:          88oO88o      :: :oo            :");
                        Console.WriteLine("     88::               oo      O88O:888o    O8o:   :   ::     : :");
                        Console.WriteLine("     8o o:                     o88oo O888    :8        :88   :: ::");
                        Console.WriteLine("     oO  oo     o              O8o : O888     :o       oO8o ::  O");
                        Console.WriteLine("      O:  Oo  ::o              OO    OO :             :oO88 O::O:");
                        Console.WriteLine("       O  :8: :88o             OO    Oo             :O888O  8OO:");
                        Console.WriteLine("       oo  Oo  O888o           :O:o:  :            o8888o  :O");
                        Console.WriteLine("        :O888  :88888           :o  Oo            o8888o   8:");
                        Console.WriteLine("           :8:  O8888               8            :O888O   :8");
                        Console.WriteLine("           Oo  :8888               o             :888    :O");
                        Console.WriteLine("            :O   o888  ::                         o88:    Oo");
                        Console.WriteLine("            :O    O88OO8oOOoOOoOooOooOOOOOOOOOO88O88O     O:");
                        Console.WriteLine("            OO     888:: o :o: o  o   O: 8: O o::o 8:     8");
                        Console.WriteLine("           :8O     :88o:  :    :  :      ::        8      O");
                        Console.WriteLine("           O8o      Oo:8oo:    :          :   :::oo8     :O");
                        Console.WriteLine("           88o      Oo O :ooOOOoOO:OO   :8O:O O  o O     :O");
                        Console.WriteLine("           88o      Oo :      o:o: :o    Oo : :  o       :O");
                        Console.WriteLine("           88O       :oo:oo:o o :  :: oo :: o O::o       o:");
                        Console.WriteLine("           888         :::::oO8O8OoO8O88oOOoo:         :Oo");
                        Console.WriteLine("            O88Oo::               ::                  :O");
                        Console.WriteLine("             :oO8888o                               :Oo");
                        Console.WriteLine("                 :o88o                      oo    o8O:");
                        Console.WriteLine("                    O8o                     Oo  o88o");
                        Console.WriteLine("                     o8O     Oo    o           o88");
                        Console.WriteLine("                      :88o        O:          O88");
                        Console.WriteLine("                        O88o     :8o        o88O");
                        Console.WriteLine("                          o88ooOO888O::::oO88O:");
                        Console.WriteLine("                            o8888888888888Oo");

                        System.Threading.Thread.Sleep(500);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        continue;
                    }
                    break;
                } while (true);


                // Get side B from the user
                // -------------------------------------
                do
                {

                    Console.Write("Enter the side B for your triangle " + name + ": ");
                    try
                    {
                        sideB = Convert.ToDouble(Console.ReadLine());

                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Please write down the side B again " + name);
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("                                   :oooooooooo:");
                        Console.WriteLine("                        ::oOOOOooo:::::ooooO88Oo:");
                        Console.WriteLine("                     :oOOo:                   :oO8O:");
                        Console.WriteLine("                  :O8O:                           oO8o");
                        Console.WriteLine("                O8O:                                 :OO:");
                        Console.WriteLine("              o8o                                      :8o");
                        Console.WriteLine("             88:                                         O8:");
                        Console.WriteLine("           o8o                                            :8o");
                        Console.WriteLine("          8O:                                               oO");
                        Console.WriteLine("         8o                                                  oO");
                        Console.WriteLine("        8o                                                    Oo");
                        Console.WriteLine("      :8o                                              :      :8:");
                        Console.WriteLine("     :8:                                               :       :8:");
                        Console.WriteLine("    :8:                                               :o        oO");
                        Console.WriteLine("    O::o                                              oo         8:");
                        Console.WriteLine("   :o:ooO                                             oo         o8");
                        Console.WriteLine("   8    oo                                            :o          8o");
                        Console.WriteLine("  oo     8o                                            OO:        :8");
                        Console.WriteLine("  8      o8:                                            O8O:       8:");
                        Console.WriteLine(" :o      :88                                             :8O       :O");
                        Console.WriteLine(" o:     ::88:                                             O8        8");
                        Console.WriteLine(" 8       888:                                             O8o       O");
                        Console.WriteLine(":8       :88:                                             888Ooo:   oo");
                        Console.WriteLine("oo       oO8:                                             888888o   :O");
                        Console.WriteLine("Oo       O88           :oO88O:            oO88Oo:         O8888O    :O");
                        Console.WriteLine("O:  ::   :88      :oO888888888:          8888888888OOo:    8888:    :O");
                        Console.WriteLine("O:  :o    8o   o88888888888888:          88888888888888O:   o88     :O");
                        Console.WriteLine("Oo   oo  oO  o888888888888888O           8888888888888888o   88     :O");
                        Console.WriteLine(":O    O: oo  8888888888888888:          o88888888888888888   88     :O");
                        Console.WriteLine(" 8    :o:8:  8888888888888888:::         :8888888888888888  o888o:::8O");
                        Console.WriteLine(" O:   :88:   O88888888888888888           O888888888888888  o88888888O");
                        Console.WriteLine("  o   :8O    o888888888888888O            O88888888888888O   88888888o");
                        Console.WriteLine("  O:  :8:    88888888888888O:      :      O888888888888888   O8888888:");
                        Console.WriteLine("  :O  :8     88888888888888       o88:    :o88888888888888    8888888");
                        Console.WriteLine("   OoooO    :8888888888O:8o      :8O88       :O8888888888o     O888oo");
                        Console.WriteLine("    888:     8888888o:  8O       :8o88O         O888888O:          :");
                        Console.WriteLine("    :88       oOOo:   :O:        :8:888          8o");
                        Console.WriteLine("     88              o:          88oO88o      :: :oo            :");
                        Console.WriteLine("     88::               oo      O88O:888o    O8o:   :   ::     : :");
                        Console.WriteLine("     8o o:                     o88oo O888    :8        :88   :: ::");
                        Console.WriteLine("     oO  oo     o              O8o : O888     :o       oO8o ::  O");
                        Console.WriteLine("      O:  Oo  ::o              OO    OO :             :oO88 O::O:");
                        Console.WriteLine("       O  :8: :88o             OO    Oo             :O888O  8OO:");
                        Console.WriteLine("       oo  Oo  O888o           :O:o:  :            o8888o  :O");
                        Console.WriteLine("        :O888  :88888           :o  Oo            o8888o   8:");
                        Console.WriteLine("           :8:  O8888               8            :O888O   :8");
                        Console.WriteLine("           Oo  :8888               o             :888    :O");
                        Console.WriteLine("            :O   o888  ::                         o88:    Oo");
                        Console.WriteLine("            :O    O88OO8oOOoOOoOooOooOOOOOOOOOO88O88O     O:");
                        Console.WriteLine("            OO     888:: o :o: o  o   O: 8: O o::o 8:     8");
                        Console.WriteLine("           :8O     :88o:  :    :  :      ::        8      O");
                        Console.WriteLine("           O8o      Oo:8oo:    :          :   :::oo8     :O");
                        Console.WriteLine("           88o      Oo O :ooOOOoOO:OO   :8O:O O  o O     :O");
                        Console.WriteLine("           88o      Oo :      o:o: :o    Oo : :  o       :O");
                        Console.WriteLine("           88O       :oo:oo:o o :  :: oo :: o O::o       o:");
                        Console.WriteLine("           888         :::::oO8O8OoO8O88oOOoo:         :Oo");
                        Console.WriteLine("            O88Oo::               ::                  :O");
                        Console.WriteLine("             :oO8888o                               :Oo");
                        Console.WriteLine("                 :o88o                      oo    o8O:");
                        Console.WriteLine("                    O8o                     Oo  o88o");
                        Console.WriteLine("                     o8O     Oo    o           o88");
                        Console.WriteLine("                      :88o        O:          O88");
                        Console.WriteLine("                        O88o     :8o        o88O");
                        Console.WriteLine("                          o88ooOO888O::::oO88O:");
                        Console.WriteLine("                            o8888888888888Oo");

                        System.Threading.Thread.Sleep(500);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        continue;
                    }
                    break;
                } while (true);

                
                // Get radius of the circle from the user
                // -------------------------------------
                do
                {

                    Console.Write("Enter the radius of your circle " + name + ": ");
                    try
                    {
                        z = Convert.ToDouble(Console.ReadLine());

                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Please write down the radius again " + name);
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("                                   :oooooooooo:");
                        Console.WriteLine("                        ::oOOOOooo:::::ooooO88Oo:");
                        Console.WriteLine("                     :oOOo:                   :oO8O:");
                        Console.WriteLine("                  :O8O:                           oO8o");
                        Console.WriteLine("                O8O:                                 :OO:");
                        Console.WriteLine("              o8o                                      :8o");
                        Console.WriteLine("             88:                                         O8:");
                        Console.WriteLine("           o8o                                            :8o");
                        Console.WriteLine("          8O:                                               oO");
                        Console.WriteLine("         8o                                                  oO");
                        Console.WriteLine("        8o                                                    Oo");
                        Console.WriteLine("      :8o                                              :      :8:");
                        Console.WriteLine("     :8:                                               :       :8:");
                        Console.WriteLine("    :8:                                               :o        oO");
                        Console.WriteLine("    O::o                                              oo         8:");
                        Console.WriteLine("   :o:ooO                                             oo         o8");
                        Console.WriteLine("   8    oo                                            :o          8o");
                        Console.WriteLine("  oo     8o                                            OO:        :8");
                        Console.WriteLine("  8      o8:                                            O8O:       8:");
                        Console.WriteLine(" :o      :88                                             :8O       :O");
                        Console.WriteLine(" o:     ::88:                                             O8        8");
                        Console.WriteLine(" 8       888:                                             O8o       O");
                        Console.WriteLine(":8       :88:                                             888Ooo:   oo");
                        Console.WriteLine("oo       oO8:                                             888888o   :O");
                        Console.WriteLine("Oo       O88           :oO88O:            oO88Oo:         O8888O    :O");
                        Console.WriteLine("O:  ::   :88      :oO888888888:          8888888888OOo:    8888:    :O");
                        Console.WriteLine("O:  :o    8o   o88888888888888:          88888888888888O:   o88     :O");
                        Console.WriteLine("Oo   oo  oO  o888888888888888O           8888888888888888o   88     :O");
                        Console.WriteLine(":O    O: oo  8888888888888888:          o88888888888888888   88     :O");
                        Console.WriteLine(" 8    :o:8:  8888888888888888:::         :8888888888888888  o888o:::8O");
                        Console.WriteLine(" O:   :88:   O88888888888888888           O888888888888888  o88888888O");
                        Console.WriteLine("  o   :8O    o888888888888888O            O88888888888888O   88888888o");
                        Console.WriteLine("  O:  :8:    88888888888888O:      :      O888888888888888   O8888888:");
                        Console.WriteLine("  :O  :8     88888888888888       o88:    :o88888888888888    8888888");
                        Console.WriteLine("   OoooO    :8888888888O:8o      :8O88       :O8888888888o     O888oo");
                        Console.WriteLine("    888:     8888888o:  8O       :8o88O         O888888O:          :");
                        Console.WriteLine("    :88       oOOo:   :O:        :8:888          8o");
                        Console.WriteLine("     88              o:          88oO88o      :: :oo            :");
                        Console.WriteLine("     88::               oo      O88O:888o    O8o:   :   ::     : :");
                        Console.WriteLine("     8o o:                     o88oo O888    :8        :88   :: ::");
                        Console.WriteLine("     oO  oo     o              O8o : O888     :o       oO8o ::  O");
                        Console.WriteLine("      O:  Oo  ::o              OO    OO :             :oO88 O::O:");
                        Console.WriteLine("       O  :8: :88o             OO    Oo             :O888O  8OO:");
                        Console.WriteLine("       oo  Oo  O888o           :O:o:  :            o8888o  :O");
                        Console.WriteLine("        :O888  :88888           :o  Oo            o8888o   8:");
                        Console.WriteLine("           :8:  O8888               8            :O888O   :8");
                        Console.WriteLine("           Oo  :8888               o             :888    :O");
                        Console.WriteLine("            :O   o888  ::                         o88:    Oo");
                        Console.WriteLine("            :O    O88OO8oOOoOOoOooOooOOOOOOOOOO88O88O     O:");
                        Console.WriteLine("            OO     888:: o :o: o  o   O: 8: O o::o 8:     8");
                        Console.WriteLine("           :8O     :88o:  :    :  :      ::        8      O");
                        Console.WriteLine("           O8o      Oo:8oo:    :          :   :::oo8     :O");
                        Console.WriteLine("           88o      Oo O :ooOOOoOO:OO   :8O:O O  o O     :O");
                        Console.WriteLine("           88o      Oo :      o:o: :o    Oo : :  o       :O");
                        Console.WriteLine("           88O       :oo:oo:o o :  :: oo :: o O::o       o:");
                        Console.WriteLine("           888         :::::oO8O8OoO8O88oOOoo:         :Oo");
                        Console.WriteLine("            O88Oo::               ::                  :O");
                        Console.WriteLine("             :oO8888o                               :Oo");
                        Console.WriteLine("                 :o88o                      oo    o8O:");
                        Console.WriteLine("                    O8o                     Oo  o88o");
                        Console.WriteLine("                     o8O     Oo    o           o88");
                        Console.WriteLine("                      :88o        O:          O88");
                        Console.WriteLine("                        O88o     :8o        o88O");
                        Console.WriteLine("                          o88ooOO888O::::oO88O:");
                        Console.WriteLine("                            o8888888888888Oo");

                        System.Threading.Thread.Sleep(500);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        continue;
                    }
                    break;
                } while (true);

                
                //Get first number from user:
                //----------------------------
                do
                {

                    Console.Write("Enter your first number " + name + ": ");
                    try
                    {
                        x = Convert.ToDouble(Console.ReadLine());

                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Please write down the first number again " + name);
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("                                   :oooooooooo:");
                        Console.WriteLine("                        ::oOOOOooo:::::ooooO88Oo:");
                        Console.WriteLine("                     :oOOo:                   :oO8O:");
                        Console.WriteLine("                  :O8O:                           oO8o");
                        Console.WriteLine("                O8O:                                 :OO:");
                        Console.WriteLine("              o8o                                      :8o");
                        Console.WriteLine("             88:                                         O8:");
                        Console.WriteLine("           o8o                                            :8o");
                        Console.WriteLine("          8O:                                               oO");
                        Console.WriteLine("         8o                                                  oO");
                        Console.WriteLine("        8o                                                    Oo");
                        Console.WriteLine("      :8o                                              :      :8:");
                        Console.WriteLine("     :8:                                               :       :8:");
                        Console.WriteLine("    :8:                                               :o        oO");
                        Console.WriteLine("    O::o                                              oo         8:");
                        Console.WriteLine("   :o:ooO                                             oo         o8");
                        Console.WriteLine("   8    oo                                            :o          8o");
                        Console.WriteLine("  oo     8o                                            OO:        :8");
                        Console.WriteLine("  8      o8:                                            O8O:       8:");
                        Console.WriteLine(" :o      :88                                             :8O       :O");
                        Console.WriteLine(" o:     ::88:                                             O8        8");
                        Console.WriteLine(" 8       888:                                             O8o       O");
                        Console.WriteLine(":8       :88:                                             888Ooo:   oo");
                        Console.WriteLine("oo       oO8:                                             888888o   :O");
                        Console.WriteLine("Oo       O88           :oO88O:            oO88Oo:         O8888O    :O");
                        Console.WriteLine("O:  ::   :88      :oO888888888:          8888888888OOo:    8888:    :O");
                        Console.WriteLine("O:  :o    8o   o88888888888888:          88888888888888O:   o88     :O");
                        Console.WriteLine("Oo   oo  oO  o888888888888888O           8888888888888888o   88     :O");
                        Console.WriteLine(":O    O: oo  8888888888888888:          o88888888888888888   88     :O");
                        Console.WriteLine(" 8    :o:8:  8888888888888888:::         :8888888888888888  o888o:::8O");
                        Console.WriteLine(" O:   :88:   O88888888888888888           O888888888888888  o88888888O");
                        Console.WriteLine("  o   :8O    o888888888888888O            O88888888888888O   88888888o");
                        Console.WriteLine("  O:  :8:    88888888888888O:      :      O888888888888888   O8888888:");
                        Console.WriteLine("  :O  :8     88888888888888       o88:    :o88888888888888    8888888");
                        Console.WriteLine("   OoooO    :8888888888O:8o      :8O88       :O8888888888o     O888oo");
                        Console.WriteLine("    888:     8888888o:  8O       :8o88O         O888888O:          :");
                        Console.WriteLine("    :88       oOOo:   :O:        :8:888          8o");
                        Console.WriteLine("     88              o:          88oO88o      :: :oo            :");
                        Console.WriteLine("     88::               oo      O88O:888o    O8o:   :   ::     : :");
                        Console.WriteLine("     8o o:                     o88oo O888    :8        :88   :: ::");
                        Console.WriteLine("     oO  oo     o              O8o : O888     :o       oO8o ::  O");
                        Console.WriteLine("      O:  Oo  ::o              OO    OO :             :oO88 O::O:");
                        Console.WriteLine("       O  :8: :88o             OO    Oo             :O888O  8OO:");
                        Console.WriteLine("       oo  Oo  O888o           :O:o:  :            o8888o  :O");
                        Console.WriteLine("        :O888  :88888           :o  Oo            o8888o   8:");
                        Console.WriteLine("           :8:  O8888               8            :O888O   :8");
                        Console.WriteLine("           Oo  :8888               o             :888    :O");
                        Console.WriteLine("            :O   o888  ::                         o88:    Oo");
                        Console.WriteLine("            :O    O88OO8oOOoOOoOooOooOOOOOOOOOO88O88O     O:");
                        Console.WriteLine("            OO     888:: o :o: o  o   O: 8: O o::o 8:     8");
                        Console.WriteLine("           :8O     :88o:  :    :  :      ::        8      O");
                        Console.WriteLine("           O8o      Oo:8oo:    :          :   :::oo8     :O");
                        Console.WriteLine("           88o      Oo O :ooOOOoOO:OO   :8O:O O  o O     :O");
                        Console.WriteLine("           88o      Oo :      o:o: :o    Oo : :  o       :O");
                        Console.WriteLine("           88O       :oo:oo:o o :  :: oo :: o O::o       o:");
                        Console.WriteLine("           888         :::::oO8O8OoO8O88oOOoo:         :Oo");
                        Console.WriteLine("            O88Oo::               ::                  :O");
                        Console.WriteLine("             :oO8888o                               :Oo");
                        Console.WriteLine("                 :o88o                      oo    o8O:");
                        Console.WriteLine("                    O8o                     Oo  o88o");
                        Console.WriteLine("                     o8O     Oo    o           o88");
                        Console.WriteLine("                      :88o        O:          O88");
                        Console.WriteLine("                        O88o     :8o        o88O");
                        Console.WriteLine("                          o88ooOO888O::::oO88O:");
                        Console.WriteLine("                            o8888888888888Oo");

                        System.Threading.Thread.Sleep(500);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        continue;
                    }
                    break;
                } while (true);


                // Get second number from user:
                //--------------------------------

                do
                {
                    if (oper != "sqrt" && oper != "cir" && oper != 'a' && oper != "abs" && oper != 'c' && oper != "ceil" && oper != 'f' && oper != "floor" && oper != "circumference")
                    {
                        try
                        {
                            Console.Write("Now enter your second number: ");
                            y = Convert.ToDouble(Console.ReadLine());
                        }

                        catch
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Please write down your second number again " + name);
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine("                                   :oooooooooo:");
                            Console.WriteLine("                        ::oOOOOooo:::::ooooO88Oo:");
                            Console.WriteLine("                     :oOOo:                   :oO8O:");
                            Console.WriteLine("                  :O8O:                           oO8o");
                            Console.WriteLine("                O8O:                                 :OO:");
                            Console.WriteLine("              o8o                                      :8o");
                            Console.WriteLine("             88:                                         O8:");
                            Console.WriteLine("           o8o                                            :8o");
                            Console.WriteLine("          8O:                                               oO");
                            Console.WriteLine("         8o                                                  oO");
                            Console.WriteLine("        8o                                                    Oo");
                            Console.WriteLine("      :8o                                              :      :8:");
                            Console.WriteLine("     :8:                                               :       :8:");
                            Console.WriteLine("    :8:                                               :o        oO");
                            Console.WriteLine("    O::o                                              oo         8:");
                            Console.WriteLine("   :o:ooO                                             oo         o8");
                            Console.WriteLine("   8    oo                                            :o          8o");
                            Console.WriteLine("  oo     8o                                            OO:        :8");
                            Console.WriteLine("  8      o8:                                            O8O:       8:");
                            Console.WriteLine(" :o      :88                                             :8O       :O");
                            Console.WriteLine(" o:     ::88:                                             O8        8");
                            Console.WriteLine(" 8       888:                                             O8o       O");
                            Console.WriteLine(":8       :88:                                             888Ooo:   oo");
                            Console.WriteLine("oo       oO8:                                             888888o   :O");
                            Console.WriteLine("Oo       O88           :oO88O:            oO88Oo:         O8888O    :O");
                            Console.WriteLine("O:  ::   :88      :oO888888888:          8888888888OOo:    8888:    :O");
                            Console.WriteLine("O:  :o    8o   o88888888888888:          88888888888888O:   o88     :O");
                            Console.WriteLine("Oo   oo  oO  o888888888888888O           8888888888888888o   88     :O");
                            Console.WriteLine(":O    O: oo  8888888888888888:          o88888888888888888   88     :O");
                            Console.WriteLine(" 8    :o:8:  8888888888888888:::         :8888888888888888  o888o:::8O");
                            Console.WriteLine(" O:   :88:   O88888888888888888           O888888888888888  o88888888O");
                            Console.WriteLine("  o   :8O    o888888888888888O            O88888888888888O   88888888o");
                            Console.WriteLine("  O:  :8:    88888888888888O:      :      O888888888888888   O8888888:");
                            Console.WriteLine("  :O  :8     88888888888888       o88:    :o88888888888888    8888888");
                            Console.WriteLine("   OoooO    :8888888888O:8o      :8O88       :O8888888888o     O888oo");
                            Console.WriteLine("    888:     8888888o:  8O       :8o88O         O888888O:          :");
                            Console.WriteLine("    :88       oOOo:   :O:        :8:888          8o");
                            Console.WriteLine("     88              o:          88oO88o      :: :oo            :");
                            Console.WriteLine("     88::               oo      O88O:888o    O8o:   :   ::     : :");
                            Console.WriteLine("     8o o:                     o88oo O888    :8        :88   :: ::");
                            Console.WriteLine("     oO  oo     o              O8o : O888     :o       oO8o ::  O");
                            Console.WriteLine("      O:  Oo  ::o              OO    OO :             :oO88 O::O:");
                            Console.WriteLine("       O  :8: :88o             OO    Oo             :O888O  8OO:");
                            Console.WriteLine("       oo  Oo  O888o           :O:o:  :            o8888o  :O");
                            Console.WriteLine("        :O888  :88888           :o  Oo            o8888o   8:");
                            Console.WriteLine("           :8:  O8888               8            :O888O   :8");
                            Console.WriteLine("           Oo  :8888               o             :888    :O");
                            Console.WriteLine("            :O   o888  ::                         o88:    Oo");
                            Console.WriteLine("            :O    O88OO8oOOoOOoOooOooOOOOOOOOOO88O88O     O:");
                            Console.WriteLine("            OO     888:: o :o: o  o   O: 8: O o::o 8:     8");
                            Console.WriteLine("           :8O     :88o:  :    :  :      ::        8      O");
                            Console.WriteLine("           O8o      Oo:8oo:    :          :   :::oo8     :O");
                            Console.WriteLine("           88o      Oo O :ooOOOoOO:OO   :8O:O O  o O     :O");
                            Console.WriteLine("           88o      Oo :      o:o: :o    Oo : :  o       :O");
                            Console.WriteLine("           88O       :oo:oo:o o :  :: oo :: o O::o       o:");
                            Console.WriteLine("           888         :::::oO8O8OoO8O88oOOoo:         :Oo");
                            Console.WriteLine("            O88Oo::               ::                  :O");
                            Console.WriteLine("             :oO8888o                               :Oo");
                            Console.WriteLine("                 :o88o                      oo    o8O:");
                            Console.WriteLine("                    O8o                     Oo  o88o");
                            Console.WriteLine("                     o8O     Oo    o           o88");
                            Console.WriteLine("                      :88o        O:          O88");
                            Console.WriteLine("                        O88o     :8o        o88O");
                            Console.WriteLine("                          o88ooOO888O::::oO88O:");
                            Console.WriteLine("                            o8888888888888Oo");

                            System.Threading.Thread.Sleep(500);
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            continue;
                        }
                    }
                    break;

                } while (true);







                //Calculate Answer:
                //----------------------
                if (oper == '+')
                {
                    answer = x + y;
                }//End of if


                else if (oper == '-')
                {
                    answer = x - y;
                }//End of else if


                else if (oper == '*')
                {
                    answer = x * y;
                }//End of else if


                else if (oper == '/')
                {
                    answer = x / y;
                }//End of else if

                else if (oper == '%')
                {
                    answer = x % y;
                }//End of else if

                else if (oper == '^')
                {
                    answer = Math.Pow(x, y);
                }//End of else if

                else if (oper == "sqrt")
                {
                    answer = Math.Sqrt(x);
                }//End of else if

                else if (oper == 'a' || oper == "abs")
                {
                    answer = Math.Abs(x);
                }//End of else if

                else if (oper == 'c' || oper == "ceil")
                {
                    answer = Math.Ceiling(x);
                }//End of else if

                else if (oper == 'f' || oper == "floor")
                {
                    answer = Math.Floor(x);
                }//End of else if

                else if (oper == '~')
                {
                    answer = rdm.Next((int)x, (int)y); //casting: implicitely convert (this is beacuse Next function likes integers not doubles)
                }//End of else if
                
                else if (oper == "circumfernce" || oper == "cir")
                {
                    answer = 2 * Math.PI * (z);
                }//End of else if

                else if (oper == "righttriangleperimeter" || oper == "rtp")
                {
                    // Calculate the length of the hypotenuse
                     hypotenuse = Math.Sqrt(sideA * sideA + sideB * sideB);
                    
                    // Calculate the perimeter
                     answer = sideA + sideB + hypotenuse;
                }//End of else if 



                //Final Output Of Answer:
                //------------------------
                if (oper == '+' || oper == '-' || oper == '*' || oper == '/')
                {
                    Console.WriteLine(x + "  " + oper + " " + y + " = " + answer);
                }//End of if

                else if (oper == '%')
                {
                    Console.WriteLine("When you divide " + x + " by " + y + " the remainder is " + answer);

                }//End of else if
                else if (oper == '^')
                {
                    Console.WriteLine(x + " raised to the power " + y + " is " + answer);
                }//End of else if

                else if (oper == "sqrt")
                {
                    Console.WriteLine("The square root of " + x + " is " + answer);
                }//End of else if

                else if (oper == 'a' || oper == "abs")
                {
                    Console.WriteLine("The absolute value of " + x + " is " + answer);

                }//End of else if

                else if (oper == 'c' || oper == "ceil")
                {
                    Console.WriteLine("When you round " + x + " up to the nearest number, you get " + answer);
                }//End of else if

                else if (oper == 'f' || oper == "floor")
                {
                    Console.WriteLine("When you round " + x + " down to the nearest number, you get " + answer);
                }//End of else if

                else if (oper == '~')
                {
                    Console.WriteLine("A random number from " + x + " to " + y + " is " + answer);
                }//End of else if

                else if (oper == "circumference" || oper == "cir")
                {
                    Console.WriteLine("The circumference of a circle with the radius of " + z + " is " + answer);
                }//End of else if 

                else if (oper == "righttriangleperimeter" || oper == "rtp")
                {
                    Console.WriteLine("The perimeter of your right triangle with the side lengths of " + sideA + sideB + " and the hypotenuse of " + hypotenuse + " is " + answer);
                }//End of else if 
 







                //Get user choice to repeat (y/n)
                //--------------------------------

                do
                {
                    Console.Write(name + ", would you like to use this pretty neat calculator again?\n(y/n) ");


                    try
                    {
                        choice = Convert.ToChar(Console.ReadLine());
                    }

                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Please write y or n. y = yes and n = no " + name);
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("                                   :oooooooooo:");
                        Console.WriteLine("                        ::oOOOOooo:::::ooooO88Oo:");
                        Console.WriteLine("                     :oOOo:                   :oO8O:");
                        Console.WriteLine("                  :O8O:                           oO8o");
                        Console.WriteLine("                O8O:                                 :OO:");
                        Console.WriteLine("              o8o                                      :8o");
                        Console.WriteLine("             88:                                         O8:");
                        Console.WriteLine("           o8o                                            :8o");
                        Console.WriteLine("          8O:                                               oO");
                        Console.WriteLine("         8o                                                  oO");
                        Console.WriteLine("        8o                                                    Oo");
                        Console.WriteLine("      :8o                                              :      :8:");
                        Console.WriteLine("     :8:                                               :       :8:");
                        Console.WriteLine("    :8:                                               :o        oO");
                        Console.WriteLine("    O::o                                              oo         8:");
                        Console.WriteLine("   :o:ooO                                             oo         o8");
                        Console.WriteLine("   8    oo                                            :o          8o");
                        Console.WriteLine("  oo     8o                                            OO:        :8");
                        Console.WriteLine("  8      o8:                                            O8O:       8:");
                        Console.WriteLine(" :o      :88                                             :8O       :O");
                        Console.WriteLine(" o:     ::88:                                             O8        8");
                        Console.WriteLine(" 8       888:                                             O8o       O");
                        Console.WriteLine(":8       :88:                                             888Ooo:   oo");
                        Console.WriteLine("oo       oO8:                                             888888o   :O");
                        Console.WriteLine("Oo       O88           :oO88O:            oO88Oo:         O8888O    :O");
                        Console.WriteLine("O:  ::   :88      :oO888888888:          8888888888OOo:    8888:    :O");
                        Console.WriteLine("O:  :o    8o   o88888888888888:          88888888888888O:   o88     :O");
                        Console.WriteLine("Oo   oo  oO  o888888888888888O           8888888888888888o   88     :O");
                        Console.WriteLine(":O    O: oo  8888888888888888:          o88888888888888888   88     :O");
                        Console.WriteLine(" 8    :o:8:  8888888888888888:::         :8888888888888888  o888o:::8O");
                        Console.WriteLine(" O:   :88:   O88888888888888888           O888888888888888  o88888888O");
                        Console.WriteLine("  o   :8O    o888888888888888O            O88888888888888O   88888888o");
                        Console.WriteLine("  O:  :8:    88888888888888O:      :      O888888888888888   O8888888:");
                        Console.WriteLine("  :O  :8     88888888888888       o88:    :o88888888888888    8888888");
                        Console.WriteLine("   OoooO    :8888888888O:8o      :8O88       :O8888888888o     O888oo");
                        Console.WriteLine("    888:     8888888o:  8O       :8o88O         O888888O:          :");
                        Console.WriteLine("    :88       oOOo:   :O:        :8:888          8o");
                        Console.WriteLine("     88              o:          88oO88o      :: :oo            :");
                        Console.WriteLine("     88::               oo      O88O:888o    O8o:   :   ::     : :");
                        Console.WriteLine("     8o o:                     o88oo O888    :8        :88   :: ::");
                        Console.WriteLine("     oO  oo     o              O8o : O888     :o       oO8o ::  O");
                        Console.WriteLine("      O:  Oo  ::o              OO    OO :             :oO88 O::O:");
                        Console.WriteLine("       O  :8: :88o             OO    Oo             :O888O  8OO:");
                        Console.WriteLine("       oo  Oo  O888o           :O:o:  :            o8888o  :O");
                        Console.WriteLine("        :O888  :88888           :o  Oo            o8888o   8:");
                        Console.WriteLine("           :8:  O8888               8            :O888O   :8");
                        Console.WriteLine("           Oo  :8888               o             :888    :O");
                        Console.WriteLine("            :O   o888  ::                         o88:    Oo");
                        Console.WriteLine("            :O    O88OO8oOOoOOoOooOooOOOOOOOOOO88O88O     O:");
                        Console.WriteLine("            OO     888:: o :o: o  o   O: 8: O o::o 8:     8");
                        Console.WriteLine("           :8O     :88o:  :    :  :      ::        8      O");
                        Console.WriteLine("           O8o      Oo:8oo:    :          :   :::oo8     :O");
                        Console.WriteLine("           88o      Oo O :ooOOOoOO:OO   :8O:O O  o O     :O");
                        Console.WriteLine("           88o      Oo :      o:o: :o    Oo : :  o       :O");
                        Console.WriteLine("           88O       :oo:oo:o o :  :: oo :: o O::o       o:");
                        Console.WriteLine("           888         :::::oO8O8OoO8O88oOOoo:         :Oo");
                        Console.WriteLine("            O88Oo::               ::                  :O");
                        Console.WriteLine("             :oO8888o                               :Oo");
                        Console.WriteLine("                 :o88o                      oo    o8O:");
                        Console.WriteLine("                    O8o                     Oo  o88o");
                        Console.WriteLine("                     o8O     Oo    o           o88");
                        Console.WriteLine("                      :88o        O:          O88");
                        Console.WriteLine("                        O88o     :8o        o88O");
                        Console.WriteLine("                          o88ooOO888O::::oO88O:");
                        Console.WriteLine("                            o8888888888888Oo");

                        System.Threading.Thread.Sleep(500);
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        continue;
                    }



                    if (choice != 'y' && choice != 'Y' && choice != 'n' && choice != 'N')
                    {
                        Console.Write("Please enter y or n. If your confused, Y = yes, and N = no.\n");
                        continue;
                    }
                    break;

                } while (true);




                if (choice == 'y' || choice == 'Y')
                {
                    Console.Clear();
                    continue;
                }


                else if (choice == 'n' || choice == 'N')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Thanks for using me! " + name);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("                      ");
                    Console.WriteLine("          _.-'''-._");
                    Console.WriteLine("         /  _   _  \\ ");
                    Console.WriteLine("        /  (9) (9)  \\ ");
                    Console.WriteLine("       /_,         ,_\\ ");
                    Console.WriteLine("       | \\         / |");
                    Console.WriteLine("_      \\  \\._____./  /  __");
                    Console.WriteLine("\\`\\     \\   \\___/   / _|  \\");
                    Console.WriteLine(" \\ `\\   /\\         /\\ \\   /");
                    Console.WriteLine("  |  `\\/ /`'-----'`\\ \\/  /");
                    Console.WriteLine("  |_|\\/ /           \\   /");
                    Console.WriteLine("  /    /|           |\\_/");
                    Console.WriteLine("  \\___/ |           | \\");
                    Console.WriteLine("   \\ .  |           |  \\");
                    Console.WriteLine("    \\|  |           |  |");
                    Console.WriteLine("     |  `.         .'  |");
                    Console.WriteLine("     \\    `-.___.-'    /");
                    Console.WriteLine("     `\\       |       /'");
                    Console.WriteLine("       `\\     |     /'");
                    Console.WriteLine("    .-.-.`\\   |   /'.-.-.");
                    Console.WriteLine("   (,(,(,`^   |   ^`,),),)");
                    Console.WriteLine("    '-'-'-----`-----'-'-'");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("My man Barney right here says that you should press ENTER on your keyboard");

                }
                break;



                //End of program loop
                //-------------
            } while (true);








            //Always leave this at the bottom of Main:
            Console.ReadKey();
        }//end of main
    }//end of class
}// end of namespace
