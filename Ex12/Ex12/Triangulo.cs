using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class Triangulo
    {
        private int ladoA;
        private int ladoB;
        private int ladoC;

        public Triangulo(int a, int b, int c)
        {
            ladoA = a;
            ladoB = b;
            ladoC = c;
        }

        public
     bool EhTriangulo()
        {
            return ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA;
        }

        public string Classificar()
        {
            if (!EhTriangulo())
            {
                return "Não forma um triângulo";
            }

            if (ladoA == ladoB && ladoB == ladoC)
            {
                return "Equilátero";
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";

            }
        }
    }
}
