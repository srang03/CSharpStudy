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

namespace AsyncAwaitReview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_singleThread_Click(object sender, EventArgs e)
        {
            // 단일 스레드는 UI 스레드 하나에서만 동작하는 형태
            // UI를 그려주는 스레드에서 동시에 연산을 수행하면, 연산이 수행되는 시간동안 UI Freezing 발생
            ConfirmDuplicate($"UI  [T{Thread.CurrentThread.ManagedThreadId}]");
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");

            long sum = 0;
            for (long i = 0; i < 1_000_000_000; i++)
            {
                sum += i;
            }
            ConfirmDuplicate($"UI  [T{Thread.CurrentThread.ManagedThreadId}] End");
        }
        //public override string ToString()
        //{
        //    return Name;
        //}

        private void ConfirmDuplicate(string thread)
        {
            if (!this.list_thread.Items.Contains(thread))
            {
                if (this.list_thread.InvokeRequired)
                {
                    this.list_thread.Invoke(new MethodInvoker(() => this.list_thread.Items.Add(thread)));
                }
                else
                {
                    this.list_thread.Items.Add(thread);
                }
            }
        }

        private void btn_multiThread_Click(object sender, EventArgs e)
        {
            ConfirmDuplicate($"UI [T{Thread.CurrentThread.ManagedThreadId}]");
            Thread t1 = new Thread(TestFunction);
            t1.Start();
            ConfirmDuplicate($"UI [T{Thread.CurrentThread.ManagedThreadId}] End");
        }

        private void TestFunction()
        {
            ConfirmDuplicate($"[T{Thread.CurrentThread.ManagedThreadId}]");
            long sum = 0;
            for (long i = 0; i < 1_000_000_000; i++)
            {
                sum += i;
            }
            ConfirmDuplicate($"[T{Thread.CurrentThread.ManagedThreadId}] End");
        }

        private void btn_syncPrint_Click(object sender, EventArgs e)
        {
            // 동기 형태는 단일 스레드와 마찬가지로 하나의 스레드로 프로그램을 절차대로 수행한다.
            // UI를 그려주는 스레드에서 동시에 연산을 수행하면, 연산이 수행되는 시간동안 UI Freezing 발생
            ConfirmDuplicate($"UI  [T{Thread.CurrentThread.ManagedThreadId}]");
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");

            long sum = 0;
            for (long i = 0; i < 1_000_000_000; i++)
            {
                sum += i;
            }
            ConfirmDuplicate($"UI  [T{Thread.CurrentThread.ManagedThreadId}] End");
        }

        private void btn_asyncPrintSingle_Click(object sender, EventArgs e)
        {
            ConfirmDuplicate($"UI  [T{Thread.CurrentThread.ManagedThreadId}]");
            Task t1 = new Task(TestFunction);
            t1.Start();
            ConfirmDuplicate($"UI  [T{Thread.CurrentThread.ManagedThreadId}] End");
        }

        private void btn_asyncPrintMulti_Click(object sender, EventArgs e)
        {
            ConfirmDuplicate($"UI  [T{Thread.CurrentThread.ManagedThreadId}]");

        }

        private void TestFunction2()
        {
            ConfirmDuplicate($"[T{Thread.CurrentThread.ManagedThreadId}]");
            long sum = 0;
            for (long i = 0; i < 1_000_000_000; i++)
            {
                sum += i;
            }
            ConfirmDuplicate($"[T{Thread.CurrentThread.ManagedThreadId}] End");
        }


        private void btn_asyncPrintMulti2_Click(object sender, EventArgs e)
        {

        }
    }
}
