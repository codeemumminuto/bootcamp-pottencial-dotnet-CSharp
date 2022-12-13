using tipos_especiais_no_csharp.Models;

//nulo
bool? desejaReceberEmail = null;

if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário irá receber e-mail");
}
else
{
    Console.WriteLine("O usuário não irá receber e-mail");
}

//anônimos
Itens i1 = new Itens(1, "Papel", 1.50M);

List<Itens> listaItens = new List<Itens>();
var listaAnonima = listaItens.Select(x => new {x.Produto, x.Preco});

foreach(var item in listaAnonima)
{
    Console.WriteLine($"Produto: {item.Produto}, Preço: {item.Preco}");
}

//dinâmico
dynamic variavelDinamica = 4;
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
variavelDinamica = "Texto";
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
variavelDinamica = true;
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

//classes genéricas
//array inteiro
MeuArray<int> arrayInteiro = new MeuArray<int>();
arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);

//array string
MeuArray<string> arrayString = new MeuArray<string>();
arrayString.AdicionarElementoArray("Texto");

Console.WriteLine(arrayString[0]);

//Métodos de extensão
int numero = 30;
bool par = numero.EhPar();

string mensagem = "O número " + numero + " é " + (par ? "par" : "impar");
Console.WriteLine(mensagem); 