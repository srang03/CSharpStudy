using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TaskRunMethod
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var service = new WeatherService();
            var forcast = await service.GetForcastAsync(DateTime.Now);

            foreach(var w in forcast)
            {
                Console.WriteLine($"{w.Date}\t{w.TemperatureC}\t{w.TemperatureF}\t{w.Summary}");
            }
        }
    }
    public class WeatherForcast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }
    }

    public class WeatherService
    {
        private static string[] summaries = new string[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm"," Balmy", "Hot"
        };

        public Task<List<WeatherForcast>> GetForcastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(idx => new WeatherForcast()
            {
                Date = startDate.AddDays(idx),
                TemperatureC = rng.Next(-20, 40),
                Summary = summaries[rng.Next(summaries.Length)],
            }).ToList());
        }

    }
}
