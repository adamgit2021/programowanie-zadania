using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //zadanie 24
                        
            //n - wielkość tablicy
            //m - rodzaj operacji (0 lub 1 lub 2)
            //l - liczba potrzebna do wykonania operacji ( np. ile ma zostać dodane do każdego elementu w tablicy)
                       
            //definiowanie wielkości tablicy
            Console.WriteLine("Podaj wielkość tablicy:");   //wyświetla "Podaj wielkość tablicy >=3:"
            int n = Int32.Parse(Console.ReadLine()); //zmienna n - wielkość tablicy
            //Console.WriteLine("Wielkość tablicy: " + tablica.Length);
            
            Random random = new Random();   //tworzy zmienną losową

            bool liczenie = true;   //tworzy zmienną o nazwie liczenie o wartości logicznej true (oznacza trwającą sekwencję liczenia)
            
            byte[] tablica = new byte[n]; //stworzenie tablicy o wielkości n i wartościach od 0 do 255 (byte)
            random.NextBytes(tablica);
            
            //wyświetla 1, 2 i 3 element tablicy
            Console.WriteLine(tablica[0]+"\n"+tablica[1]+"\n"+tablica[2]);
            
            Console.WriteLine("Wybierz rodzaj operacji:\n0 określa dodawanie,\n1 określa mnożenie,\n2 określa dzielenie");
            int m = Int32.Parse(Console.ReadLine());
            int l = Int32.Parse(Console.ReadLine());

            //tutaj muszę zrobić pętlę
            //*/

            /* przyklad do zadania - jak stworzyć losową zmienną
            Random random = new Random();
            byte[] zmienna = new byte[23];
            random.NextBytes(zmienna);
            Console.WriteLine(zmienna);
            //*/

            /* przyklad jak zbudowac tablice
            int[] tablica = new int[5] { 1, 3, 5, 7, 9 }; //tablica o wielkości 5 i elementach { 1, 3, 5, 7, 9 }
            Console.Write(tablica[4]); //wyswietla czwartą liczbe z tablica (czyli 9, bo liczy od 0)
            //*/

            /*
            //przykład pętli foreach
            string napis = "Napis";
            foreach (char znak in napis)
            {
                if (Char.IsUpper(znak))
                {
                    Console.WriteLine("Wielka litera: " + znak);
                }
                else if (Char.IsLower(znak))
                {
                    Console.WriteLine("Mała litera: " + znak);
                } 
            }
            //*/

            /*
            //zadanie 25
            bool pisanie;
            //List<char> lista = new List<char>();
            
            do
            {
                Console.WriteLine("Podaj znak:\nNaciśnij q, żeby zakończyć");
                char znak = Char.Parse(Console.ReadLine());

                if (znak == 'q' )
                {
                    pisanie = true;
                }
                else
                {
                    pisanie = false; 
                    //lista.Add(znak);
                }

            } while (pisanie == false);
            /*            
            foreach (char znak in lista)
            {
                if (Char.IsUpper(znak))
                {
                    Console.WriteLine("Wielka litera: " + znak);
                }
                else if (Char.IsLower(znak))
                {
                    Console.WriteLine("Mała litera: " + znak);
                }
            }
            //*/

            //*
            //zadanie 26
            bool pisanie = true;
            
            do
            {
                char produkt = Char.Parse(Console.ReadLine());
                Console.WriteLine("pisz dalej");

                if (produkt == 'n')
                {
                    Console.WriteLine("to koniec");
                    pisanie = false;
                }
                else 
                {
                    
                }
                if (produkt == 't')
                {
                    pisanie = true;
                }



            } while (pisanie == true);
            
            //*/
        }
    }
}
