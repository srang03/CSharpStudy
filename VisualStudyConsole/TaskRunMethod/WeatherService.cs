using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskRunMethod
{
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
