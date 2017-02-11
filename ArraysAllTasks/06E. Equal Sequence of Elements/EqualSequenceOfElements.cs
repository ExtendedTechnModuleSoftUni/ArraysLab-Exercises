namespace _06E.Equal_Sequence_of_Elements
{
    using System;
    using System.Linq;
    class EqualSequenceOfElements
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isIncreasing = true;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1])
                {
                    isIncreasing = false;
                    break;
                }
            }

            if (isIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
