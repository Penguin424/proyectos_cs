using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HttpPrueba
{
    internal class Program
    {
        HttpClient client = new HttpClient();
             
        static void Main(string[] args)
        {
            Program program = new Program();

            program.GetTodoItems();

            Console.ReadKey();
        }

        private async Task GetTodoItems()
        {
            HttpResponseMessage response = await client.GetAsync("https://cosbiome.online/cosbiomepedidos?_limit=100&createdAt_gte=2021-10-01T12%3A00%3A00-06%3A00");

            string res = await response.Content.ReadAsStringAsync();
            var prueba = JsonConvert.DeserializeObject<List<IPedidoCosbiomeDb>>(res);
            List<double> list = prueba.Select((data) => (double)data.Total).ToList();
            double Total = list.Aggregate(0, (double value, double nextValue) => value + nextValue);


            Console.WriteLine("El total de los pedidos es: {0:F}", Total);
        }
    }
}
