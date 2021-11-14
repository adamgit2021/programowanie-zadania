using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 19
            /*
            string login;   //tworzy zmienną login
            string hasło;   //tworzy zmienną hasło
            bool logowanie = true;  //tworzy zmienną o nazwie logowanie o wartości logicznej true (oznacza trwającą sekwencję logowania)
            int liczba_prób = 3;  //tworzy zmienną całkowitą próba, o wartości 3 (oznacza maksymalną liczbę prób logowania)
            bool zalogowany = false;    //tworzy zmienną o nazwie zalogowany o wartości logicznej false
                                        //(oznacza, że użytkownik nie został (jeszcze) zalogowany

            //tworzy pętlę do while
            do
            {
                Console.WriteLine("Podaj login i hasło");   //wyświetla "Podaj login i hasło"
                Console.WriteLine("Login: ");   //wyświetla "Login: "
                login = Console.ReadLine(); //użytkownik wprowadza wartość zmiennej login
                Console.WriteLine("Hasło: ");   //wyświetla "Hasło: "
                hasło = Console.ReadLine(); //użytkownik wprowadza wartość zmiennej hasło
            
                if ((login=="użytkownik") && (hasło=="hasło"))  //warunek dla którego instrukcja if jest wykonywana (poprawny login i hasło)
                {
                    Console.WriteLine("prawidłowy login i hasło");  //wyświetla "prawidłowy login i hasło"
                    logowanie = false;  //przypisuje wartość zmiennej logowanie jako false
                    zalogowany = true;  //przypisuje wartość zmiennej zalogowany jako true
                }
                //warunek dla którego instrukcja else jest wykonywana (warunek dla if nie jest spełniony)
                else
                {
                    Console.WriteLine("Logowanie nie powiodło się");    //wyświetla "Logowanie nie powiodło się"
                    liczba_prób--;    //jeśli warunek próba logowania nie powiodła się, zmniejsza liczbę prób logowania

                    //wyświetla "pozostało " +liczba pozostłych prób+ " prób logowania"
                    Console.WriteLine("pozostało " +liczba_prób+ " prób logowania");

                    //warunek dla którego instrukcja if jest wykonywana (liczba prób jest mniejsza od 1, czyli pozostało 0 prób)
                    if (liczba_prób<1)    
                    {
                        logowanie = false;  //przypisuje wartość zmiennej logowanie jako false
                    }
                }
            } while (logowanie==true); //jeżeli trwa sekwencja logowania powtórz pętlę
            if (zalogowany==true)   //instrukcja if wykonywana, jeśli zalogowanie się powiodło
            {
                Console.WriteLine("zalogowany");    //wyświetla "zalogowany"
            }
            //instrukcja else wykonywana, jeśli logowanie się nie powiodło (warunek if nie został spełniony)
            else
            {
                Console.WriteLine("niezalogowany"); //wyświetla "niezalogowany"
            }
            //*/

            //zadanie 20
            /*
            Console.WriteLine("Podaj palindrom");   //wyświetla "Podaj palindrom"
            string wyraz = Console.ReadLine();  //tworzy zmienną string o nazwie wyraz i przypisuje jej wartość podaną przez użytkownika
            
            //tworzy zmienną int o nazwie długość_wyrazu, której wartość jest sczytywana ze zmiennej o nazwie wyraz
            //-1 to zmniejszenie liczby znaków o 1, ponieważ system liczy od 0
            int długość_wyrazu = wyraz.Length-1;
            
            //utworzenie zmiennj bool o nazwie jest_palindromem i przypisanie jej wartości początkowej jako true
            //oznacza, że wyraz jest domyślnie palindromem
            bool jest_palindromem = true;
            
            //tworzy pętlę for dla połowy długości wyrazu
            for (int i = 0; i < wyraz.Length/2; i++)
            {
                //Console.WriteLine(wyraz[i]);  //wyświetla pierwszą (i kolejne) literę wyrazu
                //Console.WriteLine(wyraz[długość_wyrazu - i]); //wyświetla ostatnią (i kolejne) literę wyrazu
                
                if (wyraz[i] == wyraz[długość_wyrazu - i])
                {
                    //Console.WriteLine("znaki są takie same"); //wyświetla "znaki są takie same"
                }
                else
                {
                    //Console.WriteLine("znaki nie są takie same"); //wyświetla "znaki nie są takie same"
                    jest_palindromem = false; //przypisuje wartość zmiennej jako false (wyraz nie jest palindromem)
                }

            }
            if (jest_palindromem == true)   //sprawdza, czy wyraz nadal jest palindromem (domyślnie jest) i wykonuje instrukcję
            {
                Console.WriteLine("jest palindromem");  //wyświetla "jest palindromem"
            }
            
            //wykonuje, jeśli warunek nie jest spełniony (wyraz nie jest palindromem)
            else
            {
                Console.WriteLine("nie jest palindromem");  ////wyświetla "nie jest palindromem"
            }
            //*/

            //zadanie 21
            /*
            Console.WriteLine("Podaj długość boku kwadratu:");  //wyświetla "Podaj długość boku kwadratu:"

            //tworzy zmienną int o nazwie arraySize, definiowaną przez użytkownika (użytkownik wybiera wysokość i szerokość tablicy 2D)
            //jest parsowana do int, ponieważ wartość podana przez użytkownika jest typem string
            int arraySize = Int32.Parse(Console.ReadLine());

            //tworzy tablicę 2D (jednak nie potrzebne), ponieważ stworzyłem tablicę 2D z tablicy jednowymiarowej
            //char[,] tablica = new char[arraySize,arraySize];  
                                                                
            
            //pierwsza instrukcja for, wykonywana dla y < wielkość tablicy (y to wysokość (liczba wierszy) tablicy)
            for (int y = 0; y < arraySize; y++)
            {
                //druga instrukcja for, wykonywana dla x < wielkość tablicy (x to szerokość (liczba kolumn) tablicy)
                for (int x = 0; x < arraySize; x++)
                {
                    Console.Write('K'); //przypisuje literę K dla każdej komórki w tablicy
                }
                Console.WriteLine();    //pusta linijka (oznacza, że każdy wiersz ma być w następnej linijce)
                                        //bez tego, wszystko będzie w jednej linijce, ponieważ jest to tablica jednowymiarowa
            }
            //*/

            //zadanie 22
            /*
            //tworzy zmienną int o nazwie arraySize, definiowaną przez użytkownika (użytkownik wybiera długość tablicy jednowymiarowej)
            //jest parsowana do int, ponieważ wartość podana przez użytkownika jest typem string
            int arraySize = Int32.Parse(Console.ReadLine());
            int[] tablica = new int[arraySize]; //tworzy tablicę jednowymiarową z typem danych int, o długości podanej przez użytkownika
            for (int y = 0; y < arraySize; y++) //instrukcja for dla każdego elementu mniejszego od długości tablicy
            {
                tablica[y] = y + 100;   //do każdego elementu tablicy dodaje 100 (pierwszy element w tablicy to 0)
                //Console.WriteLine(y +100);    //wyświetla wartość elementu po dodaniu 100 (użyte w kolejnej instrukcji for)
            }
            for (int y = 0; y < arraySize; y++) //instrukcja for dla każdego elementu mniejszego od długości tablicy
            {
                //tablica[y] = y + 100; //do każdego elementu tablicy dodaje 100 (pierwszy element w tablicy to 0)
                                        //użyte w poprzedniej instrukcji for

                //wyświetla "Wartość " + numer elementu + " elementu tablicy to: "+ wartość elementu po dodaniu 100
                Console.WriteLine("Wartość " + y + " elementu tablicy to: " + tablica[y]);

            }
            //*/

            //zadanie 23
            /*
            Console.WriteLine("Podaj wysokość tablicy:");   //wyświetla "Podaj wysokość tablicy:"
            //tworzy zmienną int o nazwie m, definiowaną przez użytkownika
            //jest parsowana do int, ponieważ wartość podana przez użytkownika jest typem string
            int m = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Podaj szerokość tablicy:");   //wyświetla "Podaj szerokość tablicy:"
            //tworzy zmienną int o nazwie n, definiowaną przez użytkownika
            //jest parsowana do int, ponieważ wartość podana przez użytkownika jest typem string
            int n = Int32.Parse(Console.ReadLine());

            int[,] tablica = new int[m,n];  //tworzy tablicę dwuwymiarową, o wysokości m i szerokości n

            for (int y = 0; y < m; y++) //pierwasza instrukcja dla każdego elementu mniejszego od m
            {
                for (int x = 0; x < n; x++) //pierwsza instrukcja dla każdego elementu mniejszego od n 
                {
                    //prosi o podanie wartości dla elementów tabeli. Elementy muszą być liczbami całkowitymi (x i y to zmienne int)
                    //wartości są zapisywane od lewej do prawej i od góry do dołu
                    Console.WriteLine("Podaj wartość [" + x +','+y+"]");
                    
                    //sczytuje wartości podane przez użytkownika dla elementów tabeli
                    //parsuje do int, ponieważ wartości podane przez użytkownika są typem string
                    tablica[y,x]= Int32.Parse(Console.ReadLine());
                }
                
            }
            for (int y = 0; y < m; y++) //druga instrukcja dla każdego elementu mniejszego od m
            {
                for (int x = 0; x < n; x++) //druga instrukcja dla każdego elementu mniejszego od n
                {
                    Console.Write(tablica[y,x]);    //wyświetla gotową tablicę
                }
                Console.WriteLine();    //pusta linijka (oznacza, że każdy wiersz ma być w następnej linijce)
                                        //bez tego, wszystko będzie w jednej linijce, i będzie wyglądać jak tablica jednowymiarowa
            }
            //*/
        }
    }
}
