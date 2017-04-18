namespace Solid._2.OpenClosedPrinciple
{
    public class Operacao
    {
        public double Executar(IOperacao operacao)
        {
            return operacao.Executar();
        }
    }
}
