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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            conn = new OleDbConnection("provider=Microsoft.ace.oledb.12.0;data source =database41.accdb");// ارتباط با پایگاه داده
            adapter = new OleDbDataAdapter("SELECT * FROM passwords", conn);

            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("کامل کردن تمام فیلدها اجباریست");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("کامل کردن تمام فیلدها اجباریست");
            }
            else if(textBox3.Text == "")
            {
                MessageBox.Show("کامل کردن تمام فیلدها اجباریست");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("کامل کردن تمام فیلدها اجباریست");
            }
            else
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;data source=database41.accdb";
                con.Open();
                OleDbCommand com = new OleDbCommand();
                com.CommandText = "insert into [passwords]([username],[platformname],[datee],[password]) values(?,?,?,?)";
                com.Parameters.AddWithValue("@username",textBox1.Text);
                com.Parameters.AddWithValue("@platformname",textBox2.Text);
                com.Parameters.AddWithValue("@datee",textBox3.Text);
                com.Parameters.AddWithValue("@password",textBox4.Text);
                com.Connection = con;   
                com.ExecuteNonQuery();
                MessageBox.Show("اطلاعات ثبت شد");
                Form3 form3 = new Form3();
                this.Hide();
                form3.ShowDialog();


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var qsl = MessageBox.Show("از این عمل اطمینان دارید؟", "هشدار", MessageBoxButtons.YesNo);
            if (qsl == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = "Provider=Microsoft.ace.oledb.12.0;data source=database41.accdb";
                    con.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.CommandText = "delete from [passwords] where [ID]=?";
                    command.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells["ID"].Value);
                    command.Connection=con;
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("با موفیقت حذف شد");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.username = dataGridView1.CurrentRow.Cells["username"].Value.ToString();
            form4.pplatformname = dataGridView1.CurrentRow.Cells["platformname"].Value.ToString();
            form4.date = dataGridView1.CurrentRow.Cells["datee"].Value.ToString();
            form4.password = dataGridView1.CurrentRow.Cells["password"].Value.ToString();
            form4.ID = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            this.Hide();
            form4.ShowDialog();
        }
    }
}
