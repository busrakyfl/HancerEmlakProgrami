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
    public partial class HançerEmlak3 : Form
    {
        public HançerEmlak3()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\ASUS;Initial Catalog=emlak;Integrated Security=True");
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txtb1.Text == "" || txtb2.Text == "" || txtb3.Text == "" || txtb4.Text == "" || txtb5.Text == "" || txtb6.Text == "")
            {
                MessageBox.Show("Bilgilerden hiç biri boş geçilemez. Lütfen formu gözden geçirin.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand kisi = new SqlCommand("insert into kisi(adi,soyadi,mail,telefon,il,ilce) values (@adi,@soyadi,@mail,@telefon,@il,@ilce)", baglanti);

                kisi.Parameters.AddWithValue("@adi", txtb1.Text);
                kisi.Parameters.AddWithValue("@soyadi", txtb2.Text);
                kisi.Parameters.AddWithValue("@mail", txtb3.Text);
                kisi.Parameters.AddWithValue("@telefon", txtb4.Text);
                kisi.Parameters.AddWithValue("@il", txtb5.Text);
                kisi.Parameters.AddWithValue("@ilce", txtb6.Text);

                kisi.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bilgileriniz kayıt altına alınmıştır. Lütfen şirketiniz hakkındaki bilgileri de giriniz.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

                HançerEmlak4 git = new HançerEmlak4();
                git.Show();
                this.Hide();
            }
        }
    }
}