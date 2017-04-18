using Solid._2.OpenClosedPrinciple;
using Solid._3.LiskovSubstitutionPrinciple;
using Solid._5.DependencyInversionPrinciple;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SingleResponsabilityPrinciple


            #endregion

            #region OpenClosedPrinciple
            var soma = new Soma();
            soma.PrimeiroNumero = 1;
            soma.SegundoNumero = 2;

            var subtracao = new Subtracao();
            subtracao.PrimeiroNumero = 1;
            subtracao.SegundoNumero = 2;

            var operacao = new Operacao();
            operacao.Executar(soma);
            operacao.Executar(subtracao);
            #endregion

            #region LiskovSubstitutionPrinciple

            var PessoJuridica = new PessoaJuridica();
            PessoJuridica.Nome = "Maria";
            PessoJuridica.Email = "maria@email.com";
            PessoJuridica.Cnpj = "12334234234";

            var Email = new Solid._3.LiskovSubstitutionPrinciple.Email();
            Email.EnviarDadosPessoa(PessoJuridica);
            #endregion

            #region InterfaceSegregationPrinciple


            #endregion

            #region DependencyInversionPrinciple
            var Sql = new ClientConnection(new SqlConnection());
            Sql.Open();

            var Oracle = new ClientConnection(new OracleConnection());
            Oracle.Open();

            #endregion
        }
    }
}
