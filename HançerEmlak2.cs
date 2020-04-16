using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HANÇER_EMLAK_PROGRAMI
{
    public partial class HançerEmlak2 : Form
    {
        public HançerEmlak2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=ASUS\\ASUS;Initial Catalog=emlak;Integrated Security=True");
        private void lbl3_kayit_Click(object sender, EventArgs e)
        {

            HançerEmlak3 git = new HançerEmlak3();
            git.Show();
            this.Hide();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txtb1.Text == "" || txtb2.Text == "")
            {
                MessageBox.Show("Hesap adınız ya da şifreniz eksik. Lütfen tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string hesap_adi = txtb1.Text;
                string sifre = txtb2.Text;
                baglan.Open();

                SqlCommand komut = new SqlCommand("Select * from is_bilgi where hesap_adi=@hesap_adi and sifre=@sifre ", baglan);
                komut.Parameters.AddWithValue("@hesap_adi", txtb1.Text);
                komut.Parameters.AddWithValue("@sifre", txtb2.Text);

                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    HançerEmlak5 git = new HançerEmlak5();
                    git.Show();
                }

                else
                {
                    MessageBox.Show("Hesap adı veya şifreyi yanlış girdiniz. Lütfen tekrar giriniz.");
                    txtb1.Clear();
                    txtb2.Clear();
                }
                baglan.Close();
            }
        }
    }
}