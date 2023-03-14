// See https://aka.ms/new-console-template for more information
using BaixarArquivosS3;
using System.IO;
namespace BaixarArquivosS3
{
    public class Arquivo
    {
        public static void CriarArquivos()
        {
            var path = "C:\\logs\\log.txt";
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine("Teste de linha");
                streamWriter.WriteLine("Teste de linha 2");
                streamWriter.WriteLine("Teste de linha 3");
                streamWriter.WriteLine("Teste de linha 4");
                streamWriter.WriteLine("Teste de linha 5");

                streamWriter.Write("A");
                streamWriter.Write("B");
            }

            var path2 = "C:\\logs\\teste.txt";
            using (var streamWriter = new StreamWriter(path2, true))
            {
                streamWriter.WriteLine("Teste de linha");
                streamWriter.WriteLine("Teste de linha 2");
                streamWriter.WriteLine("Teste de linha 3");
                streamWriter.WriteLine("Teste de linha 4");
                streamWriter.WriteLine("Teste de linha 5");

                streamWriter.Write("A");
                streamWriter.Write("B");
            }

        }

    }
}
