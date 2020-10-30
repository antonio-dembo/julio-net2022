using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Console.WriteLine(lista.Count);
            lista.Add(5);
            lista.Add(1);

            foreach ( var e in lista){
                Console.WriteLine(e);
            }

            List<string> nomes = new List<string>{"Júlio", "João", "Ana"};

            Console.WriteLine(nomes.Count);
            Console.WriteLine(nomes[0]); // inxador : a classe List implenta um indexador.

            nomes[2] = "Ana Júlia";  // isso é uma lista e não um array
            Console.WriteLine(nomes[2]);

            // Dicionário é uma classe , então olhar seus Construtores para saber como instanciar
            Dictionary<int, List<string>> ddi = new Dictionary<int, List<string>>{} ; // É um indexador

            ddi.Add(212, new List<string>{"Marrocos", "Saara Ocidental"});
            Console.WriteLine(ddi.ContainsKey(212)) ; 

            foreach(var key in ddi.Keys){
                Console.WriteLine(key) ; 
            }
            








        } // main
    } // program
}// namespace
