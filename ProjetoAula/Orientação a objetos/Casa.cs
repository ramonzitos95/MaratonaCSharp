using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula
{
    public class Casa
    {
        public int Tamanho { get; set; }
        public string Cor { get; set; }
        public int QuantidadeDePortas { get; set; }
        public int QuantidadeDeJanelas { get; set; }
        public decimal ValorCasa { get; set; }
        public bool CasaAlugada { get; set; }
        public static int QuantidadeMoradores  { get; set; }

        public Casa()
        {
                
        }

        public Casa(int tamanho, string cor)
        {
            Tamanho = tamanho;
            Cor = cor;
        }

        public Casa(int tamanho, string cor, int quantidadeDePortas, int quantidadeDeJanelas)
        {
            Tamanho = tamanho;
            Cor = cor;
            QuantidadeDePortas = quantidadeDePortas;
            QuantidadeDeJanelas = quantidadeDeJanelas;
        }

        public Casa(int quantidadeDePortas, bool casaAlugada, int tamanho = 100, string cor = "Amarela")
        {
            QuantidadeDePortas = quantidadeDePortas;
            CasaAlugada = casaAlugada;
            Tamanho = tamanho;
            Cor = cor;
        }


        public void VenderCasa()
        {
            Console.WriteLine("A casa foi vendida");
        }

        public void AlugarCasa()
        {
            Console.WriteLine("A casa foi alugada");
        }

        public int CalcularAreaCasa(int largura, int comprimento)
        {
            Tamanho = largura * comprimento;
            return Tamanho;
        }

        

    }
}
