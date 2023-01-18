namespace LandOrPort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width: ");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            int h = int.Parse(Console.ReadLine());
            if (w > h)
            {
                Console.WriteLine("Landscape!");
            }
            else
            {
                Console.WriteLine("Portrait!");
            }
        }
    }
}