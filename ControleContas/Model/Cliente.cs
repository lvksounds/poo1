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

            if(cpf.Length == 11)
            {
                Cpf = cpf;
            }
            else
            {
                Console.WriteLine($"{Nome}, CPF deve conter 11 digitos");
            }
            
            if(DateTime.Now.Year - anoNascimento >= 18)
            {
                AnoNascimento = anoNascimento;
            }
            else
            {
                Console.WriteLine($"{Nome}, é preciso ter mais de 18 anos para abrir uma conta.");
            }
        }

        
        public Cliente()
        {

        }
    }
}
