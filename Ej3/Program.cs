using System;
using System.Net;
using Newtonsoft.Json;

namespace ApiUsuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            string json_origen = "https://jsonplaceholder.typicode.com/users";
            var api = new WebClient().DownloadString(json_origen);
            dynamic json = JsonConvert.DeserializeObject(api);
            foreach (var i in json)
            {
                string nombres = i.name;
                string[] nombre = nombres.Split(' ');

                var resultado = nombre[0] + " " + i.email;
                Console.WriteLine(resultado);
            }
        }
    }
}
