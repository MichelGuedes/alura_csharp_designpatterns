using System;

namespace alura_csharp_designpatterns
{
    public class CalculadorDeImposto
    {
        public void Calcula(Orcamento orcamento, Imposto estrategiaDeImposto){
            double r = estrategiaDeImposto.Calcula(orcamento);
            Console.WriteLine("Valor calculado: " + Convert.ToString(r));
        }
    }
}