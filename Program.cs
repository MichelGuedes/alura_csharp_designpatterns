using System;

namespace alura_csharp_designpatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeImposto calculador = new CalculadorDeImposto();

            Console.WriteLine("Calculando imposto ICMS sobre o orcamento: ");
            Orcamento orcamento = new Orcamento(60);
            Imposto icms = new ICMS();
            calculador.Calcula(orcamento, icms);

            Console.WriteLine("Calculando imposto ISS sobre o orcamento: ");
            Imposto iss = new ISS();
            Orcamento orcamento2 = new Orcamento(60);
            calculador.Calcula(orcamento2, iss);
        }
    }
}
