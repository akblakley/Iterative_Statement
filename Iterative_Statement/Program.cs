// Author: Amanda Blakley
// Date: 9/10/2019
// Description: This C# Console application code demonstrates the use of iterative staement
// after the user enters an interger value between 1 & 100 

using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 100: ");
            /*
             * Use the try catch block to validate user input.
             * If the user provides bad input, the catch block 
             * will handle the error and a message will be displayed.
            */
            try
            {
                // This variable will gather data from the user input 
                string input = Console.ReadLine();

                // This variable will be used to perform the various iterative statements and is parsed as an integer 
                int value_of_input = int.Parse(input);

                // If the value input is between 1 and 100, run a for loop.
                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    Console.WriteLine("Executing the for loop");
                    Console.WriteLine("You have entered: " + value_of_input.ToString());

                    // Here is the while loop
                    while (value_of_input > 0)
                    {
                        Console.WriteLine("This is the current integer value in the loop: " + value_of_input.ToString());
                        value_of_input--;
                    }

                    Console.WriteLine("Press any key to exit the program ");
                    // Pause and allow the user to press a key 
                    Console.ReadKey(true);
                }
            }
            // If the user does not enter a value between 1 and 100, display a message 
            catch
            {
                Console.WriteLine("Please enter a number between 1 and 100 and try again...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }
        }
    }
}
