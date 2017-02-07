using System;
using System.Linq;

class CountOddNumbersInArray
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int oddCounter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (Math.Abs(numbers[i] % 2) != 0)
            {
                oddCounter++;
            }
        }

        Console.WriteLine(oddCounter);
    }
}

