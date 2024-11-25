using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
    
            int numero2 = int.Parse(Console.ReadLine());


            Comparador_de_Dois_Numeros num1 = new Comparador_de_Dois_Numeros(numero1);
            Comparador_de_Dois_Numeros num2 = new Comparador_de_Dois_Numeros(numero2);

            if (num1.MaiorQue(num2))
            {
                Console.WriteLine("O maior número é: " + num1);
            }
            else
            {
                Console.WriteLine("O maior número é: " + num2);
            }
        }
    }
}
