using System;

namespace Solid._5.DependencyInversionPrinciple
{
    public class OracleConnection : IDbConnection
    {
        public void Conectar()
        {
            Console.WriteLine("Oracle conectando..");
        }

        public void Desconectar()
        {
            Console.WriteLine("Oracle desconectando..");
        }
    }
}
