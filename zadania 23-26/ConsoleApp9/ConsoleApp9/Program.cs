using System;
using System.Collections.Generic; //zad 26  

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
           
            byte[] tablica = new byte[n]; //stworzenie tablicy o wielkości n i wartościach od 0 do 255 (byte)
            random.NextBytes(tablica);
            
            //mamy tablicę typu byte, natomisat do obliczeń potrzebujemy tablicy typu int 
            int[] tablica_int = new int[n];

            for (int i = 0; i < tablica_int.Length; i++) // ten for przepisuje tablicę byte do tablicy int 
            {
                tablica_int[i]=tablica[i]; 
                //Console.WriteLine(tablica[i]+"  "+tablica_int[i]); // sprawdzanie czy się przepisuje
            }
            
            //wyświetla 1, 2 i 3 element tablicy
           // Console.WriteLine(tablica[0]+"\n"+tablica[1]+"\n"+tablica[2]);
            
            Console.WriteLine("Wybierz rodzaj operacji:\n0 określa dodawanie,\n1 określa mnożenie,\n2 określa dzielenie");
            int m = Int32.Parse(Console.ReadLine());
            int liczbaDoOperacji = Int32.Parse(Console.ReadLine());

            // sprawdzamy czy liczba jest równa 0
            if(m==0){
                Console.WriteLine("Dodawanie:");
                for (int i = 0; i < tablica.Length; i++)
                {
                    tablica_int[i]=tablica_int[i]+liczbaDoOperacji;    
                }    
            }
            else if(m==1){// jeżeli nie jest równa 0 sprawdzamy czy jest równa 1 
                Console.WriteLine("Mnożenie:");
                for (int i = 0; i < tablica.Length; i++)
                {
                    tablica_int[i]=tablica_int[i]*liczbaDoOperacji;    
                }
            }
            else if(m==2){//jeżeli nie jest równa 0 ani 1 to sprawdzamy czy jest równa 2 
                Console.WriteLine("Dzielenie:");
                if(liczbaDoOperacji==0){
                   Console.WriteLine("Nie można dzielić przez 0");
                   return;// w przypdaku w którym użytkownik spróbuje podzielić przez zero funkcja zostaje przerwana
                }
                else{
                    for (int i = 0; i < tablica.Length; i++)
                    {
                        tablica_int[i]=tablica_int[i]/liczbaDoOperacji;    
                    }
                }
            }
            else{ // jeżeli liczba nie jest równa 0,1 lub 2 to wyświetlamy komunikat
                Console.WriteLine("Wprowadzona liczba jest nieprawidłowa");
            }

            Console.WriteLine("Wypisanie wyniku w celu weryfikacji:");
            for (int i = 0; i < tablica_int.Length; i++)
            {
                Console.WriteLine(tablica_int[i]);
            }

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

            //*
            //zadanie 25
            /* 
            String napis = Console.ReadLine();           
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
                else if (Char.IsDigit(znak)){
                    Console.WriteLine("Liczba: " + znak);
                }
                else if (Char.IsPunctuation(znak)){
                    Console.WriteLine("Znak interpunkyjny: " + znak);
                }
                else if (Char.IsWhiteSpace(znak)){
                    Console.WriteLine("Biała Spacja: " + znak);
                }
            }
            //*/

            /*
            //zadanie 26
            bool pisanie = true;
            char klawisz_wyboru = 'a';
            List<string> lista_zakupów = new List<string>();
            do
            {
                Console.WriteLine("Aby zakończyć tworzenie liszty napisz n");
                Console.WriteLine("Aby Wpisać następny produkt do listy napisz t");
                klawisz_wyboru = Char.Parse(Console.ReadLine());
                if (klawisz_wyboru == 'n')
                {
                    //Console.WriteLine("to koniec");
                    pisanie = false;
                }
                else if (klawisz_wyboru == 't')
                {
                    //Console.WriteLine("pisz dalej");
                    pisanie = true;
                    Console.WriteLine("Co dodać?:");
                    lista_zakupów.Add(Console.ReadLine());
                }
            } while (pisanie == true);

            lista_zakupów.Sort();// sortujemy listę 
            Console.WriteLine("Lista:  ");

            foreach (string temp in lista_zakupów)
            { //drukujemy listę 
                Console.WriteLine(temp);
            }




            //*/
        }
    }
}
