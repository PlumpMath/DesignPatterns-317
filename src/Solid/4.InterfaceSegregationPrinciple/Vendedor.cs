namespace Solid._4.InterfaceSegregationPrinciple
{
    public class Vendedor : IComissinado
    {
        public double Vendas { get; set; }
        public double TxComissao { get; set; }

        public double GetComissao()
        {
            return Vendas * TxComissao;
        }

        public double Salario { get; set; }
        public double GetSalario()
        {
            return GetComissao() + Salario;
        }
    }
}
