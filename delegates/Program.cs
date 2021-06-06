using System;
using System.Collections.Generic;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            // List<String> names = new List<string>();

            // names.Add("Bruce");
            // names.Add("Alfred");
            // names.Add("Tim");
            // names.Add("Richard");

            // names.ForEach(Print);


            /* 
            Esse programa usa delegates para guardar referência para outros métodos
            Também é usado para programação orientada a eventos
            
            */

/*          List<String> nomes  = new List<String>{"Júlio", "Ana", "João", "Márcia", "Pedro"};
            var umnome = nomes.Find( (n) => n.Length == 3); // parametro: bool metodo(string s) / uma expressão lambda/ método anônimo
            Console.WriteLine(umnome);

            // A variável refSomar (do tipo delegate) guarda uma referência para o método Somar
            Func<int,int,int> refSomar = Somar ; 
            Console.WriteLine(refSomar(1,2));

            // Passa a própria referencia do método
            Func<int,int> refDuplica = (x) => 2*x ;

            nomes.ForEach( (n) => Console.WriteLine($"nomr= {n}")) ;       */

            Termostato t1 = new Termostato();
            t1.LimiteSuperior= 27.5;

            t1.Alarme += (term) => {
                Console.WriteLine("Alarme disparado. !!!");
                Console.WriteLine($"Temperatura do termostato: {term.TemperaturaAtual}");
            };

            t1.Aumentar(10);
            t1.Aumentar(10);
            t1.Aumentar(10);
            Console.WriteLine(t1.TemperaturaAtual);
            t1.Aumentar(10);
            Console.WriteLine(t1.TemperaturaAtual);

            
        }

        static void Print(string s)
        {
            Console.WriteLine(s);
        }

        static int Somar (int x, int y)
        // Posso referenciar este método (de classe) desde que a variável seja do tipo "Delegate"
        // Eu quero um Delegate que:
        //      retorna: int
        //      recebe como parametro: <int,int>
        // Obs: o nome do método é irrelevante
        {
            return x + y;
        }
    }
}
