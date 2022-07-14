using ModelMemo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ModelMemoConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            
            string url = "https://localhost:44343/api/ModelMemo";
            using(var client = new HttpClient())
            {
                // 데이터 전송 (저장)
                    // #1 Data 생성
                var json = JsonConvert.SerializeObject(new Model()
                {
                    Title = "Win Console",
                    IsDone = true
                });
                    // #2 Data Body 생성
                var post = new StringContent(json, Encoding.UTF8, "application/json");
                    // #3 전송
                await client.PostAsync(url, post);

                // 데이터 수신 (출력)
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();
                var todos = JsonConvert.DeserializeObject<List<Model>>(result);

                foreach (var item in todos)
                {
                    Console.WriteLine($"[{item.Id}] {item.Title} : ${item.IsDone}");
                }
                
            }



        }
    }
}

