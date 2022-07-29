using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewJsonMemo
{
    public partial class Form1 : Form
    {
        TodoMemoController service = new TodoMemoController();

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            DisplayData();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            service.AddTodoMemo(new TodoMemo()
            {
                Title = this.txb_title.Text,
                IsDone = this.checkbx_isDone.Checked
            });
            DisplayData();
        }

        private void DisplayData()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = service.GetListTodoMemo();
        }
    }
}
