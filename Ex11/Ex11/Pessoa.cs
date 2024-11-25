using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    internal class Pessoa
    {
        private decimal peso;
        private decimal altura;

        public Pessoa(decimal peso, decimal altura)
        {
            Peso = peso;
            Altura = altura;
        }

        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public decimal Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public string
     ClassificarImc()
        {
            decimal imc = Peso / (Altura * Altura);

            if (imc < 20)
            {
                return "Abaixo do peso";
            }
            else if (imc < 25)
            {
                return "Peso ideal";
            }
            else
            {
                return "Acima do peso";
            }
        }
    }
}
