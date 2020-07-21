/* Programmer: Austin Parker
   Date: March 22nd, 2020
   Purpose: Allows user to enter numbers 1-10 and records number of times
   each number is entered with asterisks.
 */

using System;
using static System.Console;


namespace Bar_Chart
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            string input;
            int result;
            bool stopInput = false;
            string allInput = "";
            while (!stopInput)
            {
                do
                {
                    //Ask the user to enter valid input and resets validInput bool each time loop resets.
                    validInput = false;
                    WriteLine("Please enter a number between 0 and 10. Enter Q to exit program and see results.");
                    input = ReadLine();

                    //Parse input string and sends out input to result variable if valid.
                    if (int.TryParse(input, out result))
                    {
                        if (
                            result > 0 && result < 10)
                        {
                            validInput = true;
                            allInput += input + ",";
                        }
                    }
                    //Returns true to validInput and stopInput stopping the request for user input.
                    if (input.ToUpper().Equals("Q"))
                    {
                        validInput = true;
                        stopInput = true;
                    }

                    //Notifes user they have entered an invalid input.
                    if (!validInput)
                        WriteLine("Sorry, that's an invalid input. Value won't be counted toward totals.");
                } while (!validInput);
            }

            //Stores all input in numbers array and splits them.
            string[] numbers = allInput.Split(',');

            //for loop to add asterisks for each time user input equals one of the numbers between 1 and 10. 
            for (int i = 1; i < 10; i++)
            {
                Write("\n" + i + "   ");
                for (int c = 0; c < numbers.Length - 1; c++)
                {
                    if (Convert.ToInt32(numbers[c]) == i)
                        Write("*");
                }
            }

            WriteLine("\n");
            WriteLine("Press any key to end program.");
            ReadKey();
           

        }
    }
}
