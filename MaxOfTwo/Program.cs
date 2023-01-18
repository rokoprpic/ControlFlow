namespace MaxOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first N: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter seconde N: ");
            int n2 = int.Parse(Console.ReadLine());
            if(n1 > n2)
            {
                Console.WriteLine($"{n1} is greater!");
            } else
            {
                Console.WriteLine($"{n2} is greater!");
            }
        }
    }
}