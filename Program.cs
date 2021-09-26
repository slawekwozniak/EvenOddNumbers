using System;

namespace EvenOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczby parzyste i nieparzyste");
            Console.WriteLine("Podaj liczbę całkowitą:");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number % 2 == 0)
                        Console.WriteLine("Liczba parzysta");
                    else
                        Console.WriteLine("Liczba nieparzysta");

                    return;
                }
                else
                {
                    Console.WriteLine("\nWprowadzono niepoprawne dane. Podaj liczbę całkowitą:");
                }
            }
        }
    }
}
