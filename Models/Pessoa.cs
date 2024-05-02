using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Abstracao_encapsulamento.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, o meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}