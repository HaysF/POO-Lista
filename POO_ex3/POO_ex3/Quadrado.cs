using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ex3
{
    internal class Quadrado
    {
        private int b;
        private int b1;
        private int area;
        public void setBase(int b)
        {
            this.b = b;
        }
        public void setBase1(int b1)
        {
            this.b1 = b1;
        }
        public int getBase()
        {
            return this.b;
        }
        public int getAltura()
        {
            return this.b1;
        }
        public int getArea()
        {
            return this.area;
        }
        public void calcularArea()
        {
            this.area = (this.b * this.b1) / 2;
        }
    }
}
