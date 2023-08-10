using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp060801
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string ad = textBox1.Text;
            string ders = comboBox1.Text;
            int y1= Convert.ToInt32(textBox2.Text);
            int y2 = Convert.ToInt32(textBox3.Text);    
            int y3 = Convert.ToInt32(textBox4.Text);
            int sonuc = 0;
            hesapla(y1, y2, y3,sonuc);
            
        }

        private void hesapla(int y1, int y2, int y3, int sonuc)
        {
            sonuc = (y1 + y2 + y3) / 3;
            string durum;
            if (sonuc > 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            dataGridView1.Rows.Add(textBox1.Text, comboBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, sonuc, durum);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox2.Text) < 0 || Convert.ToInt32(textBox2.Text) > 100)
                {
                    MessageBox.Show("Değer 0-100 arasında olmalı");
                    textBox2.Text = "";
                    textBox2.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox2.Text = "";
                textBox2.Focus();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox3.Text) < 0 || Convert.ToInt32(textBox3.Text) > 100)
                {
                    MessageBox.Show("Değer 0-100 arasında olmalı");
                    textBox3.Text = "";
                    textBox3.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox3.Text = "";
                textBox3.Focus();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox4.Text) < 0 || Convert.ToInt32(textBox4.Text) > 100)
                {
                    MessageBox.Show("Değer 0-100 arasında olmalı");
                    textBox4.Text = "";
                    textBox4.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Sayısal bir değer girin");
                textBox4.Text = "";
                textBox4.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream dosya = new FileStream("d.txt", FileMode.OpenOrCreate);
            int i = 0;
            while (i < dosya.Length)
            {
                MessageBox.Show(i.ToString());
            }
                dosya.Close();
        }
    }
    }

