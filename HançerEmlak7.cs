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
    public partial class HançerEmlak7 : Form
    {
        public HançerEmlak7()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\ASUS;Initial Catalog=emlak;Integrated Security=True");
        private void btn_ara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from ev_ozellik where kiralik_satilik like '%" + cb1.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtg1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
