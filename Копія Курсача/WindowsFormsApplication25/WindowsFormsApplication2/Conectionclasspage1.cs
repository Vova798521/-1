using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Conectionclasspage1
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
        public string sqlread(string t1,string t2,string t3,  string qurytext)
        {
            sqlquly(qurytext);
            string l1;
            sqlcon();
            if (!string.IsNullOrEmpty(t1) && !string.IsNullOrWhiteSpace(t1) &&
               !string.IsNullOrEmpty(t2) && !string.IsNullOrWhiteSpace(t2) &&
                !string.IsNullOrEmpty(t3) && !string.IsNullOrWhiteSpace(t3))
            {
                cmd.Parameters.AddWithValue("Breakdown", t1);
                   cmd.Parameters.AddWithValue("Time", Convert.ToDateTime(t2));
                    cmd.Parameters.AddWithValue("Adres", t3);
                    cmd.ExecuteNonQuery();
                    
                  l1 = "Реєстрація замовлення прошла успішно!!!";
            }
            else
            {
                l1 = "Поля поломки або дати або адреси не введені";
            }
            return l1;
        }
    }
}
