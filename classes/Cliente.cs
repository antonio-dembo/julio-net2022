using System;

namespace classes
{
    public class Cliente
    {
        private string nome;
        private DateTime dataDeNascimento;

        public Cliente(string umNome, string umaDataIso){
            nome = umNome;
            dataDeNascimento = DateTime.Parse(umaDataIso);

        }

        public Cliente(string umNome){ // dá para criar qantos construtores você quizer.
            nome = umNome;
            dataDeNascimento = DateTime.Now;

        }





    }

}



