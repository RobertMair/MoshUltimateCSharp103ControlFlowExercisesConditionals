using System;

namespace Exercise_3
{

    // Write a program and ask the user to enter the width and height of an image.
    // Then tell if the image is landscape or portrait.
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
                string[] dimensions =
                {
                    "width",
                    "height"
                };

                while (count < numbers)
                {
                    Console.Write("\nEnter the {0} of the image => ", dimensions[count]);
                    var input = Console.ReadLine();
                    int result;
                    var success = Int32.TryParse(input, out result);
                    if (success)
                    {
                        Console.WriteLine(" > Valid");
                        userNumbers[count] = result;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine(" > Invalid, try again..");
                    }
                }

                string orientation = userNumbers[0] >= userNumbers[1] ? "landscape" : "portrait";
                Console.WriteLine("\nBased on a width of {0} and a height of {1} the image orientation is: {2}.", userNumbers[0], userNumbers[1], orientation);

                Console.WriteLine("\nPress any key to run again or X to exit => ");
                char rerun = Console.ReadKey(true).KeyChar;
                if (rerun == 'x' || rerun == 'X') loop = false;

            }

            Console.WriteLine("\nPress any key to exit program..");
            Console.ReadKey();

        }
    }
}
