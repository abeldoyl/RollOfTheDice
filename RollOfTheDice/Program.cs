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
            Console.WriteLine("Roll Of The Dice".PadLeft(165));
            Console.WriteLine("  2  |   3  |   4  |   5  |   6  |   7  " +
                "|   8  |   9  |  10  |  11  |  12  "); // column headers
            Console.WriteLine((new string('-', 75))); // row separator

            //pause
            Console.Read();
        }
    }
}
