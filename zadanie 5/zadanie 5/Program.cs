using System;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę większą od 1:");    //wyświetla napis - Podaj liczbę większą od 1:
            double a = double.Parse(Console.ReadLine());        //konwertuje zmienną string na double
            int b = (int)a;                                     //konwertuje zmienną double na int
             
            Console.WriteLine("wynik 1 =" + a);                 //wyświetla wprowadzoną liczbę
            Console.WriteLine("wynik 2 =" + b);                 //wyświetla liczbę skonwertowaną z double do int
            Console.ReadKey();
        }
    }
}
