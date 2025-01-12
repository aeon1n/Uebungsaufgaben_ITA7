using System;

class MarioMore
{
    static void Main()
    {
        int height;

        do
        {
            Console.Write("Height: ");
            string input = Console.ReadLine()!;

            if (int.TryParse(input, out height) && height >= 1 && height <= 8)
            {
                break;
            }
        } while (true);

        for (int row = 1; row <= height; row++)
        {
            for (int space = 0; space < height - row; space++)
            {
                Console.Write(' ');
            }

            for (int hash = 0; hash < row; hash++)
            {
                Console.Write('#');
            }

            Console.Write("  ");

            for (int hash = 0; hash < row; hash++)
            {
                Console.Write('#');
            }

            Console.WriteLine();
        }
    }
}