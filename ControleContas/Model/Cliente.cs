using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public int AnoNascimento { get; private set; }
        public string IdConta { get; private set; } 

        public Cliente(string nome, string cpf, int anoNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            AnoNascimento = anoNascimento;
        }

        
        public Cliente()
        {

        }
    }
}
