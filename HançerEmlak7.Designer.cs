namespace HANÇER_EMLAK_PROGRAMI
{
    partial class HançerEmlak7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HançerEmlak7));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oda_sayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isinma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yalitim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zemin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pencere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metrekare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gayrimenkul_tipif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mutfak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banyo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayit_hesap_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_yol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Maroon;
            this.groupBox1.Controls.Add(this.cb1);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(23, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EV ARA";
            // 
            // cb1
            // 
            this.cb1.BackColor = System.Drawing.Color.Maroon;
            this.cb1.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Kiralık",
            "Satılık"});
            this.cb1.Location = new System.Drawing.Point(138, 19);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(99, 27);
            this.cb1.TabIndex = 121;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Maroon;
            this.lbl1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(12, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(111, 21);
            this.lbl1.TabIndex = 120;
            this.lbl1.Text = "Satılık / Kiralık :";
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.Maroon;
            this.btn_ara.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.Color.White;
            this.btn_ara.Location = new System.Drawing.Point(281, 272);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(150, 50);
            this.btn_ara.TabIndex = 122;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // dtg1
            // 
            this.dtg1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.semt,
            this.oda_sayisi,
            this.fiyat,
            this.isinma,
            this.yalitim,
            this.zemin,
            this.pencere,
            this.metrekare,
            this.gayrimenkul_tipif,
            this.mutfak,
            this.banyo,
            this.kayit_hesap_adi,
            this.r_ad,
            this.r_yol});
            this.dtg1.GridColor = System.Drawing.Color.Maroon;
            this.dtg1.Location = new System.Drawing.Point(23, 337);
            this.dtg1.Name = "dtg1";
            this.dtg1.Size = new System.Drawing.Size(640, 196);
            this.dtg1.TabIndex = 123;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "No";
            this.id.Name = "id";
            // 
            // semt
            // 
            this.semt.DataPropertyName = "semt";
            this.semt.HeaderText = "Semt";
            this.semt.Name = "semt";
            // 
            // oda_sayisi
            // 
            this.oda_sayisi.DataPropertyName = "oda_sayisi";
            this.oda_sayisi.HeaderText = "Oda Sayısı";
            this.oda_sayisi.Name = "oda_sayisi";
            // 
            // fiyat
            // 
            this.fiyat.DataPropertyName = "fiyat";
            this.fiyat.HeaderText = "Fiyat";
            this.fiyat.Name = "fiyat";
            // 
            // isinma
            // 
            this.isinma.DataPropertyName = "isinma";
            this.isinma.HeaderText = "Isınma";
            this.isinma.Name = "isinma";
            // 
            // yalitim
            // 
            this.yalitim.DataPropertyName = "yalitim";
            this.yalitim.HeaderText = "Yalıtım";
            this.yalitim.Name = "yalitim";
            // 
            // zemin
            // 
            this.zemin.DataPropertyName = "zemin";
            this.zemin.HeaderText = "Zemin";
            this.zemin.Name = "zemin";
            // 
            // pencere
            // 
            this.pencere.DataPropertyName = "pencere";
            this.pencere.HeaderText = "Pencere";
            this.pencere.Name = "pencere";
            // 
            // metrekare
            // 
            this.metrekare.DataPropertyName = "metrekare";
            this.metrekare.HeaderText = "Metrekare";
            this.metrekare.Name = "metrekare";
            // 
            // gayrimenkul_tipif
            // 
            this.gayrimenkul_tipif.DataPropertyName = "gayrimenkul_tipif";
            this.gayrimenkul_tipif.HeaderText = "Gayrimenkul Tipi";
            this.gayrimenkul_tipif.Name = "gayrimenkul_tipif";
            // 
            // mutfak
            // 
            this.mutfak.DataPropertyName = "mutfak";
            this.mutfak.HeaderText = "Mutfak";
            this.mutfak.Name = "mutfak";
            // 
            // banyo
            // 
            this.banyo.DataPropertyName = "banyo";
            this.banyo.HeaderText = "Banyo";
            this.banyo.Name = "banyo";
            // 
            // kayit_hesap_adi
            // 
            this.kayit_hesap_adi.DataPropertyName = "kayit_hesap_adi";
            this.kayit_hesap_adi.HeaderText = "Hesap";
            this.kayit_hesap_adi.Name = "kayit_hesap_adi";
            // 
            // r_ad
            // 
            this.r_ad.DataPropertyName = "r_ad";
            this.r_ad.HeaderText = "Resim Adı";
            this.r_ad.Name = "r_ad";
            // 
            // r_yol
            // 
            this.r_yol.DataPropertyName = "r_yol";
            this.r_yol.HeaderText = "Resim Adresi";
            this.r_yol.Name = "r_yol";
            // 
            // HançerEmlak7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HANÇER_EMLAK_PROGRAMI.Properties.Resources.ODUyMjA5OD_osman_aval_gayrimenkul_satislarinda_degeri_belirleyecek_kuruma_ihtiyac_var;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 548);
            this.Controls.Add(this.dtg1);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HançerEmlak7";
            this.Text = "EV ARA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.DataGridView dtg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn semt;
        private System.Windows.Forms.DataGridViewTextBoxColumn oda_sayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn isinma;
        private System.Windows.Forms.DataGridViewTextBoxColumn yalitim;
        private System.Windows.Forms.DataGridViewTextBoxColumn zemin;
        private System.Windows.Forms.DataGridViewTextBoxColumn pencere;
        private System.Windows.Forms.DataGridViewTextBoxColumn metrekare;
        private System.Windows.Forms.DataGridViewTextBoxColumn gayrimenkul_tipif;
        private System.Windows.Forms.DataGridViewTextBoxColumn mutfak;
        private System.Windows.Forms.DataGridViewTextBoxColumn banyo;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayit_hesap_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_yol;
    }
}