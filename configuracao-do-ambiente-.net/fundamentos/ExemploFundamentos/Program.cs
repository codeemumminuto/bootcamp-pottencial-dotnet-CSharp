using ExemploFundamentos.Common.Models;

Pessoa pesso1 = new Pessoa();
pessoa1.Nome = "Lucas";
pessoa1.idade = 20;
pessoa1.Apresentar();

/*
int numero = 5;

for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}

int contador2 = 0;
while(contador2 <= 10)
{
    Console.WriteLine($"{numero} x {contador2} = {numero * contador2}");
    contador2++;

    if(contador2 == 5)
    {
        break;
    }
}

int contador3 = 0;
do{
    Console.WriteLine($"{numero} x {contador3} = {numero * contador3}");
    contador3++;

    if(contador3 == 5)
    {
        break;
    }
} while(contador2 <= 10);

/*
Calculadora calc = new Calculadora();
calc.Somar(2,5);
calc.Subtrair(5,3);
calc.Multiplicar(2,2);
calc.Dividir(4,2);
calc.Potencia(2,3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.Raiz(4);

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Lucas";
pessoa1.Idade = 23;

pessoa1.Apresentar();*/