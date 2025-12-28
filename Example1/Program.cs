using System;

class Program
{
    static void Main()
    {
        int[] marks = { 78, 85, 90, 66, 88 };
        int sum = 0;

        foreach (int m in marks)
            sum += m;

        double average = (double)sum / marks.Length;

        Console.WriteLine("Total Marks: " + sum);
        Console.WriteLine("Average Marks: " + average);
    }
}
