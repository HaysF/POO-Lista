using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do dólar: ");
            decimal cotacao = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de dólares: ");
            decimal quantidadeDolares = decimal.Parse(Console.ReadLine());

            Conversor_Dolar dolar = new Conversor_Dolar(quantidadeDolares);
            Conversor_Dolar real = dolar.Multiplicar(cotacao);

            Console.WriteLine($"O valor em reais é: {real}");
        }
    }
}
