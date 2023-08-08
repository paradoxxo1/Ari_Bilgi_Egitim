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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double trkcdogru = Convert.ToDouble(trkd.Text);
            double trkcyanls = Convert.ToDouble(trky.Text);
            trknet.Text = Convert.ToString(trkcdogru - (trkcyanls)/4);
            double matdogru = Convert.ToDouble(matd.Text);
            double matyanls = Convert.ToDouble(maty.Text);
            matnet.Text = Convert.ToString(matdogru - (matyanls) / 4);
            double fzkdogru = Convert.ToDouble(fzkd.Text);
            double fzkyanls = Convert.ToDouble(fzky.Text);
            fzknet.Text = Convert.ToString(fzkdogru - (fzkyanls)/4);


        }
    }
}
