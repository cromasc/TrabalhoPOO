namespace Trabalho_Final
{
    internal class ConexaoString
    {
        string serverName = "localhost";
        string port = "5432";
        string username = "postgres";
        string password = "314159";
        string dataBaseName = "mypets";

        public string ConnString()
        {
            var connString = string.Format("Server = {0}; Port = {1}; Username = {2}; Password = {3}; Database = {4};", 
                serverName, port, username, password, dataBaseName);
            return connString;
        }
    }
}
