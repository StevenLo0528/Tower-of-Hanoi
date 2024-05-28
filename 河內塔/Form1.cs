using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 河內塔
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(層數.Text);
            步數.Clear();
            hanoi(n, 'A', 'B', 'C');
            步數.AppendText("\r\n從A移到C共走" + (Math.Pow(2, n) - 1) + "步");
        }

        void hanoi(int n, char A, char B, char C)
        {
            if (n == 1)
            {
                步數.AppendText("\r\n從" + A + "移到" + C + "\r\n");
            }
            else
            {
                hanoi(n - 1, A, C, B);
                步數.AppendText("\r\n從" + A + "移到" + C + "\r\n");
                hanoi(n - 1, B, A, C);
            }
        }
    }
}
