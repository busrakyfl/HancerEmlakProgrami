namespace HANÇER_EMLAK_PROGRAMI
{
    partial class HançerEmlak2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HançerEmlak2));
            this.btn_giris = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3_kayit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.Maroon;
            this.btn_giris.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.Location = new System.Drawing.Point(43, 161);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(150, 50);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(19, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(86, 21);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "HESAP AD :";
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(106, 32);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(117, 20);
            this.txtb1.TabIndex = 4;
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(106, 70);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(117, 20);
            this.txtb2.TabIndex = 6;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(19, 69);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(55, 21);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "ŞİFRE :";
            // 
            // lbl3_kayit
            // 
            this.lbl3_kayit.AutoSize = true;
            this.lbl3_kayit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3_kayit.ForeColor = System.Drawing.Color.Red;
            this.lbl3_kayit.Location = new System.Drawing.Point(102, 106);
            this.lbl3_kayit.Name = "lbl3_kayit";
            this.lbl3_kayit.Size = new System.Drawing.Size(73, 21);
            this.lbl3_kayit.TabIndex = 7;
            this.lbl3_kayit.Text = "KAYDOL...";
            this.lbl3_kayit.Click += new System.EventHandler(this.lbl3_kayit_Click);
            // 
            // HançerEmlak2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HANÇER_EMLAK_PROGRAMI.Properties.Resources.guvenlik;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.lbl3_kayit);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_giris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HançerEmlak2";
            this.Text = "HANÇER EMLAK PROGRAMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3_kayit;
    }
}