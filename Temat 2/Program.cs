using System;

class Program
{
    static async Task Main(string[] args)
    {
        WeatherService service = new WeatherService();

        while (true)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Pobierz pogodę");
            Console.WriteLine("2. Pokaż wszystkie dane");
            Console.WriteLine("3. Filtruj (temp > X)");
            Console.WriteLine("4. Sortuj po temperaturze");
            Console.WriteLine("5. Usuń dane");
            Console.WriteLine("0. Wyjście");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Podaj miasto: ");
                    string city = Console.ReadLine();
                    var weather = await service.GetWeather(city);
                    Console.WriteLine($"Temp: {weather.Temperature}");
                    break;

                case "2":
                    service.ShowAll();
                    break;

                case "3":
                    Console.Write("Podaj minimalną temperaturę: ");
                    float temp = float.Parse(Console.ReadLine());
                    service.FilterByTemperature(temp);
                    break;

                case "4":
                    service.SortByTemperature();
                    break;

                case "5":
                    Console.Write("Podaj ID do usunięcia: ");
                    int id = int.Parse(Console.ReadLine());
                    service.Delete(id);
                    break;

                case "0":
                    return;
            }
        }
    }
}
