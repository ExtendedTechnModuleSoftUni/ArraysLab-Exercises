using System;
using System.Linq;

class RotateArrayOfStrings
{
    static void Main()
    {
        var words = Console.ReadLine().Split(' ').ToArray();
        int len = words.Length;
        var rotatedArr = new string[len];

        for (int i = 0; i < len - 1; i++)
        {
            rotatedArr[i + 1] = words[i];
        }

        rotatedArr[0] = words[len - 1];

        Console.WriteLine(string.Join(" ", rotatedArr));
    }
}

