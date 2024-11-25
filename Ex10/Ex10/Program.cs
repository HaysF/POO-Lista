using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da base do retângulo:");
            int baseRetangulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do retângulo:");
            int alturaRetangulo = int.Parse(Console.ReadLine());

            Calcular_Area_Retangulo retangulo = new Calcular_Area_Retangulo();
            retangulo.Base = baseRetangulo;
            retangulo.Altura = alturaRetangulo;

            int area = retangulo.CalcularArea();

            Console.WriteLine($"A área do retângulo é: {area}");

            if (area > 100)
            {
                Console.WriteLine("Terreno grande");
            }
            else
            {
                Console.WriteLine("Terreno pequeno");
            }
        }
    }
}
