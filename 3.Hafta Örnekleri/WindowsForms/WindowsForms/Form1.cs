﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Butona Tıklandı");
            string ad = textBox1.Text;
            if (ad == "admin")
            {
                MessageBox.Show("Giriş Yapabildiniz");
            }
            else
            {

                MessageBox.Show("Giriş Yapamadınız");
            }
        }
    }
}
