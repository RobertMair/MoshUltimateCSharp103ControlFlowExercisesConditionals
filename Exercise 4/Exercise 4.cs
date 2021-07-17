using System;

namespace Exercise_4
{
    // Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera,
    // sensors, etc and focus purely on the logic.Write a program that asks the user to enter the speed limit.
    // Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit,
    // program should display Ok on the console. If the value is above the speed limit, the program should
    // calculate the number of demerit points.
    // For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
    // If the number of demerit points is above 12, the program should display License Suspended. 

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
                string[] speedDetails =
                {
                    "speed limit",
                    "speed of the car"
                };

                while (count < numbers)
                {
                    Console.Write("\nEnter the {0} => ", speedDetails[count]);
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

                int demeritPoints = Math.Max((userNumbers[1] - userNumbers[0]) / 5, 0);
                
                // string orientation = userNumbers[0] >= userNumbers[1] ? "landscape" : "portrait";
                Console.WriteLine("\nThe car was travelling at {0} in an {1} speedzone, {2} demerit points have been incurred.", userNumbers[1], userNumbers[0], demeritPoints);
                if (demeritPoints > 12) Console.WriteLine("\nLicence Suspended!");

                Console.WriteLine("\nPress any key to run again or X to exit => ");
                char rerun = Console.ReadKey(true).KeyChar;
                if (rerun == 'x' || rerun == 'X') loop = false;

            }

            Console.WriteLine("\nPress any key to exit program..");
            Console.ReadKey();
        }
    }
}
