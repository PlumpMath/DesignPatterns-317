using System;

namespace Solid._1.SingleResponsabilityPrinciple
{
    public class Email
    {
        public string De { get; set; }
        public string Para { get; set; }
        public string Descricao { get; set; }

        public void EnviarEmail()
        {
            Console.WriteLine("De: {0}, Para: {1}, Descricao: {2}", this.De, this.Para, this.Descricao);
        }
    }
}
