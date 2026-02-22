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
                int total = rand.Next(1, 13);
                counts[total]++;
            }
            Console.WriteLine("Roll Of The Dice".PadLeft(150));

            //pause
            Console.Read();
        }
    }
}
