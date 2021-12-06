using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace webForm
{
    class dbcon
    {
        SqlConnection con;
        public dbcon(string connectionstring)
        {
            connection(connectionstring);
        }

        private void connection(string connectionstring)
        {
            con = new SqlConnection(connectionstring);
        }
        public bool UDI(string qry)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            bool check = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return check;
        }
        public DataTable search(string qry)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Close();
            return dt;
        }
    }
}
