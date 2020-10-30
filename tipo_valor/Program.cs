using System;

namespace tipo_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            // tipos imbutidos
            // a declaração abaixo é a mesma coisa
            int a = 32;

            // .NET type
            System.Int32 b = 32;

            Console.WriteLine($"Palavra chave do C#: {a}");
            Console.WriteLine($"Tipo do .NET: {b}");
        }
    }
}
