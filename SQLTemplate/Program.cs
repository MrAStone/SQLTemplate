using MySqlConnector;
namespace SQLTemplate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server,username,password,database;
            Console.Write("Enter server IP: ");
            server = Console.ReadLine();
            Console.Write("Enter username: ");
            username = Console.ReadLine();
            Console.Write("Enter password: ");
            password = Console.ReadLine();
            Console.Write("Enter database: ");
            database = Console.ReadLine();
            MySqlConnection conn = con(server,username,password,database);
            
        }
        static MySqlConnection con(string server,string user, string password, string database)
        {
            string connectDetails = $"server={server};uid={user};password={password};database={database}";
            MySqlConnection con = new MySqlConnection(connectDetails);
            return con;
        }
    }
}
