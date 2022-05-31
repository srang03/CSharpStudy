using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitSimple
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await DoAsync();
        }

        // 비동기 메서드 선언 async Task
        static async Task DoAsync()
        {
            using (var client = new HttpClient()) // 웹 API 호출
            {
                var res = await client.GetAsync("http://www.dforensic.com/main/index.jsp");
                var content = await res.Content.ReadAsStringAsync();

                Console.WriteLine(content);
            }
        }
    }
}
