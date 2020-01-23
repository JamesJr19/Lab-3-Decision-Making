using System;

namespace Lab_3_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        { 
            string userContinue = "y";
            while (userContinue != "n")
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();

                Console.WriteLine($"Hi {name}, please enter a number between 1 and 100:");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput % 2 == 1 && userInput <= 100)
                {
                    Console.WriteLine($"Thanks {name}. {userInput} is odd");
                }

                else if (userInput % 2 == 0 && userInput <= 25)
                {
                    Console.WriteLine($"Thanks {name}. Even and less than 25.");
                }

                else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60)
                {
                    Console.WriteLine($"Thanks {name}. {userInput} is Even.");
                }

                else if (userInput % 2 == 0 && userInput > 60 && userInput <= 100)
                {
                    Console.WriteLine($"Thanks {name}. {userInput} is Even.");
                }

                else if (userInput > 100 || userInput < 1)
                {
                    Console.WriteLine("Invalid entry.");
                }

                userContinue = "";
                while (userContinue != "y" && userContinue != "n")
                {
                    Console.WriteLine("Would you like to try again? y/n");
                    userContinue = Console.ReadLine().ToLower();
                }

            }





        }
    }
}
