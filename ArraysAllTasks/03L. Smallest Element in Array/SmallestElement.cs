using System;
using System.Linq;

class SmallestElement
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        //int min = numbers.Min();

        //Console.WriteLine(min);

        int min = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        Console.WriteLine(min);
    }
}

