namespace Solid._3.LiskovSubstitutionPrinciple
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public override string RetornarDados()
        {
            return base.RetornarDados() + " " + Cnpj;
        }
    }
}
