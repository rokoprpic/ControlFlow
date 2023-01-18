namespace DivisibleNoRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0) counter++;
            }
            Console.WriteLine(counter);
        }
    }
}