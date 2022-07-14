using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await DoAsync();
        }
        static async Task DoAsync()
        {
            using (var client = new HttpClient())
            {
                Console.WriteLine("Http Start");
                var url = "https://localhost:44343/api/ModelMemo";
                var response = await client.GetAsync(url);
                Console.WriteLine("Get Response");
                var result =  response.Content.ReadAsStringAsync();
    
                Console.WriteLine("Get Result");

                Console.WriteLine(result);

            }
        }
        
    }
}
