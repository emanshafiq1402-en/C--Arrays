using System;

class Program
{
    static void Main()
    {
        string[,] seats = {
            { "A1", "A2", "A3" },
            { "B1", "B2", "B3" }
        };

        Console.WriteLine("Classroom Seating Arrangement:");

        for (int row = 0; row < seats.GetLength(0); row++)
        {
            for (int col = 0; col < seats.GetLength(1); col++)
            {
                Console.Write(seats[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
