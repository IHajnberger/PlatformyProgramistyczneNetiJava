using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temat1
{
    public class Result // klasa do przechowywania wyniku rozwiązania problemu plecakowego
    {
        public List<int> Przedmioty { get; set; } = [];
        public int TotalWartosc { get; set; } // suma wartości przedmiotów w plecaku
        public int TotalWaga { get; set; } // suma wag przedmiotów w plecaku
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("Przedmioty w plecaku:");
            foreach (var przedmiot in Przedmioty)
            {
                sb.AppendLine(przedmiot + " ");
            }
            sb.AppendLine();
            sb.AppendLine("Wartość całkowita: " + TotalWartosc);
            sb.AppendLine("Waga całkowita: " + TotalWaga);
            return sb.ToString();
        }
    }
}
