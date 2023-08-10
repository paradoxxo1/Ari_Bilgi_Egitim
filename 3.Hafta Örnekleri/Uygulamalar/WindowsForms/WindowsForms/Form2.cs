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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fatura = Convert.ToInt32(textBox1.Text);
            int kdv = Convert.ToInt32(textBox2.Text);
            int sonuc = 0;
            if (kdv == 1)
            {
                sonuc = fatura + (fatura * kdv) / 100;
                MessageBox.Show(Convert.ToString(sonuc));
            }
            else if (kdv == 8)
            {
                sonuc = fatura + (fatura * kdv) / 100;
                MessageBox.Show(Convert.ToString(sonuc));
            }
            else if (kdv == 10)
            {
                sonuc = fatura + (fatura * kdv) / 100;
                MessageBox.Show(Convert.ToString(sonuc));
            }
            else if (kdv == 18)
            {
                sonuc = fatura + (fatura * kdv) / 100;
                MessageBox.Show(Convert.ToString(sonuc));
            }

            else if (kdv == 20)
            {
                sonuc = fatura + (fatura * kdv) / 100;
                MessageBox.Show(Convert.ToString(sonuc));
            }

            else
            {
                MessageBox.Show("Yanlış değer girdiniz");
                textBox2.Clear();
            }
        }

    }
}