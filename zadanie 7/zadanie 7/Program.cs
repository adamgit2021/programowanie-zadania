using System;

namespace zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");   //wyświetla napis - Podaj pierwszą liczbę:
            int a = int.Parse(Console.ReadLine());  //konwertuje zmienną string na int

            Console.WriteLine("Podaj drugą liczbę:");   //wyświetla napis - Podaj drugą liczbę:
            int b = int.Parse(Console.ReadLine());  //konwertuje zmienną string na int

            if (a >= b) //warunek logiczny
            {
                Console.WriteLine("pierwsza liczba " + a + " jest większa lub równa drugiej " + b); //wyświetla, jeśli warunek jest spełniony
            }
            else
            {
                Console.WriteLine("pierwsza liczba " + a + " jest mniejsza od drugiej " + b);   //wyświetla, jeśli warunek nie jest spełniony
            }
            Console.ReadKey();
        }
    }
}
