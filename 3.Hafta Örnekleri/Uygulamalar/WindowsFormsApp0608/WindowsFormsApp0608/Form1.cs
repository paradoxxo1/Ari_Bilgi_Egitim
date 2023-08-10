using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0608
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] odalar = new string[] { "Basit Oda", "Suit Oda", "Delux Oda", "Kral Oda" };
            foreach (string oda in odalar)
            {
                comboBox1.Items.Add(oda);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat = 0;
            string ad = textBox1.Text;
            string oda = comboBox1.Text;
            int kisi = Convert.ToInt32(numericUpDown1.Value);
            int cocuk = Convert.ToInt32(numericUpDown2.Value);

            hesapla(ad, kisi, cocuk, fiyat, oda);
            temizle(fiyat);

        }
        private void temizle(int fiyat)
        {
            sonuclbl.Visible = true;
            sonuclbl.Text = fiyat.ToString();
            textBox1.Clear();
            numericUpDown1.Value = 0; numericUpDown2.Value = 0;
        }
        private void hesapla(string ad, int kisi, int cocuk, int fiyat, string oda)
        {
            switch (oda)
            {
                case "Basit Oda":
                    fiyat = (kisi * 100) + (cocuk * 100) / 2; break;
                case "Suit Oda":
                    fiyat = (kisi * 150) + (cocuk * 150) / 2; break;
                case "Delux Oda":
                    fiyat = (kisi * 200) + (cocuk * 200) / 2; break;
                case "Kral Oda":
                    fiyat = (kisi * 300) + (cocuk * 300) / 2; break;
                default:
                    MessageBox.Show("Oda Seçimi Yapmadınız "); break;
            }
               listBox1.Items.Add("Kişi Adı: " + ad + " Kişi Sayısı: " + kisi + " Çocuk Sayısı: " + cocuk + " Oda Tipi: " + oda + " Toplam Fiyat: " + fiyat);
            }
        }

    }
