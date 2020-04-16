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
    public partial class HançerEmlak6 : Form
    {
        public HançerEmlak6()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\ASUS;Initial Catalog=emlak;Integrated Security=True");

       
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

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from ev_ozellik where r_ad=@r_ad", baglanti);
            komut.Parameters.AddWithValue("@r_ad", txtb13.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            txtb13.Clear();
            MessageBox.Show("Resim silinmiştir.");
        }
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtg1.DataSource = ds.Tables[0];
        }

    

        private void btn_goster_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * from ev_ozellik");
        }

        private void dtg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int alan = dtg1.SelectedCells[0].RowIndex;
            string id = dtg1.Rows[alan].Cells[1].Value.ToString();
            string semt = dtg1.Rows[alan].Cells[2].Value.ToString();
            string oda_sayisi = dtg1.Rows[alan].Cells[3].Value.ToString();
            string fiyat = dtg1.Rows[alan].Cells[4].Value.ToString();
            string isinma = dtg1.Rows[alan].Cells[5].Value.ToString();
            string yalitim = dtg1.Rows[alan].Cells[6].Value.ToString();
            string zemin = dtg1.Rows[alan].Cells[7].Value.ToString();
            string pencere = dtg1.Rows[alan].Cells[8].Value.ToString();
            string metrekare = dtg1.Rows[alan].Cells[9].Value.ToString();
            string gayrimenkul_tipi = dtg1.Rows[alan].Cells[10].Value.ToString();
            string mutfak = dtg1.Rows[alan].Cells[11].Value.ToString();
            string banyo = dtg1.Rows[alan].Cells[12].Value.ToString();
            string kayit_hesap_adi = dtg1.Rows[alan].Cells[13].Value.ToString();
            string r_ad = dtg1.Rows[alan].Cells[14].Value.ToString();
            string r_yol = dtg1.Rows[alan].Cells[15].Value.ToString();
            string kiralik_satilik = dtg1.Rows[alan].Cells[16].Value.ToString();
            
           
            txtb1.Text = semt;
            txtb2.Text = oda_sayisi;
            txtb3.Text = fiyat;
            cb1.Text = isinma;
            txtb5.Text = yalitim;
            cb2.Text = zemin;
            cb3.Text = pencere;
            txtb8.Text = metrekare;
            cb4.Text = gayrimenkul_tipi;
            cb5.Text = mutfak;
            cb6.Text = banyo;
            txtb12.Text = kayit_hesap_adi;
            txtb13.Text = r_ad;txtb13.Text = r_ad;
            txtb14.Text = r_yol;
            txtb15.Text = id;
            cb7.Text = kiralik_satilik;
            
        }

        private void btn_resim_al_Click_1(object sender, EventArgs e)
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

        private void btn_guncelleme_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update ev_ozellik set semt=@semt,oda_sayisi=@oda_sayisi,fiyat=@fiyat,isinma=@isinma,yalitim=@yalitim,zemin=@zemin,pencere=@pencere,metrekare=@metrekare,gayrimenkul_tipi=@gayrimenkul_tipi,mutfak=@mutfak,banyo=@banyo,r_ad=@r_ad,r_yol=@r_yol where kayit_hesap_adi=@kayit_hesap_adi", baglanti);

            komut.Parameters.AddWithValue("@semt", txtb1.Text);
            komut.Parameters.AddWithValue("@oda_sayisi", txtb2.Text);
            komut.Parameters.AddWithValue("@fiyat", txtb3.Text);
            komut.Parameters.AddWithValue("@isinma", cb1.Text);
            komut.Parameters.AddWithValue("@yalitim", txtb5.Text);
            komut.Parameters.AddWithValue("@zemin", cb2.Text);
            komut.Parameters.AddWithValue("@pencere", cb3.Text);
            komut.Parameters.AddWithValue("@metrekare", txtb8.Text);
            komut.Parameters.AddWithValue("@gayrimenkul_tipi", cb4.Text);
            komut.Parameters.AddWithValue("@mutfak", cb5.Text);
            komut.Parameters.AddWithValue("@banyo", cb6.Text);
            komut.Parameters.AddWithValue("@r_ad", txtb13.Text);
            komut.Parameters.AddWithValue("@r_yol", txtb14.Text);
            komut.Parameters.AddWithValue("@kayit_hesap_adi", cb7.Text);
            
            komut.ExecuteNonQuery();
            verilerigoster("select * from ev_ozellik");
            baglanti.Close();
        }

    


      

        

        

  
        
    }
}
