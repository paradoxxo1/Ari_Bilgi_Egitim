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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kul = textBox1.Text;
            string sifre = textBox2.Text;

            if (kul == "Admin" && sifre == "1234")
            {
                MessageBox.Show("Giriş Yapabilirsiniz");
                Form5 yeni = new Form5();
                yeni.Show();
                this.Hide(); yeni .Show();  
            }
            else
            {
                MessageBox.Show("Giriş Yapamazsınız");
            }
        }
    }
}
