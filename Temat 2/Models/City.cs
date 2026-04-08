using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class City
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        // relacja 1:N
        public List<Weather> Weathers { get; set; } = new();
    }
