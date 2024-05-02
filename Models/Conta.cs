using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Abstracao_encapsulamento.Models
{
    public abstract class Conta
    {
        protected decimal Saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é {Saldo.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))}");
        }
    }
}