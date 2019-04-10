using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\HomeWork2\HomeWork2\Database.mdf;Integrated Security=True";
            string sqlQuery = "CREATE TABLE gruppa ( Id int not null, Name varchar(255) null)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Таблица создана");
            }
            Console.Read();
        }
    }
}
