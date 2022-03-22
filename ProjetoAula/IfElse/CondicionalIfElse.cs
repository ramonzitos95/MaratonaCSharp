using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.IfElse
{
    public class CondicionalIfElse
    {
        public CondicionalIfElse()
        {
            //Calcular a média dos alunos baseado em 4 notas informadas e mostrar se ele é um aluno aprovado ou reprovado.
            //Ao final classificar a média deste aluno, se foi excelente, ótima, boa, ruim ou péssima.
            //Excelente quando a nota for acima de 8.5
            //ótima entre 7.5 e 8.5
            //Boa entre 6 e 7.5
            //Ruim entre 4 e 6
            //Péssima abaixo de 4

            string aluno = "João";
            string valordoConsole = string.Empty;
            Console.WriteLine("Informe a primeira nota");
            valordoConsole = Console.ReadLine();
            decimal nota1 = decimal.Parse(valordoConsole);
            Console.WriteLine("Informe a segunda nota");
            valordoConsole = Console.ReadLine();
            decimal nota2 = decimal.Parse(valordoConsole);
            Console.WriteLine("Informe a terceira nota");
            valordoConsole = Console.ReadLine();
            decimal nota3 = decimal.Parse(valordoConsole);
            Console.WriteLine("Informe a quarta nota");
            valordoConsole = Console.ReadLine();
            decimal nota4 = decimal.Parse(valordoConsole);

            decimal media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine($"A média do aluno foi: {media}");

            if (media > 6)
                Console.WriteLine($"O aluno {aluno} foi aprovado");
            else
                Console.WriteLine($"O aluno {aluno} foi reprovado");


            if (media > 8.5M)
                Console.WriteLine($"Aluno excelente");
            else if (media >= 7.5M && media <= 8.5M)
                Console.WriteLine($"Aluno ótimo");
            else if (media >= 6 && media <= 7.5M)
                Console.WriteLine($"Aluno bom");
            else if (media >= 4 && media <= 6)
                Console.WriteLine($"Aluno Ruim");
            else
                Console.WriteLine($"Aluno péssimo");
        }
    }
}
