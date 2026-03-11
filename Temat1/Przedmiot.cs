using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temat1
{
    public class Przedmiot
    {
        public int Id { get; set; }
        public int Wartosc { get; set; }
        public int Waga { get; set; }

        public double Ratio // stosunek opłacalności do wagi
        {
            get { return (double)Wartosc / Waga; }
        }
        public Przedmiot(int id, int wartosc, int waga)
        {
            Id = id;
            Wartosc = wartosc;
            Waga = waga;
        }

        public override string ToString() // nadpisanie metody ToString() dla lepszej czytelności
        {
            return $"Przedmiot(Id: {Id}, Value: {Wartosc}, Weight: {Waga}, Ratio: {Ratio:F2})";
        }
    }
}
