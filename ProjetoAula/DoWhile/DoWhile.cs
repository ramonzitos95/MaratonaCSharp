using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.DoWhile
{
    public class DoWhile
    {
        public DoWhile()
        {
            List<int> notas = new List<int>();

            var entrada = string.Empty;
            var contador = 0;

            do
            {
                contador++;

                Console.WriteLine("Informe a nota do aluno");
                var notaDoAluno = Console.ReadLine();
                if (!string.IsNullOrEmpty(notaDoAluno))
                {
                    int notaInt = int.Parse(notaDoAluno);
                    notas.Add(notaInt);
                }

                Console.WriteLine("Digite s para continuar com as notas");
                entrada = Console.ReadLine();
            } while (entrada == "s");

            Console.WriteLine($"A média de notas é {notas.Sum() / contador}");
        }
    }
}
