using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASH
{
    public partial class withdraw : Form
    {
        public withdraw()
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

                    if (mevcutBakiye < paraMiktari)
                    {
                        label1.Text = "Yetersiz Bakiye: " + mevcutBakiye.ToString();
                        MessageBox.Show("Yetersiz bakiye. Çekilebilecek miktar: " + mevcutBakiye.ToString());
                    }
                    else
                    {
                        int yeniBakiye = mevcutBakiye - paraMiktari;

                        string updateQuery = $"UPDATE Musteri SET Bakiye = {yeniBakiye} WHERE Musteri_ID = {musteriID}";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        int affectedRows = updateCmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            label1.Text = "Yeni Bakiye: " + yeniBakiye.ToString();
                            MessageBox.Show("Bakiye güncellendi.");

                            // IslemGecmisi tablosuna veri ekleme
                            string insertQuery = $"INSERT INTO IslemGecmisi (Musteri_ID, IslemTarihi, IslemTipi, IslemMiktari) VALUES (@MusteriID, @IslemTarihi, @IslemTipi, @IslemMiktari)";
                            SqlCommand insertCmd = new SqlCommand(insertQuery, conn);

                            insertCmd.Parameters.AddWithValue("@MusteriID", musteriID);
                            insertCmd.Parameters.AddWithValue("@IslemTarihi", DateTime.Now);
                            insertCmd.Parameters.AddWithValue("@IslemTipi", "Para Çekme");
                            insertCmd.Parameters.AddWithValue("@IslemMiktari", paraMiktari);

                            insertCmd.ExecuteNonQuery();

                            // TextBox değerlerini temizle
                            textBox1.Text = "";
                            textBox2.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Bakiye güncellenemedi.");
                        }
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


        private void withdraw_Load(object sender, EventArgs e)
            {
                UpdateDateTimeLabel();
            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                UpdateDateTimeLabel();

            }
            private void UpdateDateTimeLabel()
            {
                lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
    }




   

