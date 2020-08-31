using DesignPatterns.Entidades;
using DesignPatterns.EntidadesDesconto;

namespace DesignPatterns.Bll
{
    public class CalculadorDeDescontos
    {
        public double CalcularDesconto (Orcamento orcamento)
        {
            IDesconto d1 = new DescontoMaisQuinhentosReais();
            IDesconto d2 = new DescontoPorCincoItens();
            IDesconto d3 = new DescontoVendaCasada();
            IDesconto semDesc = new SemDesconto();

            d1.ProximoDesconto = d2;
            d2.ProximoDesconto = d3;
            d3.ProximoDesconto = semDesc;

            return d1.Descontar(orcamento);
        }
    }
}
