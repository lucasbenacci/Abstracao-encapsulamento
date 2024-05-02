using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao_encapsulamento.Models
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
                Console.WriteLine($"Saque de R${valor} Realizado com sucesso. ");
                Console.WriteLine($"O seu saldo atual é de R${saldo}");
            }
            else{
                Console.WriteLine("Valor desejado é superior ao saldo disponível");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo disponível é: R${saldo}");
        }
    }
}