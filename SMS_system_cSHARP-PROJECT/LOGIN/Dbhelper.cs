using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN
{

    public class Result
    {
        public DataTable Data { get; set; }
        public bool HasError { get; set; }
        public string Message { get; set; }
    }


    internal class Dbhelper
    {
        public static SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=smsSystem;Integrated Security=True;TrustServerCertificate=True");
        public static Result GetQueryData(string query)
        {
            var result = new Result();
            try
            {

                Con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);//table ke data set convert
                DataTable dt = ds.Tables[0];
                Con.Close();
                result.Data = dt;
            }
            catch (Exception e)
            {
                result.HasError = true;
                result.Message = e.Message;
                return result;

            }
            return result;
        }
        public static Result ExecuteNonresultquery(string query)
        {
            var result = new Result();
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception e)
            {
                result.HasError = true;
                result.Message = e.Message;
                return result;
            }
            return result;
        }
    }
}
