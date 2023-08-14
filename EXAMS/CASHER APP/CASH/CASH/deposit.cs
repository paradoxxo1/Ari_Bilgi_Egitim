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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CASH
{
    public partial class deposit : Form
    {
        public deposit()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=PC-ISA\\SQLEXPRESS;Initial Catalog=Casher;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBox1.Text, out int paraMiktari) && int.TryParse(textBox2.Text, out int musteriID))
                {
                    SqlConnection conn = new SqlConnection(conString);
                    conn.Open();

                    string selectQuery = $"SELECT Bakiye FROM Musteri WHERE Musteri_ID = {musteriID}";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, conn);

                    int mevcutBakiye = Convert.ToInt32(selectCmd.ExecuteScalar());
                    int yeniBakiye = mevcutBakiye + paraMiktari;

                    string updateQuery = $"UPDATE Musteri SET Bakiye = {yeniBakiye} WHERE Musteri_ID = {musteriID}";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    int affectedRows = updateCmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        label1.Text = "Yeni Bakiye: " + yeniBakiye.ToString();
                        MessageBox.Show("Bakiye güncellendi.");

                        // TextBox değerlerini temizle
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Bakiye güncellenemedi.");
                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Geçerli değerler girin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

    }
    }

