using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Conversor_de_Milhas
    {
        private decimal _milhasMaritimas;
        private const decimal _metrosPorMilhaMaritima = 1852;
        private const decimal _metrosPorQuilometro = 1000;

        public decimal MilhasMaritimas
        {
            get { return _milhasMaritimas; }
            set { _milhasMaritimas = value; }
        }

        public decimal ConverterParaQuilometros()
        {

            decimal metros = MilhasMaritimas * _metrosPorMilhaMaritima;
            decimal quilometros = metros / _metrosPorQuilometro;

            return quilometros;
        }
    }
}
