using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmDinnerWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            lbl_process.Text = "Start";
           
            lbl_process.Text = "[1] Rice operating";
            Cooking.DoRice();

            lbl_process.Text = "[2] Soup operating";
            Cooking.DoSoup();

            lbl_process.Text = "[3] Egg operating";
            Cooking.DoEgg();

            
            sw.Stop();


            lbl_process.Text = "End Process";
            lbl_timer.Text = sw.ElapsedMilliseconds.ToString();
        }
    }
}
