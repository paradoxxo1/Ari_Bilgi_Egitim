using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CASH
{
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=PC-ISA\\SQLEXPRESS;Initial Catalog=Casher;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                string query = "SELECT * FROM Musteri"; // Tablo adını yazın
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
