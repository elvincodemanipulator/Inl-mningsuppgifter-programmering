using System;
namespace Uppgift4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal:");
            int tal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv in ett till tal:");
            int tal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            int val = int.Parse(Console.ReadLine());

            if (val == 1)
            {
                Console.WriteLine(tal1 + tal2);
            }
            else if (val == 2)
            {
                Console.WriteLine(tal1 - tal2);
            }
            else if (val == 3)
            {
                Console.WriteLine(tal1 * tal2);
            }
            else if (val == 4)
            {
                Console.WriteLine(tal1 / tal2);
            }
        }
    }
}