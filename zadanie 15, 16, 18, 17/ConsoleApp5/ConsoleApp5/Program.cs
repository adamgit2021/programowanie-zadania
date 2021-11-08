using System;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad  15
            /*
            Console.WriteLine("Zad 15:");
            String UserInput;
            int UserNumber = 0;

            while (UserNumber<=86) //sprzadza czy liczba jest mniejsza, równa 86 jeżeli nie to pętla jest kontynuowana
            {
                Console.WriteLine("Podaj liczbę:");
                UserInput = Console.ReadLine();
                UserNumber = int.Parse(UserInput);//zamiana stringa na int
                if (UserNumber < 86)//jeżeli liczba jest mniejsza niż 86 
                {
                    Console.WriteLine("Twoja liczba jest za mała.Spróbuj jeszcze raz.");//to wyświetlony jest komunikat
                }
            }
            //*/


            //zad  16
            /*
            Console.WriteLine("Zad 16:");
            String UserInput = "0";
            int UserNumber = 0;
            float Srednia;

            while (true) 
            {

                Console.WriteLine("Podaj liczbę:");
                UserInput = Console.ReadLine();
                try { UserNumber = int.Parse(UserInput); }
                catch { }
                if (UserInput == "q" || UserInput == "Q")
                {
                    break;
                }


                while (UserNumber < 1 )
                {
                    Console.WriteLine("Wprowadzono nieprawidłową liczbę");
                    Console.WriteLine("Podaj liczbę:");
                    UserInput = Console.ReadLine();
                    try { UserNumber = int.Parse(UserInput); }
                    catch { }
                    if(UserInput=="q"|| UserInput == "Q")
                    {
                        break;
                    }

                }
                if (UserInput == "q" || UserInput == "Q")
                {
                    break;
                }

                Srednia = 0;
                int[] LiczbyCałkowite = new int[UserNumber];
                for (int i = 0; i <LiczbyCałkowite.Length; i++)
                {
                    LiczbyCałkowite[i] = i+1;
                    //Console.WriteLine(LiczbyCałkowite[i]);
                }
                for (int i = 0; i < LiczbyCałkowite.Length; i++)
                {
                    Srednia=Srednia+LiczbyCałkowite[i];
                    Console.WriteLine(Srednia);
                }
                Srednia = Srednia / UserNumber;
                Console.WriteLine("Wynik:");
                Console.WriteLine(Srednia);

            }
            //*/

            //zad  18
            /*
            Console.WriteLine("Zad 18:");
            String UserInput = "0";
            int UserNumber = 0;


            while (true) 
            {

                Console.WriteLine("Podaj liczbę:");
                UserInput = Console.ReadLine();
                try { UserNumber = int.Parse(UserInput); }
                catch { }

                while (UserNumber < 0 )
                {
                    Console.WriteLine("Wprowadzono nieprawidłową liczbę");
                    Console.WriteLine("Podaj liczbę:");
                    UserInput = Console.ReadLine();
                    try { UserNumber = int.Parse(UserInput); }
                    catch { }

                }
                Console.WriteLine("-------------------------");
                for (int i=0;i<= UserNumber; i++)
                {
                    Console.WriteLine(Math.Pow(2,i));
                }

            }
            //*/


            //zad  17
            /*
            Console.WriteLine("Zad 17:");
            String UserInput = "0";
            int UserNumber;
            Console.WriteLine("Wprowadź liczbę dodatnią:");
            UserInput = Console.ReadLine();
            UserNumber = int.Parse(UserInput);
            while (UserNumber < 0)
            {
                Console.WriteLine("Podałeś liczbę ujemną. Wprowadź liczbę dodatnią:");
                UserInput = Console.ReadLine();
                UserNumber = int.Parse(UserInput); 
            }
            Console.WriteLine("Wprowadziłeś liczbę dodatnią " + UserNumber + ". Koniec");
            //*/

        }
    }
}
