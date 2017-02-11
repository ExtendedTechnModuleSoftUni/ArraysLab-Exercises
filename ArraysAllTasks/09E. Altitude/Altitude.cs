namespace _09E.Altitude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Altitude
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            List<int> altitude = new List<int>();
            int result = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    altitude.Add(int.Parse(array[i]));
                }
            }

            result = altitude[0];

            for (int i = 1; i < array.Length; i+=2)
            {
                if (array[i] == "up")
                {
                    result += int.Parse(array[i + 1]);
                }
                else
                {
                    result -= int.Parse(array[i + 1]);
                    if (result < 0)
                    {
                        Console.WriteLine("crashed");
                        return;
                    }
                }
            }

            Console.WriteLine($"got through safely. current altitude: {result}m");
        }
    }
}
