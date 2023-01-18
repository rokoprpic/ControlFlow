namespace ValidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter N 1-10: ");
                int n = int.Parse(Console.ReadLine());
                if(n >= 0 && n <= 10)
                {
                    Console.WriteLine("Valid!");
                    break;
                } else
                {
                    Console.WriteLine("Invalid, enter valid number!");
                }
            } while(true);
        }
    }
}