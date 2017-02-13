namespace _05ME.Char_Rotation
{
    using System;
    using System.Linq;

    class CharRotation
    {
        static void Main()
        {
            string symbols = Console.ReadLine();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(string.Join("", ModifyElementsInArray(symbols, numbers)));
        }

        private static char[] ModifyElementsInArray(string symbols, int[] numbers)
        {
            char[] modifiedElements = new char[symbols.Length];

            for (int i = 0; i < modifiedElements.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    modifiedElements[i] = (char)(symbols[i] - numbers[i]);
                }
                else
                {
                    modifiedElements[i] = (char)(symbols[i] + numbers[i]);
                }
            }

            return modifiedElements;
        }
    }
}
