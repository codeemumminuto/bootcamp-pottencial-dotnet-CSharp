using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstracao_pratica.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado");
            }
            else
            {
               Console.WriteLine("Valor não disponível"); 
            }
            
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo disponível: {saldo}");
        }
    }
}