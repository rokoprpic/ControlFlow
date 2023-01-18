namespace SpeedCamera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter speed limit km/h: ");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Car speed in km/h is: ");
            int speed = int.Parse(Console.ReadLine());
            if(speed < speedLimit)
            {
                Console.WriteLine("OK!");
            } else
            {
                int difference = speed - speedLimit;
                int demeritPoints = 0;
                for(int i = difference; i >= 5; i-=5)
                {
                    if (difference >= 5)
                        demeritPoints++;
                    else break;
                }
                Console.WriteLine(demeritPoints);
                if(demeritPoints > 12)
                {
                    Console.Write("Licence Suspended!");
                }
            } 
        }
    }
}