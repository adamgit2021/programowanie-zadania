using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 29
            Console.WriteLine("Podaj pierwszą liczbę");
            int liczba1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę");
            int liczba2 = Int32.Parse(Console.ReadLine());

            bool max1; //pierwsza liczba jest większa

            if (liczba1 > liczba2)
            {
                max1 = true;
                Console.WriteLine("Max: " + liczba1);
            }
            else
            {
                max1 = false;
                Console.WriteLine("Max: " + liczba2);
            }

        }
    }
}
