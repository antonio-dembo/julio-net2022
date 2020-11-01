using System;

namespace lab1_exercicios
{
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Floating point numeric type"); 
            //double a = 12.3;
            //System.Double b = 12.3;
            //if (a == b) Console.WriteLine("true");

            double a = 0;
            decimal b = 2.1m ;

            Console.WriteLine( a + (double) b);
            Console.WriteLine( (decimal)a + b);

            float c = 2.8f ;

            Console.WriteLine($"float: {c}");
            Console.WriteLine($"soma float e double: {c + a}");
            Console.WriteLine($"soma float e float: {c + (float)b}");
            Console.WriteLine($"soma float e float: {(decimal) c+ b}");

            Console.WriteLine();

            // Real Letereals
            double d = 3D ;
            //d = 4d;
            //d = 3.934_001;

            float f = 3_000.5F ;
            //f = 5.4f;

            decimal myMoney = 3_000.5m ;
            //myMoney = 400.75M;

            Console.WriteLine($"doubel: {d}");
            Console.WriteLine($"float: {f}");
            Console.WriteLine($"decimal: {myMoney:C}");


            
        } // main
    } // Program Class
} // names space
