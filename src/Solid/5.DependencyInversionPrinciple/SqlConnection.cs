using System;

namespace Solid._5.DependencyInversionPrinciple
{
    public class SqlConnection : IDbConnection
    {
        public void Conectar()
        {
            Console.WriteLine("Sql Conectando..");
        }

        public void Desconectar()
        {
            Console.WriteLine("Sql Desconectando..");
        }
    }
}
