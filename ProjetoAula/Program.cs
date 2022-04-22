
using ProjetoAula;

var casa = new Casa(4, false, 200, "Vermelha");

Console.WriteLine($"O tamanho da casa é: {casa.Tamanho}");
Console.WriteLine($"A cor da casa é: {casa.Cor}");

var casa2 = new Casa(casaAlugada:false, quantidadeDePortas: 4);
Console.WriteLine($"A casa2 está alugada?: {casa2.CasaAlugada}");
Console.WriteLine($"A quantidade de portas da casa 2 é: {casa2.QuantidadeDePortas}");


