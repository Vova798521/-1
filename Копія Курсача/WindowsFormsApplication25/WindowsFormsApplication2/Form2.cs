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
            startPage1.BringToFront();
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Left = button1.Left;
            startPage1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Left = button2.Left;
            _1Page1.BringToFront();
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
            _2Page1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Left = button4.Left;
            _3Page1.BringToFront();
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

        private void _3Page1_Load(object sender, EventArgs e)
        {

        }
    }
}
