using System;

namespace HearingTest
{
  class Program
  {
    static void Main(string[] args)
    {
      int volume = 7;
      switch (volume) 
      {
        case 1:
          Console.WriteLine("You are hearing Silent Sound");
          break;
        case 2:
          Console.WriteLine("You are hearing Very Low Sound");
          break;
        case 3:
          Console.WriteLine("You are hearing Low Sound");
          break;
        case 4:
          Console.WriteLine("You are hearing Medium Sound");
          break;
        case 5:
          Console.WriteLine("You are hearing Loud Sound\n Not good for your ears ");
          break;
        case 6:
          Console.WriteLine("You are hearing Very Loud\n Not good for your ears ");
          break;
        case 7:
          Console.WriteLine("You are hearing extremely Loud Sound\nHearing Damage");
          break;
      }    
    }
  }
}
