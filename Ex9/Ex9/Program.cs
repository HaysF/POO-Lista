using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número inteiro: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
    
            int numero2 = int.Parse(Console.ReadLine());


            Comparador_de_Numeros comparador = new Comparador_de_Numeros(numero1, numero2);
            comparador.CompararEExibirMaior();
        }
    }
}
