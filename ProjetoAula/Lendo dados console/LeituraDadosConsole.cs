public class  LeituraDadosConsole
{
    public LeituraDadosConsole()
    {
        string retorno;

        retorno = Console.ReadLine();
        int valor1 = int.Parse(retorno);

        retorno = Console.ReadLine();
        int valor2 = int.Parse(retorno);

        Console.WriteLine($"O resultado da operação é: {valor1 + valor2}");
        Console.ReadKey();
    }
}



