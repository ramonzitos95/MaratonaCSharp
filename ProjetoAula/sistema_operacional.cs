var sistemaOperacional = Environment.OSVersion.ToString();
Console.WriteLine("O sistema operacional é");
Console.WriteLine(sistemaOperacional);

if(Environment.OSVersion.Platform == PlatformID.Win32NT)
{
    Console.WriteLine("Estou no windows");
}
else if(Environment.OSVersion.Platform == PlatformID.Unix)
{
    Console.WriteLine("Estou no linux");
}
else
{
    Console.WriteLine("Estou em outro sistema operacional");
}
