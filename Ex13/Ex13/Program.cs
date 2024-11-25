using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os três lados do triângulo:");
            int ladoA = int.Parse(Console.ReadLine());
            int ladoB = int.Parse(Console.ReadLine());
            int ladoC = int.Parse(Console.ReadLine());

            Triangulo
     triangulo = new Triangulo { LadoA = ladoA, LadoB = ladoB, LadoC = ladoC };

            if (triangulo.EhRetangulo())
            {
                Console.WriteLine("É um triângulo retângulo.");
            }
            else
            {
                Console.WriteLine("Não é um triângulo retângulo.");
            }
        }
    }
}
