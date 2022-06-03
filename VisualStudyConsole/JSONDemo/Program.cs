using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONDemo
{
    public class Shirt
    {
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public List<string> Sizes { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Shirt shirt = new Shirt()
            {
                Name = "Hi",
                Created = DateTime.Now,
                Sizes = new List<string>() { "Small", "medium", "Large" }
            };

            string json = JsonConvert.SerializeObject(shirt, Formatting.Indented);
            Console.WriteLine(json);

            var shrit_value = JsonConvert.DeserializeObject<Shirt>(json);
            Console.WriteLine($"{shrit_value.Name}");

        }
    }
}
