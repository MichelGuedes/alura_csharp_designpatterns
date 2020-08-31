using System.Collections.Generic;

namespace DesignPatterns.Entidades
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<ItemOrcamento> Itens { get; private set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<ItemOrcamento>();
        }

        public void AdicionaItemOrcamento(ItemOrcamento item)
        {
            this.Itens.Add(item);
        }
    }
}