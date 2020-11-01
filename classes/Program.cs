using System;

namespace classes
{
    class Program
    {
        static void Main(String[] args)
        {
/*          // Calls the constructor that has no paramenter
            Person person1 = new Person();
            Console.WriteLine(person1.Name);

            // Calls the constructor that as one parameter
            Person person2 = new Person("Sarah Jones");
            Console.WriteLine(person2.Name);

            // Get the string representation of the person2 instance
            Console.WriteLine(person2);              // Implicit call to ToString() method
            Console.WriteLine(person2.ToString());   // explicit call to ToString() method */
            
                 
            Cliente c = new Cliente("John Doe", "10/12/1999");
            Console.WriteLine(c.LimiteDeCredito);
            c.LimiteDeCredito = 1000M;
            c.AumentarLimiteCredito(0.50M);
            Console.WriteLine($"Limite de crédito é {c.LimiteDeCredito:C}");

            


            

                       
        
        } // main
    } // program Class
} // namespace
