using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.While
{
    public class While
    {
        public While()
        {
            List<int> notas = new List<int>();

            Console.WriteLine("Sistema de notas");
            Console.WriteLine("Digite s para continuar com as notas");
            var entrada = Console.ReadLine();
            var contador = 0;
            while (entrada == "s")
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
            }

            Console.WriteLine($"A média de notas é {notas.Sum() / contador}");

        }
    }
}
