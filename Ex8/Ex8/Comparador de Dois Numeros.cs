using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    internal class Comparador_de_Dois_Numeros
    {
        private int valor;

        public Comparador_de_Dois_Numeros(int valor)
        {
            this.valor = valor;
        }

        public bool MaiorQue(Comparador_de_Dois_Numeros outroNumero)
        {
            return this.valor > outroNumero.valor;
        }

        public override string ToString()
        {
            return valor.ToString();
        }
    }
}
