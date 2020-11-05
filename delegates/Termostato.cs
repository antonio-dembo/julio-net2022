using System;

namespace delegates
{
    public class Termostato {
        public event Action<Termostato> Alarme;

        public double TemperaturaAtual {get; private set;}
        public double LimiteSuperior {get; set;}

        public void Aumentar (double variacao)
        {
            TemperaturaAtual += variacao;
            if (TemperaturaAtual > LimiteSuperior){
                // gerar um evento avisando outros objetos
                if (Alarme != null){
                    Alarme(this);
                }
                //Alarme?.Invoke(this) ; // null conditional: testa se a variável é null
                
            }
        }

        
    }
}