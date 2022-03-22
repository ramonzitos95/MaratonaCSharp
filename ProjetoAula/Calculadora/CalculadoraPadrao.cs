using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula.Calculadora
{
    public class CalculadoraPadrao
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public CalculadoraPadrao(int n1, int n2)
        {
            Numero1 = n1;
            Numero2 = n2;
        }

        public int Somar()
        {
            return Numero1 + Numero2;
        }

        public int Dividir()
        {
            return Numero1 / Numero2;
        }

        public int Multiplicar()
        {
            return Numero1 * Numero2;
        }

        public int Subtracao()
        {
            return Numero1 - Numero2;
        }

        public void TestandoCalculadora()
        {
            Console.WriteLine($"Soma dos dois é: {this.Somar()}");
            Console.WriteLine($"Divisão dos dois é: {this.Dividir()}");
            Console.WriteLine($"Multiplicação dos dois é: {this.Multiplicar()}");
            Console.WriteLine($"Subtração dos dois é: {this.Subtracao()}");
        }
    }
}
