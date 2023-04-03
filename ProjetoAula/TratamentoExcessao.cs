
try
{
	string nome = "";
	if (string.IsNullOrEmpty(nome))
		throw new Exception("O nome está vazio");

	Console.WriteLine("Não deu erro");
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
finally
{
	Console.Write("Finalizou a conexão");
}


