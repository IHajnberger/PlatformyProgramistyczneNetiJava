using System; // przestrzen nazw
namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj górny zakres liczb: ");
            int zakres = Convert.ToInt32(Console.ReadLine());

            FizzBuzz fizzBuzz = new FizzBuzz(zakres);
            fizzBuzz.Wyswietl();

            Console.ReadLine();
        }
    }
    class FizzBuzz
    {
        private int zakresFB;
        public FizzBuzz(int zakres)
        {
            zakresFB = zakres;
        }
        public void Wyswietl()
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


