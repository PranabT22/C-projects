using System;

namespace WeatherChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Where do you live in Australia?");
            Console.WriteLine("1. New South Wales");
            Console.WriteLine("2. Victoria");
            Console.WriteLine("3. Queensland");
            Console.WriteLine("4. South Australia");
            Console.WriteLine("5. Western Australia");
            Console.WriteLine("6. Tasmania");
            
            string state = Console.ReadLine();
            
            // Check if the state is valid
            if (state == "New South Wales" || state == "Victoria" || state == "Queensland" || 
                state == "South Australia" || state == "Western Australia" || state == "Tasmania")
            {
                Console.WriteLine("You live in: " + state);
            }
            else
            {
                Console.WriteLine("Not a valid Australian State");
                return; // Exit if the user enters state that is not part of Australia
            }

            // Asking the user for temperature input and passing as integer
            Console.WriteLine("What is the weather like there today?");
            Console.WriteLine("Please enter the temperature in degrees Celsius:");
            
            int weather;
            bool isValidTemperature = int.TryParse(Console.ReadLine(), out weather);
            
            // Check if the input is a valid integer(number)
            if (isValidTemperature)
            {
                if (weather < 14)
                {
                    Console.WriteLine("Too Cold, Wear an extra layer of cloth!");
                }
                else if (weather > 30)
                {
                    Console.WriteLine("Too hot, It's time to wear shorts and apply sunscreen to your skin.");
                }
                else
                {
                    Console.WriteLine("Just right");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer for the temperature.");
            }
        }
    }
}
