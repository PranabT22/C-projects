using System;

namespace WeatherChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Where do you live in Australia?");
            Console.WriteLine("1.New South Wales");
            Console.WriteLine("2.Victoria");
            Console.WriteLine("3.Queensland");
            Console.WriteLine("4.South Australia");
            Console.WriteLine("5.Western Australia");
            Console.WriteLine("6.Tasmania");
            
            string state = Console.ReadLine();
            
            // Fixed condition
            if (state == "New South Wales" || state == "Victoria" || state == "Queensland" || 
                state == "South Australia" || state == "Western Australia" || state == "Tasmania")
            {
                Console.WriteLine("You live in: " + state);
            }
            else
            {
                Console.WriteLine("Not a valid Australian State");
            }
            
            Console.WriteLine("What is the weather like there?");
            Console.WriteLine("Is it over 30 degrees?");
            string weather = Console.ReadLine();
            
            if (weather.ToLower() == "yes")
            {
                Console.WriteLine("It's a hot day!");
            }
            else if (weather.ToLower() == "no")
            {
                Console.WriteLine("It's a cooler day!");
            }
            else
            {
                Console.WriteLine("Please answer with 'yes' or 'no'.");
            }
        }
    }
}
