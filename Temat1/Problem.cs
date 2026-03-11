using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temat1
{
    public class Problem
    {
        public int IloscPrzedmiotow { get; set; }
        public List<Przedmiot> Przedmioty { get; set; }

        public Problem(int n, int seed)
        {
            IloscPrzedmiotow = n;
            Przedmioty = [];

            Random random = new(seed); // inicjalizacja generatora liczb losowych z podanym seedem

            for (int i = 1; i <= n; i++)
            {
                int wartosc = random.Next(1, 11);
                int waga = random.Next(1, 11);

                Przedmioty.Add(new Przedmiot(i, wartosc, waga));
            }

        }
        public Result Solve(int rozmiar)
        {
            Result wynik = new();

            int calkowitaWaga = 0;
            int calkowitaWartosc = 0;

            var sort = Przedmioty.OrderByDescending(i => i.Ratio).ToList(); // sortowanie malejące

            foreach (var przedmiot in sort)
            {
                if (calkowitaWaga + przedmiot.Waga <= rozmiar)
                {
                    wynik.Przedmioty.Add(przedmiot.Id);
                    calkowitaWaga += przedmiot.Waga;
                    calkowitaWartosc += przedmiot.Wartosc;
                }
            }

            wynik.TotalWaga = calkowitaWaga;
            wynik.TotalWartosc = calkowitaWartosc;

            return wynik;
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine("Problem plecakowy: ");
            sb.AppendLine("Ilość Itemów: " + IloscPrzedmiotow);

            foreach (var przedmiot in Przedmioty)
            {
                sb.AppendLine(przedmiot.ToString());
            }
            return sb.ToString();
        }
    }
}
