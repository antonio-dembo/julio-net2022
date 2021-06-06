using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? n = null;
            int m = n.GetValueOrDefault();

            Console.WriteLine(m);

            //dynamic num1 = 5; // postpone the type resolution at runtime
            var num2 = 5; // checed at compile time

        }
    }
}
