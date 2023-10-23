using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicThread1
{
    public partial class FrmBasicThread2 : Form
    {
        Thread ThreadA, ThreadB, ThreadC, ThreadD;
        
        public FrmBasicThread2()
        {
            InitializeComponent();
        }

        private void run2_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmBasicThread2_Load(object sender, EventArgs e)
        {

        }
    }
}
