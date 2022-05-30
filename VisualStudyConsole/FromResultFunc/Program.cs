using System;
using System.Linq;
using System.Threading.Tasks;

namespace FromResultFunc
{
    public class WeatherForecast
    {
        public DateTime date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }
    }

    public class WeatherForecastService
    {
        private static string[] summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast()
            {
                date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = summaries[rng.Next(summaries.Length)]
            }).ToArray());
        }
    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var service = new WeatherForecastService();
            var forecasts = await service.GetForecastAsync(DateTime.Now);

            Console.WriteLine("Date \t Temp. (C) \t Temp.  (F) \t Temp.");
            foreach(var forecast in forecasts)
            {
                Console.WriteLine($"{forecast.date} \t {forecast.TemperatureC} \t {forecast.TemperatureF} \t {forecast.Summary}");
            }
        }
    }
}
