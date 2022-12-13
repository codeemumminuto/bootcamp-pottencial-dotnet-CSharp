using nuget_serializacao_e_atributos.Models;
using Newtonsoft.Json;

//Serialização
/*
DateTime dataatual = DateTime.Now;

List<Vendas> ListaVendas = new List<Vendas>();

Vendas v1 = new Vendas(1, "Material de escritório", 25.00M, dataatual);
Vendas v2 = new Vendas(2, "Licença de software", 110.00M, dataatual);

ListaVendas.Add(v1);
ListaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(ListaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);*/

//Deserialização - Nesse o Json veio com "Produto"
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<DesVendas> listVenda = JsonConvert.DeserializeObject<List<DesVendas>>(conteudoArquivo);

foreach(DesVendas venda in listVenda)
{
    Console.WriteLine($"id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda}");
}

//Deserialização com atributos - Nesse o Json veio com "Nome_Produto"
//[JsonProperty("Nome_Produto")] na classe  DesVendas