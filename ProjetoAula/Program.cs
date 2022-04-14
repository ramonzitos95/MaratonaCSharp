using ProjetoAula;

var casaNova = new Casa(200, "Amarela");

Console.WriteLine($"A cor da casa é: {casaNova.Cor}");

var casaVelha = new Casa(175, "Azul");

Console.WriteLine($"A cor da casa velha é: {casaVelha.Cor}");

var casaNova2 = new Casa(200, "Amarela", 2, 5);

Console.WriteLine($"A qtd de portas é: {casaNova2.QuantidadeDePortas}");
