namespace MaxNInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string of N (1-9 seperated by ,): ");
            string numbers = Console.ReadLine();
            int max = 0;
            foreach(char c in numbers)
            {
                int i = (int)Char.GetNumericValue(c);
                if(i > max) max = i;
            }
            Console.WriteLine(max);
        }
    }
}