using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WeatherResponse
{
    public Main main { get; set; }
    public Wind wind { get; set; }
}

public class Main
{
    public float temp { get; set; }
    public int humidity { get; set; }
}

public class Wind
{
    public float speed { get; set; }
}
