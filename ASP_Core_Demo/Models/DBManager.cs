using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ASP_Core_Demo.Models
{
    public class DBManager
    {
        static string ConString = @"Data Source=.; Initial Catalog=Demo; Integrated Security=True;";

        public static string ExecuteQuery(string sql)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataTable ExecuterAddpter(string getdata)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(getdata, ConString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
