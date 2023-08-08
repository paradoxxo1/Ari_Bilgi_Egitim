using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForms
{
    public partial class ListeBykDgrBulma : Form
    {
        Random rnd = new Random();
        int sonSiralananDeger; // Son sıralanmış değeri saklamak için değişken

        public ListeBykDgrBulma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sirala();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void sirala()
        {
            int sayi;
            listBox1.Items.Clear();
            for (int i = 0; i < 251; i++)
            {
                sayi = rnd.Next(0, 300);
                listBox1.Items.Add(sayi);
            }

            ArrayList list = new ArrayList();
            foreach (object o in listBox1.Items)
            {
                list.Add(o);
            }
            list.Sort();
            listBox1.Items.Clear();
            foreach (object o in list)
            {
                listBox1.Items.Add(o);
            }

            if (listBox1.Items.Count > 0)
            {
                sonSiralananDeger = (int)listBox1.Items[listBox1.Items.Count - 1];
                textBox1.Text = sonSiralananDeger.ToString();
            }
        }
    }
}
