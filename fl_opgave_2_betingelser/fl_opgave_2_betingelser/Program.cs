using System;

namespace fl_opgave_2_betingelser
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Random terning = new Random();
            int terningskast = terning.Next(1, 7);


            if (terningskast == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Du slog en 1'er");
            }
            else if (terningskast == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du slog en 2'er");
            }
            else if (terningskast == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Du slog en 3'er");
            }
            else if (terningskast == 4)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Du slog en 4'er");
            }
            else if (terningskast == 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Du slog en 5'er");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Du slog en 6'er");
            }
        }
    }
}