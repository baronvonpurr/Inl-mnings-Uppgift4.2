using System;
using System.Data.SqlTypes;

namespace Uppgift4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tal;
            string Mer;
            int Stor = 0;
            do
            {
                Console.WriteLine("Skriv ett heltal");
                Tal = int.Parse(Console.ReadLine());
                Console.WriteLine("Vill du skriva ett till heltal? (y)");
                Mer = Console.ReadLine().ToLower();
                if (Tal > Stor)
                {
                    Stor = Tal;
                }
            } while (Mer == "y");
            Console.WriteLine(Stor);
            Console.ReadKey();
        }
    }
}