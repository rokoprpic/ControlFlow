namespace GuessRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1,10);
            int count = 0;
            do
            {
                Console.WriteLine("Enter N: ");
                count++;
                int guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber == randomNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                if (count == 4)
                    Console.WriteLine("You lost!");
            } while (count < 4);
        }
    }
}