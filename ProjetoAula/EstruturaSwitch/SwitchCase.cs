using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.EstruturaSwitch
{
    public class SwitchCase
    {
        public SwitchCase()
        {
            //Estrutura switch case / Meses do ano.
            //Criar algoritmo que conforme o número, coloque o mês na tela

            Console.WriteLine("Informe um mês válido entre 1 a 12");
            var mesDoAno = int.Parse(Console.ReadLine());

            if (mesDoAno < 1 || mesDoAno > 12)
                Console.WriteLine("Mês inválido");

            switch (mesDoAno)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;

                case 2:
                    Console.WriteLine("Fevereiro");
                    break;

                case 3:
                    Console.WriteLine("Março");
                    break;

                case 4:
                    Console.WriteLine("Abril");
                    break;

                case 5:
                    Console.WriteLine("Maio");
                    break;

                case 6:
                    Console.WriteLine("Junho");
                    break;

                case 7:
                    Console.WriteLine("Julho");
                    break;

                case 8:
                    Console.WriteLine("Agosto");
                    break;

                case 9:
                    Console.WriteLine("Setembro");
                    break;

                case 10:
                    Console.WriteLine("Outubro");
                    break;

                case 11:
                    Console.WriteLine("Novembro");
                    break;

                case 12:
                    Console.WriteLine("Dezembro");
                    break;

                default:
                    Console.WriteLine("mês desconhecido");
                    break;
            }
        }
    }
}
