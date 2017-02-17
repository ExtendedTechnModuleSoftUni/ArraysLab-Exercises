namespace _06ME.Power_Plants
{
    using System;
    using System.Linq;

    class PowerPlants
    {
        static void Main()
        {
            int[] plants = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int days = plants.Length;
            int seasons = 0;

            int survivedDays = 0;

            for (int i = 0; i < days; i++)
            {
                for (int r = 0; r < days; r++)
                {
                    if (i != r && plants[r] > 0)
                    {
                        plants[r]--;
                    }
                }

                survivedDays++;
                int alive = 0;

                for (int r = 0; r < days; r++)
                {
                    if (plants[r] > 0)
                    {
                        alive++;
                    }
                }
                if (alive > 0)
                {
                    if (i == days - 1)
                    {
                        for (int r = 0; r < days; r++)
                        {
                            if (plants[r] != 0)
                            {
                                plants[r]++;
                            }
                        }

                        i = -1;
                        seasons++;
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"survived {survivedDays} days ({seasons} seasons)");
        }
    }
}
