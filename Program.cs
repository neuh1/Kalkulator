using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zdeklarowanie pierwszej liczby
            var number1 = 0;
            var number2 = 0;

            Console.WriteLine("Kalkulator");
            Console.WriteLine("//////////////////");

            Console.WriteLine("Wpisz pierwsza liczbe");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wpisz druga liczbe");
            number2 = Convert.ToInt32(Console.ReadLine());

            // Wybieranie opcji przez uzytkownika
            Console.WriteLine("a) Dodawanie");
            Console.WriteLine("b) Odejmowanie");
            Console.WriteLine("c) Mnozenie");
            Console.WriteLine("d) Dzielenie");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Twoj wynik : " + (number1 + number2));
                    break;
                case "b":
                    Console.WriteLine($"Twoj wynik : " + (number1 - number2));
                    break;
                case "c":   
                    Console.WriteLine($"Twoj wynik : " + (number1 * number2));
                    break;
                case "d":
                    Console.WriteLine($"Twoj wynik :" + (number1 / number2));
                    break;
            }

            Console.WriteLine("/////////////////////");
            Console.WriteLine("Kalkulator by vodo#6666 ");
            Console.WriteLine("/////////////////////");
            Console.WriteLine("Nacisnij dowolny przycisk aby zamknac kalkulator");
            Console.ReadKey();
        }

    }
}