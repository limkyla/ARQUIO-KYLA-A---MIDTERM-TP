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
using System.Threading;
using System.Runtime.InteropServices;

namespace FrmBasicThread1
{
    public partial class Form1 : Form
    {
    static Thread ThreadA, ThreadB, ThreadC, ThreadD;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void run1_Click(object sender, EventArgs e)
        {
            threadStarts.Text = "-Thread Starts-";
            Console.WriteLine(threadStarts.Text);
            ThreadA = new Thread(MyThreadClass.Thread1);
            ThreadB = new Thread(MyThreadClass.Thread2);
            ThreadC = new Thread(MyThreadClass.Thread1);
            ThreadD = new Thread(MyThreadClass.Thread2);

            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;

            ThreadA.Name = "ThreadA";
            ThreadB.Name = "ThreadB";
            ThreadC.Name = "ThreadC";
            ThreadD.Name = "ThreadD";

            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();

            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();
            threadStarts.Text = "-End of Thread-";
            Console.WriteLine(threadStarts.Text);
        }
    }
}
