using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "")
            {
                MessageBox.Show("نام و نام خانوادگی را وارد کنید");
            }
            else if (txtuname.Text == "")
            {
                MessageBox.Show("نام کاربری را وارد کنید");
            }
            else if (txtnumber.Text == "")
            {
                MessageBox.Show("شماره تلفن خود را وارد کنید");
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("‍‍‍‍پسورد خود را وارد کنید");
            }
            else if (txtrepass.Text == "")
            {
                MessageBox.Show("تکرار پسورد را وارد کنید");
            }
            else if (txtpass.Text != txtrepass.Text)
            {
                MessageBox.Show("تکرار پسورد صحیح نمیباشد");
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source= database41.accdb";
                con.Open();
                OleDbCommand com = new OleDbCommand();
                com.CommandText = "insert into [user] ([fname],[username],[phonenumber],[password]) values (?,?,?,?)";
                com.Parameters.AddWithValue("@fname", txtfname);
                com.Parameters.AddWithValue("@username", txtuname);
                com.Parameters.AddWithValue("@phonenumber", txtnumber);
                com.Parameters.AddWithValue("@password", txtrepass);
                com.Connection = con;
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("اطلاعات ثبت شد");
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
