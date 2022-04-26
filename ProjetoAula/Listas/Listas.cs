using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAula;

namespace ProjetoAula.Listas
{
    internal class Listas
    {
        public Listas()
        {
            var casas = new List<Casa>();
            var casa1 = new Casa
            {
                QuantidadeDeJanelas = 3,
                QuantidadeDePortas = 2
            };
            casas.Add(casa1);
            var casa2 = new Casa
            {
                QuantidadeDeJanelas = 5,
                QuantidadeDePortas = 4
            };
            casas.Add(casa2);

            foreach (var casa in casas)
            {
                casa.AlugarCasa();
            }

            var casas2 = new List<Casa>()
            {
                new Casa(100, "Vermelha"),
                new Casa(200, "Vermelha"),
                new Casa(300, "Vermelha"),
                new Casa(400, "Vermelha"),
            };

            foreach (var casa in casas2)
            {
                casa.CalcularAreaCasa(20, 50);
            }
        }
    }
}
