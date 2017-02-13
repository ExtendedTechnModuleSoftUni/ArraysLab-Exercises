namespace _01ME.Last3EqualStrings
{
    using System;
    using System.Linq;

    class Last3EqualStrings
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();

            for (int i = text.Length - 1; i > 0; i--)
            {
                if (text[i] == text[i - 1] && text[i] == text[i - 2])
                {
                    Console.WriteLine($"{text[i]} {text[i - 1]} {text[i - 2]}");
                    break;
                }
            }
        }
    }
}
