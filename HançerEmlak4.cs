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
    public partial class HançerEmlak4 : Form
    {
        public HançerEmlak4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\ASUS;Initial Catalog=emlak;Integrated Security=True");
        DataTable table = new DataTable();
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txtb1.Text == "" || txtb2.Text == "" || txtb3.Text == "" || txtb4.Text == "" || txtb5.Text == "" || txtb6.Text == "" || txtb7.Text == "")
            {
                MessageBox.Show("Bilgilerden hiç biri boş geçilemez. Lütfen formu gözden geçirin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand is_b = new SqlCommand("insert into is_bilgi (is_yeri_adi,adres,telefon,telefon_iki,is_yeri_mail,hesap_adi,sifre) values (@is_yeri_adi,@adres,@telefon,@telefon_iki,@is_yeri_mail,@hesap_adi,@sifre)", baglanti);


                is_b.Parameters.AddWithValue("@is_yeri_adi", txtb1.Text);
                is_b.Parameters.AddWithValue("@adres", txtb2.Text);
                is_b.Parameters.AddWithValue("@telefon", txtb3.Text);
                is_b.Parameters.AddWithValue("@telefon_iki", txtb4.Text);
                is_b.Parameters.AddWithValue("@is_yeri_mail", txtb5.Text);
                is_b.Parameters.AddWithValue("@hesap_adi", txtb6.Text);
                is_b.Parameters.AddWithValue("@sifre", txtb7.Text);



                is_b.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter("select *from is_bilgi", baglanti);
                adapter.Fill(table);

                baglanti.Close();
                MessageBox.Show("Başarılı bir şekilde hesap açtınız. Oturum açabilirsiniz.","Başarılı Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);
                HançerEmlak2 git = new HançerEmlak2();
                git.Show();
                this.Hide();
            }
        }

    }
}