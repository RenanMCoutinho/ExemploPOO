
using ExemploPOO.Models;

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Renan";
pessoa.Idade = 30;

pessoa.Apresentar();



ContaCorrente c1 = new ContaCorrente(200, 1000);

c1.exibirSaldo();
c1.sacarValor(600);
c1.exibirSaldo();



