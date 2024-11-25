using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Conversor_Dolar
    {
        private decimal valor;

        public Conversor_Dolar(decimal valor)
        {
            this.valor = valor;
        }

        public Conversor_Dolar Somar(Conversor_Dolar outraMoeda)
        {
            return new Conversor_Dolar(this.valor + outraMoeda.valor);
        }

        public Conversor_Dolar Multiplicar(decimal fator)
        {
            return new Conversor_Dolar(this.valor * fator);
        }

        public override string ToString()
        {
            return valor.ToString("C");
        }
    }
}
