using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANÇER_EMLAK_PROGRAMI
{
    public partial class HançerEmlak1 : Form
    {
        public HançerEmlak1()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_emlak_Click(object sender, EventArgs e)
        {
            HançerEmlak2 git = new HançerEmlak2();
            git.Show();
            this.Hide();
        }

        private void btn_ev_Click(object sender, EventArgs e)
        {
            HançerEmlak7 git = new HançerEmlak7();
            git.Show();
            this.Hide();
        }
    }
}
