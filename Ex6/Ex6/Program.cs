using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conversor_de_Milhas conversor = new Conversor_de_Milhas();

            conversor.MilhasMaritimas = (100);

            decimal resultado = conversor.ConverterParaQuilometros();
            Console.WriteLine($"{conversor.MilhasMaritimas} milhas marítimas equivalem a {resultado} quilômetros.");
        }
    }
}
