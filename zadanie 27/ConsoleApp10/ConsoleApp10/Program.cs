using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 27
            Console.WriteLine("Podaj pierwszą liczbę");
            int liczba1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę");
            int liczba2 = Int32.Parse(Console.ReadLine());

            bool wykonuj_petle = true;

            do
            {
                Console.WriteLine("0 - dodaj\n1 - pomnóż\n2 - podziel\n3 - odejmij");
                int dzialanie = Int32.Parse(Console.ReadLine());

                switch (dzialanie)
                {
                    case 0:
                        Console.WriteLine(liczba1 + liczba2);
                        wykonuj_petle = false;
                        break;
                    case 1:
                        Console.WriteLine(liczba1 * liczba2);
                        wykonuj_petle = false;
                        break;
                    case 2:
                        Console.WriteLine(liczba1 / liczba2);
                        wykonuj_petle = false;
                        break;
                    case 3:
                        Console.WriteLine(liczba1 - liczba2);
                        wykonuj_petle = false;
                        break;

                    default:
                        Console.WriteLine("błąd: podaj 0, 1, 2, 3");
                        break;
                }
            } while (wykonuj_petle == true);
        }
    }
}
