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
    public partial class Form4 : Form
    {
        public string username {  get; set; }
        public string pplatformname {  get; set; }
        public string date {  get; set; }
        public string password {  get; set; }
        public int ID {  get; set; }
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text=username;
            textBox2.Text=pplatformname;
            textBox3.Text=date;
            textBox4.Text=password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;data source=database41.accdb";
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "update [passwords] set [username]=?,[platformname]=?,[datee]=?,[password]=? where [ID]=?";

            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@platformname", textBox2.Text);
            cmd.Parameters.AddWithValue("@datee", textBox3.Text);
            cmd.Parameters.AddWithValue("@password", textBox4.Text);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("ویرایش انجام شد");
            Form3 form3 = new Form3();  
            this.Hide();
            form3.ShowDialog(); 
        }
    }
}
