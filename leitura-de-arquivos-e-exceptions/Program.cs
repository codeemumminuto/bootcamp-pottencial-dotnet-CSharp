using leitura_de_arquivos_e_exceptions.Models;

//Try Catch Finally
/*
try
{
    string [] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach(string linha in linhas){
        Console.WriteLine(linha);
    }
} 
catch(FileNotFoundException ex) 
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquio não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex) 
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho não encontrado. {ex.Message}");
}
catch(Exception ex) 
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine("Chegou até aqui");
}*/


//Throw
new ExemploExcecao().Metodo1();
