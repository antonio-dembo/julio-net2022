using System;

namespace delegates
{
    public class Termostato {
        public event Action<Termostato> Alarme;

        public double TemperaturaAtual {get; private set;}
        public double LimiteSuperior {get; set;}
        private bool alarmTriggeredFlag = false;
        public void Aumentar (double variacao)
        {
            TemperaturaAtual += variacao;
            if (TemperaturaAtual > LimiteSuperior){
                // gerar um evento avisando outros objetos
                if(!alarmTriggeredFlag){
                    if (Alarme != null){
                        Alarme(this);
                        alarmTriggeredFlag = true;
                    }
                    //Alarme?.Invoke(this) ; // null conditional: testa se a variável é null
                }
            }
        }
        
    }
}