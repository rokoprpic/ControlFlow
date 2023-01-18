namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n for factorial: ");
            int n = int.Parse(Console.ReadLine());
            int f = n;
            for(int i=1; i<n; i++)
            {
                f *= (n - i);
            }
            Console.WriteLine($"Factorial of {n} is {f}");
        }
    }
}