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

namespace CookingReview
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

        private async void btn_cooking_Click(object sender, EventArgs e)
        {
            Cooking2 cooking = new Cooking2(4000);

            this.lbl_cookingStatus.Text = await cooking.CreateRice();
            this.lbl_cookingStatus.Text = await cooking.CreateSoup();
            this.lbl_cookingStatus.Text = await cooking.CreateFood();
            this.lbl_cookingStatus.Text = "Finished";
        }

        private async void btn_watching_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100_000_000; i++)
                {
                    if (i % 10_000_000 == 0)
                    {
                        this.lbl_watching.Text = i.ToString();
                        Thread.Sleep(1000);
                    }
                }
            });
            this.lbl_watching.Text = "Finished";
        }
    }
}
