namespace _10E.Ballistics_Training
{
    using System;
    using System.Linq;

    class BallisticsTraining
    {
        static void Main()
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] commandsNumbers = Console.ReadLine().Split(' ').ToArray();
            int[] result = new int[coordinates.Length];

            for (int i = 0; i < commandsNumbers.Length; i+=2)
            {
                if (commandsNumbers[i] == "up")
                {
                    result[1] += int.Parse(commandsNumbers[i + 1]);
                }
                else if (commandsNumbers[i] == "down")
                {
                    result[1] -= int.Parse(commandsNumbers[i + 1]);
                }
                else if (commandsNumbers[i] == "left")
                {
                    result[0] -= int.Parse(commandsNumbers[i + 1]);
                }
                else
                {
                    result[0] += int.Parse(commandsNumbers[i + 1]);
                }
            }

            Console.WriteLine($"firing at [{coordinates[0]}, {coordinates[1]}]");

            if (coordinates[0] == result[0] && coordinates[1] == result[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
