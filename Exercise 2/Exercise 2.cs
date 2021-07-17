using System;
using System.Linq;

namespace Exercise_2
{

    // Write a program which takes two numbers from the console and displays the maximum of the two.

    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.CursorVisible = false;
                int count = 0;
                int numbers = 2;
                int[] userNumbers = new int[numbers];

                while (count < numbers)
                {
                    Console.Write("\nEnter number {0} => ", count + 1);
                    var input = Console.ReadLine();
                    int result;
                    var success = Int32.TryParse(input, out result);
                    if (success)
                    {
                        Console.Write(" > Valid");
                        userNumbers[count] = result;
                        count++;
                    }
                    else
                    {
                        Console.Write(" > Invalid, try again..");
                    }
                }

                Console.Write("The maximum value of the following numbers: ");
                foreach(int n in userNumbers)
                {
                    Console.Write(n + ", ");
                }
                Console.WriteLine(" is: " + userNumbers.Max());
                

                Console.WriteLine("\nPress any key to run again or X to exit => ");
                char rerun = Console.ReadKey(true).KeyChar;
                if (rerun == 'x' || rerun == 'X') loop = false;

            }

            Console.WriteLine("\nPress any key to exit program..");
            Console.ReadKey();

        }
    }
}
