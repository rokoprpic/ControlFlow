namespace SumOfEnteredOK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            do
            {
                Console.WriteLine("Enter N: ");
                string? s = Console.ReadLine();
                if (s != "OK")
                {
                    int n = int.Parse(s);
                    sum += n;
                }
                else
                {
                    break;
                }
            } while(true);
            Console.WriteLine($"Sum of numbers: {sum}");
        }
    }
}