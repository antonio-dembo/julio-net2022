using System;
using System.Collections.Generic;

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
            Console.WriteLine(person2.ToString());   // explicit call to ToString() method 
            
                 
            Cliente c = new Cliente("John Doe", "10/12/1999");
            Console.WriteLine(c.LimiteDeCredito);
            c.LimiteDeCredito = 1000M;
            c.AumentarLimiteCredito(0.50M);
            Console.WriteLine($"Limite de crédito é {c.LimiteDeCredito:C}");

            if (c.Cpf == null){
                Console.WriteLine("Ops... null");
            }
            */

            Quadrado q1 = new Quadrado(1,1,5);
            //Console.WriteLine($"X= {q1.X}, Y= {q1.Y},  Lado= {q1.Lado}");

            Figura2D f1;
            f1 = new Quadrado(1,1,1); 
            Console.WriteLine(f1);
            Console.WriteLine(f1.CalculaArea());

            Figura2D f2;
            f2 = new Circulo(3);
            Console.WriteLine(((Circulo)f2).ToString()); // não tem polimorfismo
            Console.WriteLine(f2.CalculaArea());

            // cria lista de objetos desenhaveis
            List<Desenhavel> figuras  = new List<Desenhavel>();
            figuras.Add(new Quadrado(1,2,3));
            figuras.Add(new Quadrado(3,2,4));
            figuras.Add(new Circulo(5));

            foreach(var fig in figuras){ // foreach funciona com quem implementa IEnumerable
                fig.Desenha();
            }

            //figuras.ForEach(figuras => figuras.Desenha()); //Delegate




        } // main
    } // program Class
} // namespace
