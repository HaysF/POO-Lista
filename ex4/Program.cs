using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triângulo tri;
            tri = new Triângulo();

            Console.WriteLine("Digite um valor para Base do triângulo:   ");
            tri.setBase(int.Parse(Console.ReadLine()));

            Console.WriteLine("Digite um valor para Altura do triângulo;   ");
            tri.setAltura(int.Parse(Console.ReadLine()));


            tri.calcularArea();
            Console.Write("O valor da area do triângulo é:   ");
            Console.WriteLine(tri.getArea());



        }
    }
}
