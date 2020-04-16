namespace HANÇER_EMLAK_PROGRAMI
{
    partial class HançerEmlak1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HançerEmlak1));
            this.btn_ev = new System.Windows.Forms.Button();
            this.btn_emlak = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ev
            // 
            this.btn_ev.BackColor = System.Drawing.Color.Maroon;
            this.btn_ev.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ev.ForeColor = System.Drawing.Color.White;
            this.btn_ev.Location = new System.Drawing.Point(31, 199);
            this.btn_ev.Name = "btn_ev";
            this.btn_ev.Size = new System.Drawing.Size(150, 50);
            this.btn_ev.TabIndex = 0;
            this.btn_ev.Text = "EV KİRALIK/SATILIK";
            this.btn_ev.UseVisualStyleBackColor = false;
            this.btn_ev.Click += new System.EventHandler(this.btn_ev_Click);
            // 
            // btn_emlak
            // 
            this.btn_emlak.BackColor = System.Drawing.Color.Maroon;
            this.btn_emlak.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_emlak.ForeColor = System.Drawing.Color.White;
            this.btn_emlak.Location = new System.Drawing.Point(208, 199);
            this.btn_emlak.Name = "btn_emlak";
            this.btn_emlak.Size = new System.Drawing.Size(150, 50);
            this.btn_emlak.TabIndex = 1;
            this.btn_emlak.Text = "EMLAKCI";
            this.btn_emlak.UseVisualStyleBackColor = false;
            this.btn_emlak.Click += new System.EventHandler(this.btn_emlak_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Maroon;
            this.btn_cikis.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.Color.White;
            this.btn_cikis.Location = new System.Drawing.Point(386, 199);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(150, 50);
            this.btn_cikis.TabIndex = 2;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // HançerEmlak1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HANÇER_EMLAK_PROGRAMI.Properties.Resources.ODUyMjA5OD_osman_aval_gayrimenkul_satislarinda_degeri_belirleyecek_kuruma_ihtiyac_var;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_emlak);
            this.Controls.Add(this.btn_ev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HançerEmlak1";
            this.Text = "HANÇER EMLAK PROGRAMI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ev;
        private System.Windows.Forms.Button btn_emlak;
        private System.Windows.Forms.Button btn_cikis;
    }
}

