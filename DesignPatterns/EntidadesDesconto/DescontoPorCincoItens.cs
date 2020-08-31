﻿using DesignPatterns.Entidades;

namespace DesignPatterns.EntidadesDesconto
{
    public class DescontoPorCincoItens: IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }
        public double Descontar(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }

            return ProximoDesconto.Descontar(orcamento);
        }
    }
}
