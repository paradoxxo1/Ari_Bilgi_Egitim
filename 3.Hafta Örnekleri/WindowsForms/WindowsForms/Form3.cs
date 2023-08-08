using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1900; i < 2024; i++)
            {
                comboBox3.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] arabalar = { "BMW", "Mercedes", "Audi", "Porsche" };
            //for (int i = 0; i < 4; i++)                   Farklı bir Yol
            //{
            //    listBox2.Items.Add(arabalar[i]);
            //}

            foreach (string item in arabalar)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
