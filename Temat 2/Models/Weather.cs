using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Weather
{
    public int Id { get; set; }

    public float Temperature { get; set; }

    public int Humidity { get; set; }

    public float WindSpeed { get; set; }

    public DateTime Date { get; set; }

    public int CityId { get; set; }

    public required City City { get; set; }
}
