using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
public class WeatherService
{
    private ApiService api = new ApiService();

    public async Task<Weather> GetWeather(string cityName)
    {
        using var db = new AppDbContext();

        // sprawdź czy miasto istnieje
        var city = db.Cities.FirstOrDefault(c => c.Name == cityName);

        if (city != null)
        {
            // sprawdź czy mamy dane (np. dzisiejsze)
            var weather = db.Weathers
                .FirstOrDefault(w => w.CityId == city.Id && w.Date.Date == DateTime.Today);

            if (weather != null)
            {
                Console.WriteLine("Dane z bazy!");
                return weather;
            }
        }

        // pobierz z API
        Console.WriteLine("Pobieram z API...");
        var apiData = await api.GetWeather(cityName);

        // jeśli city nie istnieje → dodaj
        if (city == null)
        {
            city = new City { Name = cityName };
            db.Cities.Add(city);
            db.SaveChanges();
        }

        // zapisz pogodę
        var newWeather = new Weather
        {
            Temperature = apiData.main.temp,
            Humidity = apiData.main.humidity,
            WindSpeed = apiData.wind.speed,
            Date = DateTime.Now,
            CityId = city.Id
        };

        db.Weathers.Add(newWeather);
        db.SaveChanges();

        return newWeather;
    }
    public void ShowAll()
    {
        using var db = new AppDbContext();

        var list = db.Weathers
            .OrderByDescending(w => w.Date)
            .Where(w => w.Date.Date == DateTime.Today)
            .Include(w => w.City)
            .ToList();

        foreach (var w in list)
        {
            Console.WriteLine($"{w.City.Name} | {w.Temperature}°C | {w.Humidity}% | {w.WindSpeed} | {w.Date}");
        }
    }
    public void FilterByTemperature(float minTemp)
    {
        using var db = new AppDbContext();

        var list = db.Weathers
            .Where(w => w.Temperature > minTemp)
            .Where(w => w.Date.Date == DateTime.Today)
            .Include(w => w.City)
            .ToList();

        foreach (var w in list)
        {
            Console.WriteLine($"{w.City.Name} | {w.Temperature}°C | {w.Humidity}% | {w.WindSpeed}");
        }
    }
    public void SortByTemperature()
    {
        using var db = new AppDbContext();

        var list = db.Weathers
            .OrderBy(w => w.Temperature)
            .Where(w => w.Date.Date == DateTime.Today)
            .Include(w => w.City)
            .ToList();

        foreach (var w in list)
        {
            Console.WriteLine($"{w.City.Name} | {w.Temperature}°C");
        }
    }
    public void Delete(int id)
    {
        using var db = new AppDbContext();

        var weather = db.Weathers.FirstOrDefault(w => w.Id == id);

        if (weather != null)
        {
            db.Weathers.Remove(weather);
            db.SaveChanges();
            Console.WriteLine("Usunięto!");
        }
        else
        {
            Console.WriteLine("Nie znaleziono rekordu");
        }
    }
}

