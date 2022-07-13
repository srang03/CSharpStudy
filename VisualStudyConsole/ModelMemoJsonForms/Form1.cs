using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelMemo;


namespace ModelMemoJsonForms
{
    public partial class Form1 : Form
    {
        private IRepositoryService _repository;
        public Form1()
        {
            InitializeComponent();
            _repository = new RepositoryServiceJson();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ListModel();
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            var res = _repository.AddMemo(new Model()
            {
                Title = this.textBox1.Text,
                IsDone = this.checkBox1.Checked
            });

            if (res)
            {
                MessageBox.Show("정상적으로 등록되었습니다.");
                this.textBox1.Text = string.Empty;
                this.checkBox1.Checked = false;
                
            }
            else
            {
                MessageBox.Show("정상적으로 등록되지 않았습니다.");
            }

            ListModel();
        }

        private void ListModel()
        {
            this.dataGridView1.DataSource = null; // 초간단 Refresh
            this.dataGridView1.DataSource = _repository.ListModel();
        }
    }
}
