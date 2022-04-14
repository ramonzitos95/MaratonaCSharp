
using ProjetoAula;

var casa = new Casa();

var area = casa.CalcularAreaCasa(30, 50);
Console.WriteLine($"A área da casa é {area}");

var casa2 = new Casa();
var area2 = casa.CalcularAreaCasa(50, 20);
Console.WriteLine($"A área da casa é {area2}");
