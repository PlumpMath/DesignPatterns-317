namespace Solid._4.InterfaceSegregationPrinciple
{
    public interface IComissinado : IFuncionario
    {
        double Vendas { get; set; }
        double TxComissao { get; set; }
        double GetComissao();
    }
}
