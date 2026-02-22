namespace RollOfTheDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] counts = new int[13];
            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int die1 = rand.Next(1, 7); // dice #1 for rolls 1–6
                int die2 = rand.Next(1, 7); // dice #2 for rolls 1–6
                int sum = die1 + die2; //sum of both die for a 2-12 result

                counts[sum]++;
            }
            Console.WriteLine("Roll Of The Dice".PadLeft(170));
            Console.WriteLine((new string('-', 80))); // row separator
            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{i,5}".PadLeft(5)+ " |"); // dice result options 2-12
            }
            Console.WriteLine();
            Console.WriteLine((new string('-', 80))); // row separator

            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{counts[i],5}".PadLeft(5)+ " |"); // dice results data
            }

            //pause
            Console.Read();
        }
    }
}
