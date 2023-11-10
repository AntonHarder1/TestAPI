using System;
using Microsoft.Data.SqlClient;
using System.Text;
using System;
using Microsoft.Data.SqlClient;
using System.Text;

namespace TestAPI.Services
{
    public class DbConnect
    {

        public Boolean Forbind()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "sweden.database.windows.net";
                builder.UserID = "test_db_gæs";
                builder.Password = "12ahkk##";
                builder.InitialCatalog = "test_1";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    String sql = "select * from table_1";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //Console.WriteLine(reader.Read());
                                Console.WriteLine("{0} {1}", reader.GetInt32(0), reader.GetString(1));

                                //if (!reader.Read()) break;
                            }
                            
                            
                        }
                       
                        connection.Close();

                        return true;
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();

            return true;
        }
    }
}