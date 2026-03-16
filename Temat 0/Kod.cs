using System; // przestrzeń nazw
namespace FizzBuzzApp
{
    class Program // klasa główna programu
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj górny zakres liczb: ");
            int zakres = Convert.ToInt32(Console.ReadLine());

            FizzBuzz fizzBuzz = new(zakres);
            fizzBuzz.Wyswietl();

            Console.ReadLine();
        }
    }
    class FizzBuzz // klasa odpowiedzialna za logikę FizzBuzz
    {
        private int zakresFB; // pole przechowujące górny zakres liczb
        public FizzBuzz(int zakres)
        {
            zakresFB = zakres;
        }
        public void Wyswietl() // metoda wyświetlająca wyniki FizzBuzz
        {
            for (int i = 1; i <= zakresFB; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) 
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}


