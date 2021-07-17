using System;

namespace Exercise_1
{
    // Write a program and ask the user to enter a number. The number should be between 1 to 10.
    // If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
    // (This logic is used a lot in applications where values entered into input boxes need to be validated.)

    class Program
    {
        
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.CursorVisible = false;
                Console.Write("\nEnter a number between 1 and 10 => ");
                var input = Console.ReadLine();
                int result;
                
                var success = Int32.TryParse(input, out result);
                if (success && result > 0 && result < 11)
                {
                    Console.Write(" > Valid");
                }
                else
                {
                    Console.Write(" > Invalid, try again..");
                }
                
                Console.WriteLine("\nPress any key to run again or X to exit => ");
                char rerun = Console.ReadKey(true).KeyChar;
                if (rerun == 'x' || rerun == 'X') loop = false;

            }
            
            Console.WriteLine("\nPress any key to exit program..");
            Console.ReadKey();

        }
    }
}
