using DesignPatterns.Entidades;

namespace DesignPatterns.Bll
{
    public static class CalculadorImpostos
    {
        public static double RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            return imposto.Calcula(orcamento);
        }
    }
}
