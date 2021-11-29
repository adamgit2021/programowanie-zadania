using System;

namespace zadanie_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 28

            //*
            //METODA 1 if/else
            //n - wielkość tablicy
            //m - rodzaj operacji (0 lub 1 lub 2)
            //liczbaDoOperacji - liczba potrzebna do wykonania operacji ( np. ile ma zostać dodane do każdego elementu w tablicy)

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
                tablica_int[i] = tablica[i];
                //Console.WriteLine(tablica[i]+"  "+tablica_int[i]); // sprawdzanie czy się przepisuje
            }

            bool wykonujDlaM = true;
            bool dzieleniePrzez0 = true;

            do
            {
                Console.WriteLine("Wybierz rodzaj operacji:\n0 określa dodawanie,\n1 określa mnożenie,\n2 określa dzielenie");
                int m = Int32.Parse(Console.ReadLine());
                                
                if (m == 0)
                {
                    Console.WriteLine("Dodawanie:");
                    Console.WriteLine("Podaj liczbe");
                    int liczbaDoOperacji = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < tablica.Length; i++)
                    {
                        tablica_int[i] = tablica_int[i] + liczbaDoOperacji;
                    }
                    wykonujDlaM = false;
                }
                else if (m == 1)
                {// jeżeli nie jest równa 0 sprawdzamy czy jest równa 1 
                    Console.WriteLine("Mnożenie:");
                    Console.WriteLine("Podaj liczbe");
                    int liczbaDoOperacji = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < tablica.Length; i++)
                    {
                        tablica_int[i] = tablica_int[i] * liczbaDoOperacji;
                    }
                    wykonujDlaM = false;
                }
                else if (m == 2)
                {//jeżeli nie jest równa 0 ani 1 to sprawdzamy czy jest równa 2 


                    Console.WriteLine("Dzielenie:");
                    do
                    {
                        
                        Console.WriteLine("Podaj liczbe");
                        int liczbaDoOperacji = Int32.Parse(Console.ReadLine());

                        if (liczbaDoOperacji == 0)
                        {
                            Console.WriteLine("Nie można dzielić przez 0");
                            wykonujDlaM = false;
                            dzieleniePrzez0 = true;
                        }
                        else
                        {
                            for (int i = 0; i < tablica.Length; i++)
                            {
                                tablica_int[i] = tablica_int[i] / liczbaDoOperacji;
                            }
                            wykonujDlaM = false;
                            dzieleniePrzez0 = false;
                        }
                    } while (dzieleniePrzez0 == true);
                }
                else
                { // jeżeli liczba nie jest równa 0,1 lub 2 to wyświetlamy komunikat
                    Console.WriteLine("Wprowadzona liczba jest nieprawidłowa");
                }
            } while (wykonujDlaM == true); 

            Console.WriteLine("Wypisanie wyniku w celu weryfikacji:");
            for (int i = 0; i < tablica_int.Length; i++)
            {
                Console.WriteLine(tablica_int[i]);
            }
            //*/

            /*
            //METODA 2 switch
            //n - wielkość tablicy
            //m - rodzaj operacji (0 lub 1 lub 2)
            //liczbaDoOperacji - liczba potrzebna do wykonania operacji ( np. ile ma zostać dodane do każdego elementu w tablicy)

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
                tablica_int[i] = tablica[i];
                //Console.WriteLine(tablica[i]+"  "+tablica_int[i]); // sprawdzanie czy się przepisuje
            }
            

            bool wykonujDlaM = true;
            bool dzieleniePrzez0 = true;

            do
            {
                Console.WriteLine("Podaj liczbę większą od 0");
                int liczbaDoOperacji = Int32.Parse(Console.ReadLine());
                switch (liczbaDoOperacji)
                {
                    case 0:
                        Console.WriteLine("Nie można dzielić przez 0");
                        dzieleniePrzez0 = true;
                        break;
                    default:
                        dzieleniePrzez0 = false;
                        do
                        {
                            Console.WriteLine("Wybierz rodzaj operacji:\n0 określa dodawanie,\n1 określa mnożenie,\n2 określa dzielenie");
                            int m = Int32.Parse(Console.ReadLine());

                            switch (m)
                            {
                                case 0:
                                    Console.WriteLine("Dodawanie:");
                                    for (int i = 0; i < tablica.Length; i++)
                                    {
                                        tablica_int[i] = tablica_int[i] + liczbaDoOperacji;
                                    }
                                    wykonujDlaM = false;
                                    break;
                                case 1:
                                    Console.WriteLine("Mnożenie:");
                                    for (int i = 0; i < tablica.Length; i++)
                                    {
                                        tablica_int[i] = tablica_int[i] * liczbaDoOperacji;
                                    }
                                    wykonujDlaM = false;
                                    break;
                                case 2:
                                    Console.WriteLine("Dzielenie:");
                                    for (int i = 0; i < tablica.Length; i++)
                                    {
                                        tablica_int[i] = tablica_int[i] / liczbaDoOperacji;
                                    }
                                    wykonujDlaM = false;
                                    break;
                                default:
                                    Console.WriteLine("Wprowadzona liczba jest nieprawidłowa");
                                    break;
                            }
                        } while (wykonujDlaM == true);
                        break;
                }
                
            } while (dzieleniePrzez0 == true);

            Console.WriteLine("Wypisanie wyniku w celu weryfikacji:");
            for (int i = 0; i < tablica_int.Length; i++)
            {
                Console.WriteLine(tablica_int[i]);
            }
            //*/

            /*
            //METODA 3 if/else + switch
            //n - wielkość tablicy
            //m - rodzaj operacji (0 lub 1 lub 2)
            //liczbaDoOperacji - liczba potrzebna do wykonania operacji ( np. ile ma zostać dodane do każdego elementu w tablicy)

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
                tablica_int[i] = tablica[i];
                //Console.WriteLine(tablica[i]+"  "+tablica_int[i]); // sprawdzanie czy się przepisuje
            }


            bool wykonujDlaM = true;
            bool dzieleniePrzez0 = true;

            do
            {
                Console.WriteLine("Podaj liczbę większą od 0");
                int liczbaDoOperacji = Int32.Parse(Console.ReadLine());

                if (liczbaDoOperacji == 0)
                {
                    Console.WriteLine("Nie można dzielić przez 0");
                    dzieleniePrzez0 = true;
                }
                else
                {

                    dzieleniePrzez0 = false;
                    do
                        {
                            Console.WriteLine("Wybierz rodzaj operacji:\n0 określa dodawanie,\n1 określa mnożenie,\n2 określa dzielenie");
                            int m = Int32.Parse(Console.ReadLine());

                            switch (m)
                            {
                                case 0:
                                    Console.WriteLine("Dodawanie:");
                                    for (int i = 0; i < tablica.Length; i++)
                                    {
                                        tablica_int[i] = tablica_int[i] + liczbaDoOperacji;
                                    }
                                    wykonujDlaM = false;
                                    break;
                                case 1:
                                    Console.WriteLine("Mnożenie:");
                                    for (int i = 0; i < tablica.Length; i++)
                                    {
                                        tablica_int[i] = tablica_int[i] * liczbaDoOperacji;
                                    }
                                    wykonujDlaM = false;
                                    break;
                                case 2:
                                    Console.WriteLine("Dzielenie:");
                                    for (int i = 0; i < tablica.Length; i++)
                                    {
                                        tablica_int[i] = tablica_int[i] / liczbaDoOperacji;
                                    }
                                    wykonujDlaM = false;
                                    break;
                                default:
                                    Console.WriteLine("Wprowadzona liczba jest nieprawidłowa");
                                    break;
                            }
                        } while (wykonujDlaM == true);
                        break;
                }

            } while (dzieleniePrzez0 == true);

            Console.WriteLine("Wypisanie wyniku w celu weryfikacji:");
            for (int i = 0; i < tablica_int.Length; i++)
            {
                Console.WriteLine(tablica_int[i]);
            }
            //*/

            /*
            //METODA 4 switch + if/else
            //n - wielkość tablicy
            //m - rodzaj operacji (0 lub 1 lub 2)
            //liczbaDoOperacji - liczba potrzebna do wykonania operacji ( np. ile ma zostać dodane do każdego elementu w tablicy)

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
                tablica_int[i] = tablica[i];
                //Console.WriteLine(tablica[i]+"  "+tablica_int[i]); // sprawdzanie czy się przepisuje
            }


            bool wykonujDlaM = true;
            bool dzieleniePrzez0 = true;

            do
            {
                Console.WriteLine("Podaj liczbę większą od 0");
                int liczbaDoOperacji = Int32.Parse(Console.ReadLine());
                switch (liczbaDoOperacji)
                {
                    case 0:
                        Console.WriteLine("Nie można dzielić przez 0");
                        dzieleniePrzez0 = true;
                        break;
                    default:
                        dzieleniePrzez0 = false;
                        do
                        {
                            Console.WriteLine("Wybierz rodzaj operacji:\n0 określa dodawanie,\n1 określa mnożenie,\n2 określa dzielenie");
                            int m = Int32.Parse(Console.ReadLine());

                            if (m==0)
                            {
                                Console.WriteLine("Dodawanie:");
                                for (int i = 0; i < tablica.Length; i++)
                                {
                                    tablica_int[i] = tablica_int[i] + liczbaDoOperacji;
                                }
                                wykonujDlaM = false;
                            }
                            else if (m==1)
                            {
                                Console.WriteLine("Mnożenie:");
                                for (int i = 0; i < tablica.Length; i++)
                                {
                                    tablica_int[i] = tablica_int[i] * liczbaDoOperacji;
                                }
                                wykonujDlaM = false;
                            }
                            else if (m==2)
                            {
                                Console.WriteLine("Dzielenie:");
                                for (int i = 0; i < tablica.Length; i++)
                                {
                                    tablica_int[i] = tablica_int[i] / liczbaDoOperacji;
                                }
                                wykonujDlaM = false;
                            }
                            else
                            {
                                Console.WriteLine("Wprowadzona liczba jest nieprawidłowa");
                            }
                            
                        } while (wykonujDlaM == true);
                        break;
                }

            } while (dzieleniePrzez0 == true);

            Console.WriteLine("Wypisanie wyniku w celu weryfikacji:");
            for (int i = 0; i < tablica_int.Length; i++)
            {
                Console.WriteLine(tablica_int[i]);
            }

            //*/
        }
    }
}
