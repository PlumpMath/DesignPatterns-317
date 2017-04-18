namespace Solid._1.SingleResponsabilityPrinciple
{
    public class Estoque
    {
        public int Qtde { get; set; }
        public Produto Produto { get; set; }

        public void AtualizarEstoque(int qtde)
        {
            this.Qtde += qtde;
        }
    }
}
