using System;

namespace random_letters
{
    internal class Program
    {
        const int AsciiStart = 97;
        const int AsciiEnd = 122;

        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Enter number of words");
            int wordCount;
            while (!int.TryParse(Console.ReadLine(), out wordCount))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
            Console.WriteLine("Enter number of letters per word");
            int lettersPerWord;
            while (!int.TryParse(Console.ReadLine(), out lettersPerWord))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
            char[,] letters = new char[wordCount, lettersPerWord];

            for (int x = 0; x < letters.GetLength(0); x++)
            {
                for (int y = 0; y < letters.GetLength(1); y++)
                {
                    letters[x, y] = (char)rnd.Next(AsciiStart, AsciiEnd + 1);
                }
            }

            for (int m = 0; m < letters.GetLength(0); m++)
            {
                for (int n = 0; n < letters.GetLength(1); n++)
                {
                    Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                    Console.Write(letters[m, n] + "   ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}
