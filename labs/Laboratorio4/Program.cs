using System;
using System.Collections.Generic;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Circulo> arrayDeCirculo = new List<Circulo>();
            //arrayDeCirculo.ForEach()

            arrayDeCirculo.Add( new Circulo(2.4, 5, 3));
            arrayDeCirculo.Add( new CirculoColorido(1.5, 3.1, 1 , "vermelho"));
            arrayDeCirculo.Add( new CirculoColoridoPreenchido(2.0, 2, 4 , "verde"));
            
            arrayDeCirculo.ForEach( (item) => {
                Console.WriteLine(item);
            });
            
        }
    }
}
