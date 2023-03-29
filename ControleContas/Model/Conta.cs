using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Conta
    {

        private string _numero;
        private decimal _saldo;
        private static decimal _saldoTotal; // static faz com que ele seja compartilhavel em todas as classes
        private static string _contaMaiorSaldo;
        private static decimal _maiorSaldo;

        //Polimorfismo de sobrecarga
        public Conta(string numero)
        {
            _numero = numero;
        }

        public Conta(string numero, decimal saldo) 
        {
            _saldo = saldo;
            _numero = numero;
            _saldoTotal += _saldo;
            if(saldo > _maiorSaldo)
            {
                _maiorSaldo = saldo;
                _contaMaiorSaldo = numero;
            }
        }

        public string Numero {
            get => _numero; 
            private set => _numero = value; 
        }
        public decimal Saldo { 
            get => _saldo; 
            private set => _saldo = value; 
        }

        public decimal SaldoTotal { get => _saldoTotal; private set => _saldoTotal = value; }

        public string ContaMaiorSaldo
        {
            get => _contaMaiorSaldo;
        }

        public Cliente Titular { get; set; }

        public void Deposito(decimal valor)
        {
            if(valor > 0)
            _saldo += valor;
            else
            {
                Console.WriteLine("Não é possivel fazer um depósito com um valor negativo.");
            }
        }

        public void Saque(decimal valor)
        {
            if(valor <= 0)
            {
                Console.WriteLine("Valor invalido. Digite um valor maior que zero");
            }
            else if(Saldo < valor)
            {
                Console.WriteLine("Voce não possui saldo suficiente");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Valor sacado: R${valor}.\nValor atual: R${Saldo}");
            }
        }
    }
}
