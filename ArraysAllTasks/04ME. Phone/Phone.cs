namespace _04ME.Phone
{
    using System;
    using System.Linq;

    class Phone
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] contactName = Console.ReadLine().Split(' ').ToArray();

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "done")
            {
                if (command[0] == "call")
                {
                    PrintCallingDetails(phoneNumbers, contactName, command);
                }
                else if (command[0] == "message")
                {
                    PrintMessageDetails(phoneNumbers, contactName, command);
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }
        }

        static void PrintCallingDetails(string[] phoneNumbers, string[] contactName, string[] command)
        {

            int sumOfDigits = 0;

            for (int i = 0; i < contactName.Length; i++)
            {
                if (command[1] == contactName[i])
                {
                    Console.WriteLine($"calling {phoneNumbers[i]}...");

                    sumOfDigits = GetSumOfDigits(phoneNumbers[i], sumOfDigits);

                    if (sumOfDigits % 2 != 0)
                    {
                        Console.WriteLine("no answer");
                    }
                    else
                    {
                        int minutes = sumOfDigits / 60;
                        int seconds = sumOfDigits % 60;
                        Console.WriteLine("call ended. duration: {0:00}:{1:00}", minutes, seconds);
                    }
                }
                else if (command[1] == phoneNumbers[i])
                {
                    Console.WriteLine($"calling {contactName[i]}...");

                    sumOfDigits = GetSumOfDigits(phoneNumbers[i], sumOfDigits);

                    if (sumOfDigits % 2 != 0)
                    {
                        Console.WriteLine("no answer");
                    }
                    else
                    {
                        int minutes = sumOfDigits / 60;
                        int seconds = sumOfDigits % 60;
                        Console.WriteLine("call ended. duration: {0:00}:{1:00}", minutes, seconds);
                    }
                }
            }
        }

        static int GetSumOfDigits(string Number, int sumOfDigits)
        {
            char[] numbers = Number.ToCharArray();

            for (int r = 0; r < numbers.Length; r++)
            {
                if ((int)numbers[r] < 58 && (int)numbers[r] >= 49)
                {
                    sumOfDigits += int.Parse(numbers[r].ToString());
                }
            }

            return sumOfDigits;
        }

        private static void PrintMessageDetails(string[] phoneNumbers, string[] contactName, string[] command)
        {
            int sumOfDigits = 0;

            for (int i = 0; i < contactName.Length; i++)
            {
                if (command[1] == contactName[i])
                {
                    Console.WriteLine($"sending sms to {phoneNumbers[i]}...");

                    sumOfDigits = GetSumOfDigits(phoneNumbers[i], sumOfDigits);

                    if (sumOfDigits % 2 != 0)
                    {
                        Console.WriteLine("busy");
                    }
                    else
                    {
                        Console.WriteLine("meet me there");
                    }
                }
                else if (command[1] == phoneNumbers[i])
                {
                    Console.WriteLine($"sending sms to {contactName[i]}...");

                    sumOfDigits = GetSumOfDigits(phoneNumbers[i], sumOfDigits);

                    if (sumOfDigits % 2 != 0)
                    {
                        Console.WriteLine("busy");
                    }
                    else
                    {
                        Console.WriteLine("meet me there");
                    }
                }
            }
        }
    }
}
