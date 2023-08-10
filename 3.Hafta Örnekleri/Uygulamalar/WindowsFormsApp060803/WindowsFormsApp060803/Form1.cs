using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp060803
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
            label8.Text=salise.ToString();
        }
        int saat = 0;
        int dakika = 0;
        int saniye = 0;
        int salise = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            progressBar1.Value = salise;
            if (salise ==100)
            {
                saniye++;
                salise = 0;
            }
            if (saniye ==60)
            {
                dakika++;
                saniye = 0;
            }
            if (dakika == 60)
            {
                saat++;
                dakika  = 0;
            }

            label8.Text = salise.ToString();
            label7.Text = saniye.ToString();
            label6.Text = dakika.ToString();
            label5.Text = saat.ToString();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            listBox1.Items.Add("Saat: " + saat + " Dakika: " + dakika + " Saniye: " + saniye+ " Salise: "+salise);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saniye = 0;
            salise = 0;
            dakika = 0;
            saat = 0;
            label8.Text = salise.ToString();
            label7.Text = saniye.ToString();
            label6.Text = dakika.ToString();
            label5.Text = saat.ToString();
            listBox1.Items.Clear(); 
        }
    }
}
