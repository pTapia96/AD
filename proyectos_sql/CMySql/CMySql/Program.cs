using System;
using MySql.Data.MySqlClient;

namespace CMySql
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Acceso a dbprueba");
            MySqlConnection mySqlConnection = new MySqlConnection(
                "server=localhost;database=dbprueba;user=root;password=sistemas;ssl-mode=none");

            mySqlConnection.Open();
        }
    }
}
