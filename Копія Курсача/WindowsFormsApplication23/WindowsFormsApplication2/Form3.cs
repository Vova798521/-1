using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        SqlConnection conection;
       
        Form2 form3 = new Form2();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label3.Visible)
                label3.Visible = false;

            string conectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\users\vova\documents\visual studio 2015\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Database1.mdf;Integrated Security=True";
            conection = new SqlConnection(conectionstring);
            conection.Open();


            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [DBExit] (Login,Password)VALUES(@Login,@Password)", conection);
                command.Parameters.AddWithValue("Login", textBox1.Text);
                command.Parameters.AddWithValue("Password", textBox2.Text);
                command.ExecuteNonQuery();
                label3.Visible = true;
                label3.Text = "Реєстрація прошла успішно!!!";
            }
            else
            {
                label3.Visible = true;
                label3.Text = "Поля логін або пароль не введені";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
