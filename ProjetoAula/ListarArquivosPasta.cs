

string diretorioOrigem = @"C:\Users\RAMON\Documents";

var arquivos = Directory.GetFiles(diretorioOrigem);

foreach (var arquivo in arquivos)
{
   Console.WriteLine("Arquivo: " + arquivo);
}

//Console.WriteLine("Arquivos: " + arquivos.Count());
