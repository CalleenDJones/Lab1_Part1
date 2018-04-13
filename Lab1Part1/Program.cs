using System;

namespace Lab1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            string GamePlay;
            string Number1, Number2;

            //Ask user if they would like to play a numbers game
            Console.WriteLine("Would you like to play a numbers game?  Please enter yes or no.");

            bool flag = true;

            while (flag)
            {
                GamePlay = Console.ReadLine();

                if (GamePlay == "yes")
                {
                    Console.WriteLine("Great! The game will check if each corresponding place in two numbers (ones, tens, hundreds) sums to the same total.  Press enter to continue.");
                    Console.ReadLine();
                    flag = false;
                }
                else if (GamePlay == "no")
                {
                    Console.WriteLine("Sorry to hear that, maybe next time.");
                    Console.ReadLine();
                    Console.WriteLine("Exiting:");
                    //need to add a statement that will exit the program if user says "no"
                    return;
                }
                else
                {
                    Console.WriteLine("Sorry, I am not programmed to interpret that response.  Please answer yes or no.");
                    //need to add loop to go back to response for yes or no
                }
            }

            Console.WriteLine("Please enter a three digit whole number.");
            //Number1 = Convert.ToInt32(Console.ReadLine());
            Number1 = Console.ReadLine();

            //Verifying length of number
            if
                (Number1.Length != 3)
            {
                Console.WriteLine("Sorry, that is not a three digit whole number. Please only enter three digits.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("Please enter another three digit whole number.");
                //Number2 = Convert.ToInt32(Console.ReadLine());
                Number2 = Console.ReadLine();

                if
                    (Number2.Length != 3)
                {
                    Console.WriteLine("Sorry, that is not a three digit whole number. Please only enter three digits.");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("The numbers will now be calculated:");
                }
            }

            //Calculations on user input will now be performed
            int Hundreds = Number1[0] + Number2[0];
            int Tens = Number1[1] + Number2[1];
            int Ones = Number1[2] + Number2[2];

            if (((Hundreds == Tens) && (Tens == Ones)))
     
                Console.WriteLine("True");   
            else
            {
                    Console.WriteLine("False");
            }



            Console.WriteLine("Game Over! Thanks for playing!");
             
        Console.ReadKey();
        }
    }
}
