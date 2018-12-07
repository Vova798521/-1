using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    
    public partial class Form2 : Form
    {
        public SqlConnection conection = new SqlConnection();


        public Form2()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Left = button1.Left;
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            string conectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vova\Desktop\Копія Курсача\WindowsFormsApplication23\WindowsFormsApplication2\Database1.mdf;Integrated Security=True";
            conection = new SqlConnection(conectionstring);
            conection.Open();
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [DBExit]", conection);
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(Convert.ToString(reader["Id"]) + "   " + Convert.ToString(reader["Login"]) + "    " + Convert.ToString(reader["Password"]) + "     " + Convert.ToString(reader["Znuzka"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }


            if (label4.Visible == true)
                label4.Visible = false;
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Left = button1.Left;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Left = button2.Left;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Left = button3.Left;
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Left = button4.Left;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Left = button5.Left;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void _2Page1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection conection = new SqlConnection();
            if (label4.Visible == true)
                label4.Visible = false;
            string conectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vova\Desktop\Копія Курсача\WindowsFormsApplication23\WindowsFormsApplication2\Database1.mdf;Integrated Security=True";
            conection = new SqlConnection(conectionstring);
            conection.Open();


            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [DBOrder] (Breakdown,Time,Adres)VALUES(@Breakdown,@Time,@Adres)", conection);
                command.Parameters.AddWithValue("Breakdown", textBox1.Text);
                command.Parameters.AddWithValue("Time", Convert.ToDateTime(textBox2.Text));
                command.Parameters.AddWithValue("Adres", textBox3.Text);
                command.ExecuteNonQuery();
                label4.Visible = true;
                label4.Text = "Реєстрація замовлення прошла успішно!!!";

            }
            else
            {
                label4.Visible = true;
                label4.Text = "Поля поломки або дати або адреси не введені";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string conectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vova\Desktop\Копія Курсача\WindowsFormsApplication23\WindowsFormsApplication2\Database1.mdf;Integrated Security=True";
            conection = new SqlConnection(conectionstring);
            conection.Open();


            if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [DBExit] SET [Znuzka]=@Znuzka WHERE [Id]=@Id", conection);
                command.Parameters.AddWithValue("Id", textBox4.Text);
                command.Parameters.AddWithValue("Znuzka", textBox5.Text);
                command.ExecuteNonQuery();
            }
            else if (!string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text))
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
    }
}
      
            
            


  
