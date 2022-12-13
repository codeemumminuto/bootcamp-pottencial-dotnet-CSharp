# Alocação de memória

##### O que é uma variável?
Ao declarar uma variável, você está reservando um espaço na memória para armazenar aquele valor.
Para declarar uma variável é necessário o tipo da variável, o nome e o valor. Como por exemplo declarar uma variável com o valor 51.
```csharp
int valor = 51;
```
No Csharp nós temos dois tipos de memória, o Stack e o Heap.
Ao declarar uma variável, ela vai para o topo do Stack.
Ao declarar uma classe (Objeto), o programa irá armazenar a variável no Stack com uma referência para o Heap que é onde o objeto realmente fica.

##### Limpeza de memória
Para que as variáveis que você não utilizará mais, não ficarem ocupando espaço na memória, o programa irá "matar" automaticamente o valor que está ocupando o espaço da memória Stack.
E quando não se tem mais referência no stack para o heap, o Garbage collector vai entrar em ação para limpar a memória Heap.

