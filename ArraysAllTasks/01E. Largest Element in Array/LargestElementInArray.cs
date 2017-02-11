namespace _01E.Largest_Element_in_Array
{
    using System;
    using System.Linq;

    class LargestElementInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //Console.WriteLine(numbers.Max()); 

            Console.WriteLine(GetMaxElement(numbers)); 
        }

        static int GetMaxElement(int[] numbers)
        {
            int max = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }
    }
}
