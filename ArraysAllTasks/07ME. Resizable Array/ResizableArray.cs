namespace _07ME.Resizable_Array
{
    using System;
    using System.Linq;

    class ResizableArray
    {
        static void Main(string[] args)
        {
            string[] extendedArr = new string[10000];
            string[] finalArray = new string[1];
            string[] command = Console.ReadLine().Split(' ').ToArray();
            int arrayLenCounter = 0;
            int next = 0;

            while (command[0] != "end")
            {
                if (command[0] == "push")
                {
                    arrayLenCounter++;
                    finalArray = GetPushCommand(extendedArr, command, arrayLenCounter, next);
                    next++;
                }
                else if (command[0] == "pop")
                {
                    finalArray[arrayLenCounter - 1] = null;
                    arrayLenCounter--;
                    next--;
                }
                else if (command[0] == "removeAt")
                {
                    GetRemoveAtCommand(finalArray, extendedArr, arrayLenCounter, next, command);
                    arrayLenCounter--;
                    next--;
                }
                else
                {
                    GetClearCommand(finalArray, extendedArr);
                    arrayLenCounter = 0;
                    next = 0;
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }

            PrintResult(finalArray);
        }

        private static void GetRemoveAtCommand(string[] finalArray, string[] extendedArr, int arrayLenCounter, int next, string[] command)
        {
            finalArray[int.Parse(command[1])] = null;
            extendedArr[int.Parse(command[1])] = null;

            for (int i = int.Parse(command[1]); i < arrayLenCounter - 1; i++)
            {
                finalArray[i] = finalArray[i + 1];
                extendedArr[i] = extendedArr[i + 1];
            }

            finalArray[arrayLenCounter - 1] = null;
            extendedArr[arrayLenCounter - 1] = null;
        }

        static void PrintResult(string[] finaArray)
        {
            int nullCounter = 0;

            for (int i = 0; i < finaArray.Length; i++)
            {
                if (finaArray[i] == null)
                {
                    nullCounter++;
                }
            }
            if (nullCounter == finaArray.Length)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                for (int i = 0; i < finaArray.Length; i++)
                {
                    if (finaArray[i] != null)
                    {
                        Console.Write($"{finaArray[i]} ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void GetClearCommand(string[] finalArray, string[] extendedArr)
        {
            for (int i = 0; i < finalArray.Length; i++)
            {
                finalArray[i] = null;
            }

            for (int i = 0; i < finalArray.Length; i++)
            {
                extendedArr[i] = null;
            }
        }

        static string[] GetPushCommand(string[] extendedArr, string[] command, int arrayLenCounter, int next)
        {
            string[] finalArray = new string[arrayLenCounter];
            int len = finalArray.Length;

            extendedArr[0 + next] = command[1];

            for (int i = 0; i < len; i++)
            {
                if (extendedArr[i] != null)
                {
                    finalArray[i] = extendedArr[i];
                }
            }

            return finalArray;
        }
    }
}
