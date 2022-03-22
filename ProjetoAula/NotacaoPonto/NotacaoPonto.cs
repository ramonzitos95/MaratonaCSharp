//palavra - chave / tipo C#	Intervalo aproximado	Precisão	Tamanho	Tipo .NET
//float	±1,5 x 10−45 para ±3,4 x 1038   ~6 a 9 dígitos 4 bytes System.Single
//double  ±5.0 × 10−324 to ±1.7 × 10308	~15 a 17 dígitos    8 bytes System.Double
//decimal ±1,0 x 10-28 para ±7,9228 x 1028	28 a 29 dígitos 16 bytes System.Decimal

public class NotacaoPonto
{
    public NotacaoPonto()
    {
        Console.WriteLine("Início do programa");

        float valor1Float = 3.4F;
        Console.WriteLine($"Valor do float: {valor1Float}");
        double valor2Double = 135856.56;
        Console.WriteLine($"Valor do double: {valor2Double}");
        decimal valor3Decimal = 52698958656565.15M;
        Console.WriteLine($"Valor do decimal: {valor3Decimal}");

        decimal valor5Dc = (decimal)valor1Float;
        Console.WriteLine($"Valor do float em double: {valor5Dc}");

        string valorString = "25,50";
        Console.WriteLine($"Valor convertido de string {decimal.Parse(valorString)}");

        int valor1 = 100;
        Console.WriteLine($"Valor string: {valor1}");

        decimal cotacaoDoBitcoin = 2500000.545454656545465445465465M;
        Console.WriteLine($"Cotação do bitcoin: {cotacaoDoBitcoin}");
        Console.WriteLine($"Cotação do bitcoin: {Math.Round(cotacaoDoBitcoin, MidpointRounding.AwayFromZero)}");
        Console.WriteLine($"Cotação do bitcoin: {Math.Round(cotacaoDoBitcoin, MidpointRounding.ToZero)}");
        Console.WriteLine($"Cotação do bitcoin: {Math.Round(cotacaoDoBitcoin, MidpointRounding.ToEven)}");
        Console.WriteLine($"Cotação do bitcoin: {cotacaoDoBitcoin.ToString("F")}");

    }
}


