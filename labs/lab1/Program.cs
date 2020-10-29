using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabalhando com tipos-valores fundamentais byte, int, long");
            byte b;
            b = byte.MaxValue;

            int i;
            i = int.MaxValue;

            long l;
            l = long.MaxValue;

            Console.WriteLine($"Valor máximo de byte: {b}");
            Console.WriteLine($"Valor máximo de int: {i}");
            Console.WriteLine($"Valor máximo de long: {l}");

            Console.WriteLine();

            Console.WriteLine("Ttrabalhando com strings");
            string strPrimeira = "Alo";
            string strSegunda = "Mundo";
            
            string strTerceira = strPrimeira + strSegunda ;
            Console.WriteLine(strTerceira);

            int cchTamanho = strTerceira.Length;
            string strQuarta = "Tamanho= " + cchTamanho.ToString();

            Console.WriteLine(strQuarta);

            Console.WriteLine();

            Console.WriteLine("Trabalhar com os objetos do Framework");

            DateTime dt = new DateTime(2015, 04, 23);
            string strQuinta = dt.ToString();

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(strQuinta);







        }
    }
}
