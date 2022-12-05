using MySql.Data.MySqlClient;

namespace ConnectDB
{
    public class Connecti
    {
        string StrConnect;
        MySqlConnection Conn;

        public MySqlConnection Connection()
        {
            Conn = new MySqlConnection(StrConnect);
            return Conn;
        }
        public string RConn()
        {
            return StrConnect;
        }
        public Connecti(string connect)
        {
            StrConnect = connect;
        }
    }
}
