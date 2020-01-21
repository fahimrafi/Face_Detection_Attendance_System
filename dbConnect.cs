using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;


namespace MultiFaceRec
{
    public class dbConnect
    {
        public MySqlConnection Conn;
       // private MySqlCommand cmd;

        MySqlConnection connection = Initialize();
        dbConnect con = new dbConnect();
        public static MySqlConnection Initialize()
        {
            MySqlConnection connection;
            string connectionString;
            string server = "localhost";
            string database = "dbattendance";
            string uid = "root";
            string password = "";
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);

            return connection;
        }
    }
}