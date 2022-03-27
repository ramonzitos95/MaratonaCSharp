using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.For_e_For_each
{
    public class ForForEach
    {
        public ForForEach()
        {
            List<string> nomes = new List<string>()
            {
                "Ramon",
                "João",
                "Henrique",
                "Fernando",
                "Lucas"
            };

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

        }
    }
}
