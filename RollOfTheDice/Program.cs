namespace RollOfTheDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] counts = new int[13];
            Random rand = new Random();
            string message = "Roll Of The Dice";
            message += message.ToString().PadLeft(150);


            for (int i = 0; i < 1000; i++)
            {
                int total = rand.Next(1, 13);
                counts[total]++;
            }
            Console.Write(message);

            //pause
            Console.Read();
        }
    }
}
