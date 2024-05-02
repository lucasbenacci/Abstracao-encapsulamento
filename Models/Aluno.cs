using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao_encapsulamento.Models
{
    public class Aluno : Pessoa
    {
        public string Email { get; set; }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {Nome}, tenho {Idade} anos e minha note é {Nota}");
        }
    }
}