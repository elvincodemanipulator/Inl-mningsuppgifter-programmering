using System;
namespace Uppgift4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många minuter är din låt?");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många sekunder");
            int sek = int.Parse(Console.ReadLine());
            int totalsek = min * 60 + sek;
            if (totalsek > 165 && totalsek < 260)
            {
                Console.WriteLine("Vi kan spela din låt");
            }
            else
            {
                Console.WriteLine("Vi kommer inte spela din låt");
            }
            
        }
    }
}