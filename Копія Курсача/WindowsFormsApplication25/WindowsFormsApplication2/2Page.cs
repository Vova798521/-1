using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    
    public partial class _2Page : UserControl
    {
        SqlConnection conection = new SqlConnection();
        Conectionclasspage2_1 clascon;
        public _2Page()
        {
            InitializeComponent();
        }

        private void _2Page_Load(object sender, EventArgs e)
        {

            List<string> list1 = new List<string>();
            clascon = new Conectionclasspage2_1();
            clascon.sqlcon();
            list1 = clascon.sqlread("SELECT * FROM [DBExit]");

            for (int i = 0; i < 6; i++)
            {
                listBox1.Items.Add(list1[i]);
            }
            clascon.nonqury();

            //string conectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vova\Documents\Visual Studio 2015\Projects\WindowsFormsApplication25\WindowsFormsApplication2\Database1.mdf;Integrated Security=True";
            //conection = new SqlConnection(conectionstring);
            //conection.Open();
            //SqlDataReader reader = null;
            //SqlCommand command = new SqlCommand("SELECT * FROM [DBExit]", conection);
            //try
            //{
            //    reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        listBox1.Items.Add(Convert.ToString(reader["Id"])+"   "+Convert.ToString(reader["Login"])+"    "+ Convert.ToString(reader["Password"])+"     "+ Convert.ToString(reader["Znuzka"]));
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (label4.Visible == true)
                label4.Visible = false;            

            string conectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vova\Downloads\WindowsFormsApplication25\WindowsFormsApplication2\Database1.mdf;Integrated Security=True";
            conection = new SqlConnection(conectionstring);
            conection.Open();


            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [DBExit] SET [Znuzka]=@Znuzka WHERE [Id]=@Id", conection);
                command.Parameters.AddWithValue("Id", textBox1.Text);
                command.Parameters.AddWithValue("Znuzka", textBox2.Text);
                command.ExecuteNonQuery();
            }
            else if(!string.IsNullOrEmpty(textBox1.Text)&&!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                label4.Visible = true;
                label4.Text = "Поля логін або пароль не введені";
            }
            else
            {
                label4.Visible = true;
                label4.Text = "Поля логін або пароль не введені";

            }
        }
        int r = 244;
        int g = 65;
        int b = 65;
        private void timerB_Tick(object sender, EventArgs e)
        {
            if (g<=244)
            {
                b += 1;
                this.BackColor = Color.FromArgb(r,g,b);
                if(b>=244)
                {
                    timerB.Stop();
                    timerR.Start();
                }
            }

            if(g>=244)
            {
                b -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if (b <= 64)
                {
                    timerB.Stop();
                    timerR.Start();
                }
            }
        }

        private void timerG_Tick(object sender, EventArgs e)
        {
            if(r<=65)
            {
                g += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if( g>=244)
                {
                    timerG.Stop();
                    timerB.Start();                  
                }
            }
            if(r>=244)
            {
                g -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if(g<=65)
                {
                    timerG.Stop();
                    timerB.Start();
                }
            }
        }

        private void timerR_Tick(object sender, EventArgs e)
        {
            if(b>=244)
            {
                r -= 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if(r<=65)
                {
                    timerR.Stop();
                    timerG.Start();
                }
            }
            if(b<=65)
            {
                r += 1;
                this.BackColor = Color.FromArgb(r, g, b);
                if(r>=244)
                {
                    timerR.Stop();
                    timerG.Start();
                }
            }

        }
    }
}
