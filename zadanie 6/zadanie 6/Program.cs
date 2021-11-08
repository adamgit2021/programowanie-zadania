using System;

namespace zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Podaj pierwszą liczbę:");    //wyświetla napis - Podaj pierwszą liczbę:
            int a = int.Parse(Console.ReadLine());  //konwertuje zmienną string na int

            Console.WriteLine("Podaj drugą liczbę:");   //wyświetla napis - Podaj drugą liczbę:
            int b = int.Parse(Console.ReadLine());  //konwertuje zmienną string na int

            Console.WriteLine("wynik dodawania liczby a i b = " + (a+b));  //wynik dodawania liczby a i b
            Console.WriteLine("wynik mnożenia liczby a i b = " + a*b);   //wynik mnożenia liczby a i b
            Console.WriteLine("wynik modulo = " + a%b);  //wynik modulo

            Console.ReadKey();
        }
    }
}
