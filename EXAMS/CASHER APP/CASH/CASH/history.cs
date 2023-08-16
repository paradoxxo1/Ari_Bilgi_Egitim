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
                string musteriID = textBox1.Text; // TextBox'tan Musteri_ID değerini alın

                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                string query = "SELECT * FROM IslemGecmisi WHERE Musteri_ID = @MusteriID"; // Sorguyu güncelle
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MusteriID", musteriID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string musteriID = textBox1.Text.Trim(); // TextBox'tan Musteri_ID değerini alın

                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                string query = "SELECT * FROM IslemGecmisi WHERE Musteri_ID = @MusteriID AND IslemTipi = 'Para Yatırma'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MusteriID", musteriID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string musteriID = textBox1.Text.Trim(); // TextBox'tan Musteri_ID değerini alın

                SqlConnection conn = new SqlConnection(conString);
                conn.Open();

                string query = "SELECT * FROM IslemGecmisi WHERE Musteri_ID = @MusteriID AND IslemTipi = 'Para Çekme'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MusteriID", musteriID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

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
