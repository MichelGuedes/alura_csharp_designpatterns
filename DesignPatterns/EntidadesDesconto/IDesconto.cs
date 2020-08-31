using DesignPatterns.Entidades;

namespace DesignPatterns.EntidadesDesconto
{
    public interface IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }
        public double Descontar(Orcamento orcamento);
    }
}
