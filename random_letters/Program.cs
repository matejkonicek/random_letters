using System;

namespace random_letters
{
    internal class Program
    {
        // Constants representing the ASCII codes for the lowercase letter range
        const int AsciiStart = 97;
        const int AsciiEnd = 122;

        static void Main(string[] args)
        {
            // Initialize a new instance of the Random class to generate random letters
            Random rnd = new Random();

            // Prompt the user to enter the number of words
            Console.WriteLine("Enter number of words");
            int wordCount;
            while (!int.TryParse(Console.ReadLine(), out wordCount))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }

            // Prompt the user to enter the number of letters per word
            Console.WriteLine("Enter number of letters per word");
            int lettersPerWord;
            while (!int.TryParse(Console.ReadLine(), out lettersPerWord))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }

            // Initialize a two-dimensional character array to store the randomly generated letters
            char[,] letters = new char[wordCount, lettersPerWord];

            // Generate random lowercase letters for each word and store them in the character array
            for (int x = 0; x < letters.GetLength(0); x++)
            {
                for (int y = 0; y < letters.GetLength(1); y++)
                {
                    letters[x, y] = (char)rnd.Next(AsciiStart, AsciiEnd + 1);
                }
            }

            // Display the randomly generated strings in the console with each letter colored randomly
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

            // Reset the console color and wait for user input before closing the console window
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }
    }
}
