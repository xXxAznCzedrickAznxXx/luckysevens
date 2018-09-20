using System;

namespace luckysevens
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSevens = 0;
            Random rng = new Random();

            int die1;
            int die2;

            Console.WriteLine("I'm going to guess how much sevens you roll");

            for (int i = 1; i <= 100; i++)
            {
                die1 = rng.Next(1, 7);
                die2 = rng.Next(1, 7);

                if (die1 + die2 == 7)
                    totalSevens++;
            }

            Console.WriteLine("Next you're going to roll {0} sevens!", totalSevens);
            Console.WriteLine("(Press enter to continue...)");
            Console.ReadLine();
            Console.WriteLine("You rolled {0} sevens", totalSevens);

        }
    }
}
