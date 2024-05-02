using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstracao_encapsulamento.Models
{
    public class Aluno : Pessoa
    {
        public string Email { get; set; }
        public decimal Nota { get; set; }
    }
}