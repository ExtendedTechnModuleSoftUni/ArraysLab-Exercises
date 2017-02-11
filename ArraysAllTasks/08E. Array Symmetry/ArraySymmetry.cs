namespace _08E.Array_Symmetry
{
    using System;
    using System.Linq;

    class ArraySymmetry
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            bool isSymmetryc = true;

            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - i - 1])
                {
                    isSymmetryc = false;
                    break;
                }
            }

            if (isSymmetryc)
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
