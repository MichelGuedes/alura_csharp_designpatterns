namespace DesignPatterns.Entidades
{
    public class ItemOrcamento
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemOrcamento (string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}