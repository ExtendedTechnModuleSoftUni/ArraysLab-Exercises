using System;
using System.Linq;

class OddNumbersAtOddPositions
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (Math.Abs(numbers[i] % 2) != 0 && i % 2 != 0)
            {
                Console.WriteLine($"Index {i} -> {numbers[i]}");
            }
        }
    }
}

