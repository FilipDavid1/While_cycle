using System;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();


            int roll_1 = 0;
            int roll_2 = 1;
            int attempts = 0;

            Console.WriteLine("Please enter to roll.");


            while (roll_1 != roll_2)
            {
                Console.ReadKey();

                roll_1 = numberGen.Next(1, 21);
                roll_2 = numberGen.Next(1, 21
                );
                Console.WriteLine("Roll01: " + roll_1);
                Console.WriteLine("Roll02: " + roll_2 + "\n");

                attempts++;
            }

            Console.WriteLine("it took you:" + attempts + " attempts to roll two of a kind" +
                "" +
                "" +
                "" +
                "" +
                "");

        }
    }
}
