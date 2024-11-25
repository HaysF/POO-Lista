using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Triangulo
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }

        public bool EhRetangulo()
        {
            int[] lados = { LadoA, LadoB, LadoC };
            Array.Sort(lados);

            return lados[2] * lados[2] == lados[0] * lados[0] + lados[1] * lados[1];
        }
    }
}
