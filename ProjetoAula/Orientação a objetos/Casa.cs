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

        public void VenderCasa()
        {
            Console.WriteLine("A casa foi vendida");
        }

        public void AlugarCasa()
        {
            Console.WriteLine("A casa foi alugada");
        }

        

    }
}
