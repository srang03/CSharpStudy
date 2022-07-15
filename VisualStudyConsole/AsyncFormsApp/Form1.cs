using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace AsyncFormsApp
{
    public partial class Form1 : Form
    {
        Timer timer =new Timer();
        int timerCount = 0;
        public Form1()
        {
            InitializeComponent();
            
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
;           Run();
            timer.Start();
            this.label1.Text = "Test";
            timerCount = 0;
        }
        
        private void TimerTick(object sender, EventArgs e)
        {
            this.progressBar1.PerformStep();
            if(timerCount == 10)
            {
                timer.Stop();
            }
        }

        private async void Run()
        {
            var t1 = Task.Run(() => SumAll());
            long sum = await t1;
            this.label1.Text = sum.ToString();
        }

        private long SumAll()
        {
            Thread.Sleep(2000);
            long sum = 0;
            for (int i = 0; i < 1_000_000_000; i++)
            {
                sum += i;
            }
           
            return sum;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Blocks;
          
        }
    }
}
