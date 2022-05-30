using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cooking ck = new Cooking();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Rice rice = await ck.MakeRiceAsync();
            Soup soup = await ck.MakeSoupAsync();
            Egg egg = await ck.MakeEggAsync();

            sw.Stop();

            Console.WriteLine($"걸린 시간 : {sw.ElapsedMilliseconds}");
            Console.WriteLine("식사 준비 완료");
            Thread.Sleep(1);
            break;
    }
}
}
