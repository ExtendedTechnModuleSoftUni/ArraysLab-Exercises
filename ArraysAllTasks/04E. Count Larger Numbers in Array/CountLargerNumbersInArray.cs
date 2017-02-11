namespace _04E.Count_Larger_Numbers_in_Array
{
    using System;
    using System.Linq;

    class CountLargerNumbersInArray
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double element = double.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > element)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
