using DesignPatterns.Entidades;

namespace DesignPatterns.EntidadesDesconto
{
    public class DescontoMaisQuinhentosReais: IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }

            return ProximoDesconto.Descontar(orcamento);
        }
    }
}
