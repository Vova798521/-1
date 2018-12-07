using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class _3Page : UserControl
    {
        private Conectionclass clascon;
        public _3Page()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }
                     
        private void _3Page_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a1;
            clascon = new Conectionclass();
            clascon.sqlcon();
            a1= clascon.sqlread(textBox1.Text,textBox2.Text, "SELECT * FROM [DBOrder]");
            textBox2.Text = a1;
            clascon.nonqury();
            
            //_1Page page = new _1Page();
            //SqlConnection conection = new SqlConnection();
            //string conectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vova\Documents\Visual Studio 2015\Projects\WindowsFormsApplication25\WindowsFormsApplication2\Database1.mdf;Integrated Security=True";
            //conection = new SqlConnection(conectionstring);
            //conection.Open();
            //SqlDataReader reader = null;
            //SqlCommand command = new SqlCommand("SELECT * FROM [DBOrder]", conection);
            //try
            //{
            //    reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        if (textBox1.Text == Convert.ToString(reader["Breakdown"]))
            //        {
            //            textBox2.Text = Convert.ToString(reader["Price"]);
            //            break;
            //        }
            //        else
            //        {
            //            textBox2.Text = "Fuck";
            //        }
                   
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    if (reader != null)
            //        reader.Close();
            //}
        }
    }
}
