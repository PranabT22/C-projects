using System;

public class DontPressX
{
    public static void Main(string[] args)
    {
        int exitAttempts = 0;
        char k;
do
{
    Console.WriteLine("Press x to exit");
    k = Console.ReadKey().KeyChar;
    exitAttempts += 1; 
    if (exitAttempts > 15)
    {
    Console.WriteLine("You have a strong willpower");
    break;
    }
    else if (exitAttempts > 10)
    {
    Console.WriteLine("\nWow you are persistant");
    }
    else if (exitAttempts > 5)
    {
    Console.WriteLine("\nWe are just getting started");
    }
    
    else if (exitAttempts == 1)
    {
    Console.WriteLine("\nAre you sure?");
    }
}
while (k != 'x');
    
    }
}
