using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Metodos_assincronos
{
    class Program
    {
        static readonly HttpClient cliente = new HttpClient();
        static async Task Main(string[] args)
        {
            try{
                var resposta = await cliente.GetAsync("https://reqres.in/api/users/2");
                if(resposta.IsSuccessStatusCode){
                    string dados = await resposta.Content.ReadAsStringAsync();
                    Console.WriteLine(dados);
                }
                
            }
            catch(HttpRequestException e){
                Console.WriteLine("Falha do consumo do Web Service: ");
                Console.WriteLine(e.Message);
            }

        }
    }
}
