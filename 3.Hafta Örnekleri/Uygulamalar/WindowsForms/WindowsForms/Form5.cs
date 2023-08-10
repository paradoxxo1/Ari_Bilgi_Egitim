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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void fORM1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.MdiParent = this;
            yeni.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 nigar = new Form2();
            nigar.MdiParent = this;
            nigar.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3 mustafa = new Form3();
            mustafa .MdiParent = this;
            mustafa.Show();
        }
    }
}
