using System;
using System.Collections.Generic; // dla List< >
using System.Linq; // dla OrderByDescending() i Take()
using System.Text;

namespace Temat1
{
    // Zadanie 1: Problem plecakowy - algorytm zachłanny
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj ilość przedmiotów:");
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Podaj seed:");
            int seed = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Podaj rozmiar plecaka:");
            int rozmiar = int.Parse(Console.ReadLine()!);

            Problem problem = new(n, seed);

            Console.WriteLine();
            Console.WriteLine(problem);

            Result wynik = problem.Solve(rozmiar);

            Console.WriteLine("Wynik: ");
            Console.WriteLine(wynik);
        }
    }


}