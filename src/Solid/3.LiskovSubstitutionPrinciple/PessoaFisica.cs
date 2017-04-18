namespace Solid._3.LiskovSubstitutionPrinciple
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public override string RetornarDados()
        {
            return base.RetornarDados() + " " + Cpf;
        }
    }
}
