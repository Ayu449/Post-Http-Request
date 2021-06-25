using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;



namespace ConsoleApp3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var values = new Dictionary<string, string>
{
    { "name", "John Doe" },
    { "occupation", "gardener" }
};

            var data = new FormUrlEncodedContent(values);

            var url = "https://httpbin.org/post";
             var client = new HttpClient();

            HttpResponseMessage response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
