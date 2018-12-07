using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        SqlConnection conection;
        
        Form3 form3 = new Form3();
        Form2 form2 = new Form2();
        public Form1()
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
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [DBExit]", conection);
            try
            {
               // int count = 0, count1 = 0; 
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if ((Convert.ToString(reader["Login"]) == textBox1.Text) && (Convert.ToString(reader["Password"]) == textBox2.Text))
                    {
                        if(Convert.ToBoolean(reader["Admin"])==true)
                        {
                            form2.button3.Enabled = true;
                        }
                        else
                        {
                            form2.button3.Enabled = false;
                        }
                        form2.Show();
                        this.Hide();
                    }
                    else if ((Convert.ToString(reader["Login"]) != textBox1.Text) && (Convert.ToString(reader["Password"]) != textBox2.Text))
                    {
                        
                            label3.Visible = true;
                            label3.Text = "Fuck";
                    }


                    
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
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
