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
    public partial class _1Page : UserControl
    {
         Conectionclasspage1 clascon;
        public _1Page()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conection = new SqlConnection();
            
            clascon = new Conectionclasspage1();
            clascon.sqlcon();
            label4.Text= clascon.sqlread(textBox1.Text,textBox2.Text,textBox3.Text, "INSERT INTO [DBOrder] (Breakdown,Time,Adres)VALUES(@Breakdown,@Time,@Adres)");

          
            clascon.nonqury();

            //if (label4.Visible == true)
            //    label4.Visible = false;
            //string conectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vova\Documents\Visual Studio 2015\Projects\WindowsFormsApplication25\WindowsFormsApplication2\Database1.mdf;Integrated Security=True";
            //conection = new SqlConnection(conectionstring);
            //conection.Open();


            //if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
            //    !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
            //    !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            //{
            //    SqlCommand command = new SqlCommand("INSERT INTO [DBOrder] (Breakdown,Time,Adres)VALUES(@Breakdown,@Time,@Adres)", conection);
            //    command.Parameters.AddWithValue("Breakdown", textBox1.Text);
            //    command.Parameters.AddWithValue("Time", Convert.ToDateTime(textBox2.Text));
            //    command.Parameters.AddWithValue("Adres", textBox3.Text);
            //    command.ExecuteNonQuery();
            //    label4.Visible = true;
            //    label4.Text = "Реєстрація замовлення прошла успішно!!!";

            //}
            //else
            //{
            //    label4.Visible = true;
            //    label4.Text = "Поля поломки або дати або адреси не введені";
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void _1Page_Load(object sender, EventArgs e)
        {

        }
    }
}
