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
using System.IO;

namespace HANÇER_EMLAK_PROGRAMI
{
    public partial class HançerEmlak5 : Form
    {
        public HançerEmlak5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\ASUS;Initial Catalog=emlak;Integrated Security=True");
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txtb1.Text == "" || txtb2.Text == "" || txtb3.Text == "" || cb1.Text == "" || txtb5.Text == "" || cb2.Text == "" || cb3.Text == "" || txtb8.Text == "" || cb4.Text == "" || cb5.Text == "" || cb6.Text == "" || txtb13.Text == "" || txtb14.Text == "" )
            {
                MessageBox.Show("Bilgilerden hiç biri boş geçilemez. Lütfen formu gözden geçirin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand kisi = new SqlCommand("insert into ev_ozellik(semt,oda_sayisi,fiyat,isinma,yalitim,zemin,pencere,metrekare,gayrimenkul_tipi,mutfak,banyo,kayit_hesap_adi,r_ad,r_yol) values (@semt,@oda_sayisi,@fiyat,@isinma,@yalitim,@zemin,@pencere,@metrekare,@gayrimenkul_tipi,@mutfak,@banyo,@kayit_hesap_adi,@r_ad,@r_yol)", baglanti);

                kisi.Parameters.AddWithValue("@semt", txtb1.Text);
                kisi.Parameters.AddWithValue("@oda_sayisi", txtb2.Text);
                kisi.Parameters.AddWithValue("@fiyat", txtb3.Text);
                kisi.Parameters.AddWithValue("@isinma", cb1.Text);
                kisi.Parameters.AddWithValue("@yalitim", txtb5.Text);
                kisi.Parameters.AddWithValue("@zemin", cb2.Text);
                kisi.Parameters.AddWithValue("@pencere", cb3.Text);
                kisi.Parameters.AddWithValue("@metrekare", txtb3.Text);
                kisi.Parameters.AddWithValue("@gayrimenkul_tipi", cb4.Text);
                kisi.Parameters.AddWithValue("@mutfak", cb5.Text);
                kisi.Parameters.AddWithValue("@banyo", cb6.Text);
                kisi.Parameters.AddWithValue("@kayit_hesap_adi", txtb12.Text);
                kisi.Parameters.AddWithValue("@r_ad", txtb13.Text);
                kisi.Parameters.AddWithValue("@r_yol", txtb14.Text);
              /*  kisi.Parameters.AddWithValue("@kiralik_satilik", cb7.Text);*/
                
                kisi.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ev bilgileri kayıt altına alınmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HançerEmlak1 git = new HançerEmlak1();
                git.Show();
                this.Hide();
                kopyala();
            }
        }
        void kopyala()
        {

            File.Copy(openFileDialog1.FileName, Application.StartupPath + @"\Resimler\" + txtb13.Text);
        }
        private void btn_resim_al_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "JPEG File (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg|All Files(*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pb1.Image = Image.FromFile(openFileDialog1.FileName);
                    txtb14.Text = openFileDialog1.FileName.ToString();
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }
        }

        private void btn_guncelleme_git_Click(object sender, EventArgs e)
        {
            HançerEmlak6 git = new HançerEmlak6();
            git.Show();
            this.Hide();
        }
      
       
       

       
        
       
     

     
      
    
       

       
    }
}
