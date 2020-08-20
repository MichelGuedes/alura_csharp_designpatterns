using DesignPatterns.Entidades;
using DesignPatterns.Bll;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto icms = new ICMS();
            Orcamento orcamento = new Orcamento(500);
            double valorImposto = CalculadorImpostos.RealizaCalculo(orcamento, icms);

            Console.WriteLine("Valor de imposto calculado: " + valorImposto.ToString());
            Console.ReadKey();
        }
    }
}
