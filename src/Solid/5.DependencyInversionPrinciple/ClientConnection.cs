namespace Solid._5.DependencyInversionPrinciple
{
    public class ClientConnection
    {
        private IDbConnection _connection;
        public ClientConnection(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Open()
        {
            _connection.Conectar();
        }

        public void Close()
        {
            _connection.Desconectar();
        }
    }
}
