using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WeatherResponse
{
    public required Main main { get; set; }
    public required Wind wind { get; set; }
}

public class Main
{
    public required float temp { get; set; }
    public required int humidity { get; set; }
}

public class Wind
{
    public required float speed { get; set; }
}
