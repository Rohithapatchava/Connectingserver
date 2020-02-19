using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Connectingserver
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Data Source=BLT1040\SQLEXPRESS2014;Initial Catalog=Products;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    String querystr = "select * from prod";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
    }
}

    
