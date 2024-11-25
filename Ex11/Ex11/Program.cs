using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o peso (em kg): ");
            decimal peso = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a altura (em metros): ");
            decimal altura = decimal.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(peso, altura);
            string classificacao = pessoa.ClassificarImc();

            Console.WriteLine($"Sua classificação de peso é: {classificacao}");
        }
    }
}
