using System;

namespace classes {
    public abstract class Figura2D : Desenhavel {
        public int X {get; set;}
        public int Y {get; set;}

        public Figura2D(int posx, int posy){
            X = posx;
            Y = posy;
        }

        public override string ToString()
        {
            return $"{base.ToString()} [X= {X}, Y= {Y}]";
        }
        public abstract double CalculaArea();

        public abstract void Desenha();

        private string cor ;

        public string CorTraco { 
            get => cor; 
            set => cor = value;
        }
    } // Fim da Figura2D

    public class Quadrado : Figura2D {
        public int Lado{get; set;}

        public Quadrado(int posx, int posy, int tamanhoLado)
        : base(posx, posy)
        {
            Lado = tamanhoLado;
        }

        public override string ToString()
        {
            return $"{base.ToString()} [Lado= {Lado}]";
        }

        public override double CalculaArea() => Lado * Lado ;

        public override void Desenha() => Console.WriteLine($"Quadrado na tela{this}");
    } // Fim do Quadrado

    public class Circulo : Figura2D {
        public int Raio {get; set;}
        public Circulo(int tamanhoRaio)
        :this(0, 0, tamanhoRaio)
        {}

        public Circulo(int posx, int posy, int tamanhoRaio)
        : base(posx, posy)
        { Raio = tamanhoRaio;}
        
        public new string ToString()
        {
            return $"{base.ToString()} [Raio= {Raio}]";
        }

        public override double CalculaArea()
        {
            return  Math.PI * Raio * Raio ;
        }

        public override void Desenha() => Console.WriteLine($"Circulo na tela: {this}");
    } // Fim do Circulo

    public interface Desenhavel {
        void Desenha();
        string CorTraco{get; set;}
    }
} // namespace