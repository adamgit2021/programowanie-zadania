using System;

namespace zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");   //wyświetla napis - Podaj pierwszą liczbę:
            int a = int.Parse(Console.ReadLine());  //konwertuje zmienną string na int

            Console.WriteLine("Podaj drugą liczbę:");   //wyświetla napis - Podaj drugą liczbę:
            int b = int.Parse(Console.ReadLine());  //konwertuje zmienną string na int

            if(!(a+b<15) || a*b>=60)
            {
                Console.WriteLine("Liczby " + a + " i " + b + " spełniają warunek");
                //wyświetla napis dla spełnionych warunków
            }
            else
            {
                Console.WriteLine("Liczby " + a + " i " + b + " nie spełniają warunku");
                //wyświetls napis dla niespełnionego/niespełnionych warunków
            }
            Console.ReadKey();
        }
    }
}
