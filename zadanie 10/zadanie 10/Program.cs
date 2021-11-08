using System;

namespace zadanie_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");   //wyświetla napis - Podaj pierwszą liczbę:
            int a = int.Parse(Console.ReadLine());  //konwertuje zmienną string na int

            Console.WriteLine("Podaj drugą liczbę:");   //wyświetla napis - Podaj drugą liczbę:
            int b = int.Parse(Console.ReadLine());  //konwertuje zmienną string na int

            Console.WriteLine("Wynik: " + a + '+' + b + '=' + (a + b));  //wyświetla - Wynik:

            Console.WriteLine();    //pusta linijka

            Console.WriteLine("Podaj trzecią liczbę:");   //wyświetla napis - Podaj trzecią liczbę:
            int c = int.Parse(Console.ReadLine());  //konwertuje zmienną string na int

            //mnoży sume (a+b) razy c i przypisuje wynik do c
            Console.WriteLine("Wynik: (" + a + '+' + b + ')' + '*' + c + '='  + (c *= (a + b))); 

            Console.WriteLine();    //pusta linijka

            Console.WriteLine("Podaj czwartą liczbę:");   //wyświetla napis - Podaj czwartą liczbę:
            int d = int.Parse(Console.ReadLine());  //konwertuje zmienną string na int

            //wyświetla wynik dzielenia modulo poprzedniego wyniku i przypisuje wartość do zmiennej d
            Console.WriteLine("Wynik: ((" + a + '+' + b + ')' + '*' + c / (a + b) + ')' + '%' + d + '=' + (d %= c));

            Console.ReadKey();
        }
    }
}
