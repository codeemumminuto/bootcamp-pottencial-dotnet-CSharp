//Filas

Queue<int> fila = new Queue<int>();

Console.WriteLine("Fila: ");

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

fila.Dequeue();

Console.WriteLine("Fila após a remoção do primeiro da fila: ");

foreach(int item in fila)
{
    Console.WriteLine(item);
}

fila.Enqueue(10);

Console.WriteLine("Fila após adicionar um novo número: ");

foreach(int item in fila)
{
    Console.WriteLine(item);
}

//Pilhas

Stack<int> pilha = new Stack<int>();

Console.WriteLine("Pilha: ");

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

pilha.Pop();

Console.WriteLine("Pilha após a remoção do topo da pilha");

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

pilha.Push(12);

Console.WriteLine("Pilha após a adição de mais um item");

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

//Dictionary

Dictionary<string, string> estados = new Dictionary<string, string>();

Console.WriteLine("Dictionary: ");

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

Console.WriteLine($"Novo dictionary após remoção da bahia e alteração de sao paulo");
foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}