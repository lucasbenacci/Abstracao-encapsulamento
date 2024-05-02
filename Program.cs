using Abstracao_encapsulamento.Models;

Pessoa p1 = new Pessoa("Lucas");
p1.Idade = 26;

p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(600);
c1.ExibirSaldo();

Console.WriteLine("-------------------------------");

Aluno a1 = new Aluno("Rogerio");

a1.Idade = 16;
a1.Email = "rogerio16@gmail.com";
a1.Nota = 6;
a1.Apresentar();

Console.WriteLine("-------------------------------");

Professor pf1 = new Professor("Paulo");
pf1.Idade = 45;
pf1.Salario = 2600;
pf1.Apresentar();

Console.WriteLine("-------------------------------");

Corrente c = new Corrente();

c.Creditar(500);
c.ExibirSaldo();

