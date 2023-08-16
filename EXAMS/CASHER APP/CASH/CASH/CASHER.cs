using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CASH
{

    
    public partial class CASHER : Form
    {
        public CASHER()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.StartPosition = FormStartPosition.CenterScreen; // Formu merkezde açmak için
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            withdraw paracekme = new withdraw();
            OpenChildForm(paracekme);
        }

        private void CASHER_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deposit parayatir = new deposit();
            OpenChildForm(parayatir);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            history gecmis = new history();
            OpenChildForm(gecmis);
        }

      
    }
}

