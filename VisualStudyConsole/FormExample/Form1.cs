using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExample
{
    public partial class Form1 : Form
    {
        event EventHandler click;

        public void callback(object sender, EventArgs e)
        {
            MessageBox.Show("callback");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            click = new EventHandler(callback);
            this.btn_execute.Click += click;
        }
    }
}
