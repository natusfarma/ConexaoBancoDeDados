
using MySql.Data.MySqlClient;

namespace Connection.DataBase
{
    public class ConnectionMysql : ConnectionDB<MySqlConnection>
    {
        private static MySqlConnection dbConnection;

        public ConnectionMysql(string stringConnection) : base(dbConnection)
        {
            dbConnection = new MySqlConnection(stringConnection);
        }

        public override MySqlConnection DbConnection()
        {
            return dbConnection;
        }
    }

}