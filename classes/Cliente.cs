using System;

namespace classes
{
    public class Cliente
    {
        // declara campos de instancia (pertence ao meu objeto)
        // campos: dados do objeto 
        private string nome;
        private DateTime dataDeNascimento;
        private decimal limiteCredito;

         public Cliente(string umNome, string umaDataIso){
            nome = umNome;
            dataDeNascimento = DateTime.Parse(umaDataIso);
        }

        public Cliente(string umNome){ 
            nome = umNome;
            dataDeNascimento = DateTime.Now;
        }

        public void AumentarLimiteCredito(decimal porcentagem){
            decimal aumento = porcentagem * limiteCredito;
            limiteCredito += aumento;

        }

       
        public decimal LimiteDeCredito {
            // cria uma "Propriedade" para o campo "limiteCredito", para expor seus dados
            // Não é um método porque não tem passagem de parámetros
            // pode ser de leitura(get) ou escrita(set)
            // Pode ter qualquer nome
            // value: proriedade implicita do C# que recebe o nome que deve ser atribuido ao limiteCredito
            get{
                return limiteCredito;
            }
            set{
                // limite de crédito não pode ser negativo: validação
                // uso de exceção (Exception)
                if (value < 0){
                    // Gerar uma exceção
                    throw new ArgumentOutOfRangeException($"{nameof(value)} Deve ser maior ou igual a 0)");
                }
                limiteCredito = value;
            }
        }

        public string Nome{
            get{return nome;}
        }

        public string DataDeNascimento{
            get{ return dataDeNascimento.ToShortDateString();}
        }

        public int Idade{
            get{
                var anoAtual = DateTime.Now.Year;
                var anoNascimento = dataDeNascimento.Year;
                return anoAtual - anoNascimento;
            }
        }

        public string Cpf{get; private set;} = string.Empty; // propriedade auto-gerada: ele cria automaticamente um campo (privado) para guardar o CPF, só não temos acesso a ele.




    } // Cliente
}// namespace



