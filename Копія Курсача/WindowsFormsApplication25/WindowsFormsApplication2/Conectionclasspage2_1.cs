using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Conectionclasspage2_1
    {
     
            public SqlConnection con;
            public SqlCommand cmd;
            public SqlDataReader reader = null;
            public void sqlcon()
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vova\Documents\Visual Studio 2015\Projects\WindowsFormsApplication25\WindowsFormsApplication2\Database1.mdf;Integrated Security=True");
                con.Open();
            }
            public void sqlquly(string qurytext)
            {
                sqlcon();
                cmd = new SqlCommand(qurytext, con);
            }
            public void nonqury()
            {
                //cmd = new SqlCommand();
                //cmd.ExecuteNonQuery();
                con.Close();
            }
            public List<string> sqlread( string qurytext)
            {
                sqlquly(qurytext);
            List<string> listBox = new List<string>();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                listBox.Add(Convert.ToString(reader["Id"]) + "   " + Convert.ToString(reader["Login"]) + "    " + Convert.ToString(reader["Password"]) + "     " + Convert.ToString(reader["Znuzka"]));
                }
                return listBox;
            }
        
    }
}
