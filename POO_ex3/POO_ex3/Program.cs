using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado que;
            que = new Quadrado();

            que.setBase(5);
            que.setBase1(4);
            que.calcularArea();
            Console.WriteLine(que.getArea());
        }
    }
}
