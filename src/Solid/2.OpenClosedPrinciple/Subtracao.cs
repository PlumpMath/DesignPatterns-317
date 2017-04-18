namespace Solid._2.OpenClosedPrinciple
{
    public class Subtracao : IOperacao
    {
        public double PrimeiroNumero { get; set; }
        public double SegundoNumero { get; set; }

        public double Executar()
        {
            return PrimeiroNumero - SegundoNumero;
        }
    }
}
