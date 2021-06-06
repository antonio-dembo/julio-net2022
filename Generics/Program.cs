using System;
using Generics.Models;

namespace Generics
{
  class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>(5);
            Console.WriteLine("Has value ?" + number.HasValue);
            Console.WriteLine("Value= " + number.GetValueOrDefault());

        }
    }
}
