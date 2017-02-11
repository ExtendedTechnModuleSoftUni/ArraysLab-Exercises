namespace _07E.Count_of_Capital_Letters
{
    using System;
    using System.Linq;

    class CountOfCapitalLetters
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            int counter = 0;
            char[] symbol = new char[1];

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length > 1)
                {
                    continue;
                }
                else 
                {
                    symbol = text[i].ToCharArray();

                    if (symbol[0] < 91 && symbol[0] >= 65)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
