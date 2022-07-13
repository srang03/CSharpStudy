using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.progressBar1.Style = ProgressBarStyle.Blocks;
            
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            
            long sum = 0;
       
            for (long i = 0; i < 1_000_000_000; i++)
            {
                sum += i;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }
    }
}
