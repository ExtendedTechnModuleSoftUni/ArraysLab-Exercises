namespace _02E.Negative_Elements_in_Array
{
    using System;

    class NegativeElementsInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
