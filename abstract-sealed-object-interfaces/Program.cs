using abstrata.Models;
using abstrata.interfaces;

Corrente c1 = new Corrente();
c1.Creditar(500);
c1.ExibirSaldo();


//construtor por herança, ao exigir um parametro obrigatorio (construtor) na classe mãe, é necessário adicionar um construtor na classe filha junto com base(nome)
//public exemplo(string nome) : base(nome)

//public sealed sela uma classe ou um método e proibe outras classes de herdarem(classes) ou usarem(métodos)


//Classe object topo da hierarquia - serviços de baixo nível

//Interface
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Dividir(2,1));