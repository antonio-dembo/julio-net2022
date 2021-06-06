using System;
using System.Linq;
using System.Collections.Generic;

namespace collections
{
  class Program
  {
    static void Main(string[] args)
    {
        // Create a list of strongs by using a collection initializer.
        var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

        for (var index = 0; index < salmons.Count; index++)
        {
            Console.WriteLine(salmons[index] + " ");
        }

        Console.WriteLine();

        // remove an element from the list by specifying the object.
        //salmons.Remove("coho");
        salmons.RemoveAll( match: (s) => s.Contains("ck"));

        foreach (var salmon in salmons)
        {
            Console.WriteLine(salmon + " ");
        }


        // FormattedAddress address = new FormattedAddress 
        // {
        //     {"John", "Doe", "123 Street", "Topeka", "KS", "00000" },
        //     {"Jane", "Smith", "456 Street", "Topeka", "KS", "00000" }
        // };

        // Console.WriteLine("Address Entries");

        // foreach (string addressEntry in address)
        // {
        //     Console.WriteLine("\r\n" + addressEntry);
        // }
    
        // Collection initializers
        // List<Cat> cats = new List<Cat> {
        //     new Cat { Name = "Sylvester", Age = 8},
        //     new Cat { Name = "Peaches", Age = 4},
        //     new Cat { Name = "Sasha", Age = 14},
        //     null
        // };

        // var numbers = new Dictionary<int,string> {
        //     [7] = "seven",
        //     [9] = "nine",
        //     [13] = "thirteen"
        // };

        
        // foreach (int key in numbers.Keys)
        // {
        //     string value;
        //     numbers.TryGetValue(key, out value);
        //     Console.WriteLine( new { key , value });
        // }

        // Object initializers and anonymous type
        // var products = new List<Product>();

        // products.Add( new Product { Color = "blue", Price = 50M, Description = "This is the blue product"});
        // products.Add( new Product { Color = "white", Price = 100M, Description = "This is the white product"});
        
        // var productQuery = 
        //     from prod in products
        //     select new { prod.Color, prod.Price}; 


        // foreach (var v in productQuery)
        // {
        //     Console.WriteLine("Color= {0}, Price= {1}", v.Color, v.Price);
        // }

        // var v = new { Amount = 108, Message = "Hello"};
        // Console.WriteLine( v.Amount + " " + v.Message);

    //   var identity = new Matrix
    //   {
    //     [0, 0] = 1.0,
    //     [0, 1] = 0.0,
    //     [0, 2] = 0.0,

    //     [1, 0] = 0.0,
    //     [1, 1] = 1.0,
    //     [1, 2] = 0.0,

    //     [2, 0] = 0.0,
    //     [2, 1] = 0.0,
    //     [2, 2] = 1.0,
    //   };

    // Console.WriteLine(identity[0,2]);
      // Cat cat = new Cat { Age = 10, Name = "Fluffy"};
      // Cat sameCat = new Cat ("Fluffy") {Age = 10};

    }
  }
}
