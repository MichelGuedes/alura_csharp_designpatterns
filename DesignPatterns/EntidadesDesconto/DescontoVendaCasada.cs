using DesignPatterns.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.EntidadesDesconto
{
    public class DescontoVendaCasada : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            List<ItemOrcamento> lstItensOrcamentos = 
                orcamento.Itens
                    .Where(i => i.Nome.Contains("caneta")).Select(i => i)
                    .Where(i => i.Nome.Contains("lapis")).Select(i => i).ToList();

            if (lstItensOrcamentos.Count >= 2){
                return orcamento.Valor * 0.05;
            }

            return ProximoDesconto.Descontar(orcamento);
        }
    }
}
