using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Abstracao_encapsulamento.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            
        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, Meu nome é {Nome}, tenho {Idade} anos, sou um professor e meu salário é {Salario.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))}");
        }
    }
}