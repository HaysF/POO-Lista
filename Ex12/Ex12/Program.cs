using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o lado A: ");
            int ladoA = int.Parse(Console.ReadLine());

            Console.Write("Digite o lado B: ");
            int ladoB = int.Parse(Console.ReadLine());

            Console.Write("Digite o lado C: ");
            int ladoC = int.Parse(Console.ReadLine());

            Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);

            Console.WriteLine(triangulo.Classificar());
        }
    }
}
