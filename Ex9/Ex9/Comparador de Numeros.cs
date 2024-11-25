using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    internal class Comparador_de_Numeros
    {
        private int valor1;
        private int valor2;

        public Comparador_de_Numeros(int valor1, int valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public void CompararEExibirMaior()
        {
            if (valor1 > valor2)
            {
                Console.WriteLine("O maior número é: " + valor1);
            }
            else if (valor2 > valor1)
            {
                Console.WriteLine("O maior número é: " + valor2);
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
        }
    }
}
