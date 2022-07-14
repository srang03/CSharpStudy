using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddThreadData(Thread.CurrentThread.ManagedThreadId.ToString());
            ClearDataList();
            func();
        }

        private void func()
        {
            AddThreadData(Thread.CurrentThread.ManagedThreadId.ToString());
            long sum = 0;
            for (int i = 0; i < 2_000_000_000; i++)
            {
                sum += i;
            }
        }
        private void AddThreadData(string thread)
        {
            if (!this.listBox1.Items.Contains(thread))
            {
                this.listBox1.Items.Add(thread);
            }
        }

        private void ClearDataList()
        {
            this.listBox1.Items.Clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ClearDataList();
            AddThreadData(Thread.CurrentThread.ManagedThreadId.ToString());
            Thread t1 = new Thread(func);
            t1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearDataList();
            AddThreadData(Thread.CurrentThread.ManagedThreadId.ToString());
            func();
        }
        // 비동기는 순차적으로 동작하지 않고 한번에 병렬로 동작하는 것
        // 비동기는 단일 스레드 형태로 동작이 가능하다.
        private void button4_Click(object sender, EventArgs e)
        {
            ClearDataList();
            AddThreadData(Thread.CurrentThread.ManagedThreadId.ToString());
            Task t1 = new Task(func);
            t1.Start();

            var t2 = Task.Run(() => func());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearDataList();
            Test1();
        }

        private async void Test1()
        {
            AddThreadData(Thread.CurrentThread.ManagedThreadId.ToString());
            await Sum();
        }

        private async Task<long> Sum()
        {
            long sum = 0;
            await Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 2_000_000_000; i++)
                {
                    sum += i;
                }
            });
            return sum;
        }
    }
}
