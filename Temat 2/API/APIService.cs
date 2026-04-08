using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

public class ApiService
{
    private HttpClient client = new();
    private string apiKey = "76c6f4d4f5662aa5f2df0e6691cf5aef";

    public async Task<WeatherResponse> GetWeather(string city)
    {
        string call = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

        string response = await client.GetStringAsync(call);

        return JsonSerializer.Deserialize<WeatherResponse>(
            response,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true

            });
    }
}