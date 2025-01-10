using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("نام کاربری خود را وارد کنید");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("پسورد خود را وارد کنید");
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;data source=database41.accdb";
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.CommandText = "select count(*) from [user] where username=? and password=?";
                command.Parameters.AddWithValue("@username",textBox1.Text);
                command.Parameters.AddWithValue("@password",textBox2.Text);
                command.Connection = con;   
                command.ExecuteScalar();
                MessageBox.Show("خوش آمدید");
                Form3 form3 = new Form3();  
                this.Hide();    
                form3.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
