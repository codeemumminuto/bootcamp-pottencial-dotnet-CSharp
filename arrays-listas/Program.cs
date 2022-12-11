// Arrays
/*int[] ArrayInteiros = new int[3];
ArrayInteiros[0] = 72;
ArrayInteiros[1] = 64;
ArrayInteiros[2] = 50;

for(int contador = 0; contador < ArrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} = {ArrayInteiros[contador]}");
}

Array.Resize(ref ArrayInteiros, ArrayInteiros.Length * 2);

ArrayInteiros[3] = 88;
ArrayInteiros[4] = 99;
ArrayInteiros[5] = 100;

int contador2 = 0;
foreach(int valor in ArrayInteiros)
{
    Console.WriteLine($"Posição Nº {contador2} = {valor}");
    contador2++;
}

int[] ArrayInteirosDobrado = new int[ArrayInteiros.Length * 2];
Array.Copy(ArrayInteiros, ArrayInteirosDobrado, ArrayInteiros.Length);*/

// Listas

List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for(int contador = 0; contador < listaString.Count(); contador++)
{
    Console.WriteLine($"Posição Nº {contador} = {listaString[contador]}");
}

foreach(string item in listaString)
{
    Console.WriteLine(item);
}