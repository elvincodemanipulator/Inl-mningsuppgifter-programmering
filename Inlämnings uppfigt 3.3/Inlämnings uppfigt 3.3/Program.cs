using System;
namespace uppgift3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra vår bil?");
            int timmar = int.Parse(Console.ReadLine());
            int kostnad = timmar * 80;
            if (kostnad >= 950)
            {
                Console.WriteLine("Det kommer att kosta 950kr.");
            }

            else
            {
                Console.WriteLine("Det kommer att kosta " + kostnad + "kr.");
            }
        }
    }
}