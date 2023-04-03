// See https://aka.ms/new-console-template for more information
using System.Net.Mail;

Console.WriteLine("Informe seu email:");
var email = Console.ReadLine();

try
{
    MailAddress mailAddress;

    if (!string.IsNullOrEmpty(email))
    {

        mailAddress = new MailAddress(email);
        Console.WriteLine($"Email valido {email}");
    }
}
catch (Exception)
{
    Console.WriteLine($"Email inválido {email}");
}