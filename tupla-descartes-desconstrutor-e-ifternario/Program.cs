/*//syntax 1
(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Lucas", "Alan", 1.8M);
Console.WriteLine($"ID: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");

//syntax2
ValueTuple<int, string, string, decimal> tupla2 = (1, "Lucas", "Alan", 1.8M);
Console.WriteLine($"ID: {tupla2.Item1}");
Console.WriteLine($"Nome: {tupla2.Item2}");
Console.WriteLine($"Sobrenome: {tupla2.Item3}");
Console.WriteLine($"Altura: {tupla2.Item4}");

//syntax3
var tupla3 = Tuple.Create(1, "Lucas", "Alan", 1.8M);
Console.WriteLine($"ID: {tupla3.Item1}");
Console.WriteLine($"Nome: {tupla3.Item2}");
Console.WriteLine($"Sobrenome: {tupla3.Item3}");
Console.WriteLine($"Altura: {tupla3.Item4}");*/

/*using tupla.Models;

LendoArquivos arquivo = new LendoArquivos();

var (sucesso, linhaArquivo, _) = arquivo.LerArquivo("Arquivo/arquivLeitura.txt");

if(sucesso)
{
    //Console.WriteLine("Quantidade de linhas do arquivo " + quantLinhas);
    foreach(string linha in linhaArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}*/

/*
using tupla.Models;

Pessoa p1 = new Pessoa("Lucas", "Alan");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");*/

//IF Normal

int numero = 20;

if(numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar");
}

// IF Ternário

int numero2 = 15;
bool is_par = numero2 % 2 == 0;
Console.WriteLine($"O número {numero2} é " + (is_par ? "par" : "ímpar"));