using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.NovaPasta
{
    public class Operadores
    {
        public Operadores()
        {
            int valor1 = 10;
            int valor2 = 5;
            bool EhMaior = false;


            if (valor2 < valor1)
                Console.WriteLine("O valor2 é menor que o valor 1");
            else if (valor2 == valor1)
                Console.WriteLine("O valor2 é igual ao valor1");

            if (EhMaior)
                Console.WriteLine("É Maior");

            string nome = "Ramon ";
            nome = (nome.Length == 5) ? "Ramon Silva" : "Ramon Santos";
            Console.WriteLine($"O nome ficou: {nome}");

        }
    }
}
