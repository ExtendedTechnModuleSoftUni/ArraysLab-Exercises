namespace _03ME.Phonebook
{
    using System;
    using System.Linq;

    class Phonebook
    {
        static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] contactName = Console.ReadLine().Split(' ').ToArray();

            string name = Console.ReadLine();

            while (name != "done")
            {
                for (int i = 0; i < contactName.Length; i++)
                {
                    if (contactName[i] == name)
                    {
                        Console.WriteLine($"{name} -> {phoneNumbers[i]}");
                    }
                }

                name = Console.ReadLine();
            }
        }
    }
}
