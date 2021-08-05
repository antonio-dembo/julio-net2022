using System;

namespace tipo_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);

            Console.WriteLine(circle.Circunference);

            circle.SubtractRedious();
            Console.WriteLine( circle.Redious);

            circle.SubtractRedious(2);
            Console.WriteLine(circle.Redious);

            #region  primitive value type
            // tipos imbutidos
            // a declaração abaixo é a mesma coisa
            // int a = 32;

            // // .NET type
            // System.Int32 b = 32;

            // Console.WriteLine($"Palavra chave do C#: {a}");
            // Console.WriteLine($"Tipo do .NET: {b}");

            // if ((decimal) Math.Pow(2, 5350) > decimal.MaxValue){
            //     throw new OverflowException();
            // }

            // try{
            //     decimal longNumber = (decimal) Math.Pow(2, 5350) ;
            //     Console.WriteLine(longNumber % 7);
            // }
            // catch(OverflowException e){
            //     Console.WriteLine(e.Message);
            // }

            #endregion
        }
    }
}
