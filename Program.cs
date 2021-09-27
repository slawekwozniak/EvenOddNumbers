using System;

namespace EvenOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Liczby parzyste i nieparzyste ***");
            while (true)
            {
                Console.WriteLine("\nPodaj liczbę całkowitą:");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number % 2 == 0)
                        Console.WriteLine("Liczba parzysta");
                    else
                        Console.WriteLine("Liczba nieparzysta");

                    Console.WriteLine("Czy chcesz kontynuować? Jeśli tak to naciśnij \'T\'");
                    if (Console.ReadLine().ToUpper() != "T") break;
                }
                else
                {
                    Console.WriteLine("Wprowadzono niepoprawne dane.");
                }
            }
        }
    }
}
