

string diretorio = @"C:\Temp2\certidao.jpg";
string dir = @"C:\Temp2\";
string file = "certidao.jpg";

var diretorioFinal = Path.Combine(dir, file);
Console.WriteLine(diretorioFinal);
Console.WriteLine("Diretorio: " + Path.GetDirectoryName(diretorioFinal));
Console.WriteLine("Arquivo nome: " + Path.GetFileName(diretorioFinal));
Console.WriteLine("Extensão: " + Path.GetExtension(diretorio));
Console.WriteLine("Arquivo sem extensão: " + Path.GetFileNameWithoutExtension(diretorio));








