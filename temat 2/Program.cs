using System;

class Program
{
    static async Task Main(string[] args)
    {
        ApiService api = new();

        Console.Write("Podaj miasto: ");
        string city = Console.ReadLine();

        var weather = await api.GetWeather(city);

        Console.WriteLine($"Temperatura: {weather.main.temp} °C");
        Console.WriteLine($"Wilgotność: {weather.main.humidity} %");
        Console.WriteLine($"Prędkość wiatru: {weather.wind.speed} m/s");
    }
}
