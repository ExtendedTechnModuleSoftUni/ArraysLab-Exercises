namespace _03E.CountElementInArray
{
    using System;
    using System.Linq;

    class CountElementInArray
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == element)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);       
        }
    }
}
