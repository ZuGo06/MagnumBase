using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarketBase
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
            Form frm = new Form2();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form5();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Form8();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new Form11();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new Form14();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = new Form17();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm = new Form20();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Form23();
            frm.Show();
        }
    }
}
