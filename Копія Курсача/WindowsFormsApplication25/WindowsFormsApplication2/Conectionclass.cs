using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Conectionclass
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataReader reader=null;
        public void sqlcon()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vova\Documents\Visual Studio 2015\Projects\WindowsFormsApplication25\WindowsFormsApplication2\Database1.mdf;Integrated Security=True");
            con.Open();
        }
        public void sqlquly(string qurytext)
        {
            sqlcon();
             cmd = new SqlCommand(qurytext,con);
        }
        public void nonqury()
        {
            //cmd = new SqlCommand();
            //cmd.ExecuteNonQuery();
            con.Close();
        }
        public string sqlread(string t1,string t2,string qurytext)
        {
            sqlquly(qurytext);
            
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (t1 == Convert.ToString(reader["Breakdown"]))
                {
                    t2= Convert.ToString(reader["Price"]);
                    if (reader != null)
                              reader.Close();
                        break;
                }
                else
                {
                    t2 = "Fuck";
                }
            }
            return t2;
        }
    }
}
