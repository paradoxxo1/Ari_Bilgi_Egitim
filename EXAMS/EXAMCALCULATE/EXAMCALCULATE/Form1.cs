using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMCALCULATE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string guncelzaman = DateTime.Now.ToLongTimeString();
            string girilendeger = textBox1.Text;
            TimeSpan zamanfarki = DateTime.Parse(girilendeger).Subtract(DateTime.Parse(guncelzaman));
            string fark = zamanfarki.ToString();
            label1.Text = fark.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            textBox1.Clear();

            label1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
