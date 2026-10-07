using System;
using System.Collections.Concurrent;
using System.Timers;
namespace Inlämningsuppgift2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet?");
            Console.WriteLine("j = ja");
            Console.WriteLine("n = nej");
            string val = Console.ReadLine().ToLower();
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder <= 22 && val == "j")
            {
                Console.WriteLine("Vi vill gärna annställa dig.");
            }
            else
            {
                Console.WriteLine("Vi letar tyvär efter annan personal just nu.");
            }
        }
        
    }
}