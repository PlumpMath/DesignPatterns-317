using System;

namespace Solid._3.LiskovSubstitutionPrinciple
{
    public class Email
    {
        public void EnviarDadosPessoa(Pessoa pessoa)
        {
            Console.WriteLine(pessoa.RetornarDados());
        }
    }
}
