using System;
using System.Drawing;

namespace Laboratorio4
{
    public class Circulo {
        private double coordX;
        private double coordY;
        private double raio;

        public Circulo()
        : this(0, 0, 1)
        {
        }

        public Circulo (double x, double y, double r){
            coordX = x;
            coordY = y;
            raio = Math.Abs(r);
        }

        public double CentroX { get => coordX ; set => coordX = value; }
        public double CentroY { get => coordY; set => coordY = value; }
        public double Raio { get => raio; set => raio = value; }


        public override string ToString()
        {
            return "(" + string.Format("{0:F2}" , CentroX) + ";" 
                    + string.Format("{0:F2}" , CentroY) + ")"
                    + "  raio= " + string.Format("{0:F2}" , Raio) ;
        }


    } // Fim da classe Circulo

    public class CirculoColorido : Circulo {
        private string minhaCor;
        public string Cor{ get => minhaCor; set => minhaCor = value;}
        public CirculoColorido(){
            minhaCor = "preto";
        }

        public CirculoColorido (double x, double y, double r, string C)
        :base(x, y, r)
        {
            minhaCor = C;
        }

        public override string ToString()
        {
            return base.ToString() + " Cor=" + Cor;
        }

        
    } // Fim da classe CirculoColorido

    public class CirculoColoridoPreenchido : CirculoColorido{
        public Color umaCor; 
        
        // { get => Color.LightBlue.Name; }
        public CirculoColoridoPreenchido(double x, double y, double r, string C)
        : base(x, y, r,C)
        {
            umaCor = Color.FromName(C);
        }
        public string UmaCor {
            get{
                return umaCor.Name;
            }
        } 
        public override string ToString()
        {
            return base.ToString();
        }
    }
}