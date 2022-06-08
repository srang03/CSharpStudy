using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    
    public partial class Form1 : Form
    {
        private string str = "Data Source=DESKTOP-7T67K5V;Initial Catalog=DevTodoList;User ID=root;Password=root;database=DevTodoList;Connect Timeout=30;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("타이틀을 입력해주세요");
            }
            else
            {
                InsertTodo();
                ShowAll();
            }
        }

        private void InsertTodo()
        {
            string proc = "dbo.CreateTodo";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = str;

            conn.Open();
            SqlCommand cmd = new SqlCommand(proc, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TITLE", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@ISDONE", this.checkBox1.Checked);

            cmd.ExecuteNonQuery();

            MessageBox.Show("추가가 완료되었습니다.");
            conn.Close();

        }

        private void ShowAll()
        {
            string proc = "dbo.ListTodo";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = str;

            SqlCommand cmd = new SqlCommand(proc, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds);
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAll();
        }
    }
}
