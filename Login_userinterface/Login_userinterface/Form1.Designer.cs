namespace Login_userinterface
{
    partial class frm_loginekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_loginekrani));
            this.lbl_oturum_ac = new DevExpress.XtraEditors.LabelControl();
            this.lbl_kullanici_adi = new DevExpress.XtraEditors.LabelControl();
            this.txt_kullanici_adi = new DevExpress.XtraEditors.TextEdit();
            this.lbl_parola = new DevExpress.XtraEditors.LabelControl();
            this.txt_parola = new DevExpress.XtraEditors.TextEdit();
            this.chckedt_beni_hatirla = new DevExpress.XtraEditors.CheckEdit();
            this.btn_giris_yap = new DevExpress.XtraEditors.SimpleButton();
            this.pcbx_exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanici_adi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_parola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckedt_beni_hatirla.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_oturum_ac
            // 
            this.lbl_oturum_ac.Appearance.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_oturum_ac.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_oturum_ac.Appearance.Options.UseFont = true;
            this.lbl_oturum_ac.Appearance.Options.UseForeColor = true;
            this.lbl_oturum_ac.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_oturum_ac.Location = new System.Drawing.Point(53, 91);
            this.lbl_oturum_ac.Name = "lbl_oturum_ac";
            this.lbl_oturum_ac.Size = new System.Drawing.Size(242, 55);
            this.lbl_oturum_ac.TabIndex = 0;
            this.lbl_oturum_ac.Text = "Oturum Aç";
            // 
            // lbl_kullanici_adi
            // 
            this.lbl_kullanici_adi.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kullanici_adi.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lbl_kullanici_adi.Appearance.Options.UseFont = true;
            this.lbl_kullanici_adi.Appearance.Options.UseForeColor = true;
            this.lbl_kullanici_adi.Location = new System.Drawing.Point(53, 186);
            this.lbl_kullanici_adi.Name = "lbl_kullanici_adi";
            this.lbl_kullanici_adi.Size = new System.Drawing.Size(115, 22);
            this.lbl_kullanici_adi.TabIndex = 1;
            this.lbl_kullanici_adi.Text = "Kullanıcı Adı";
            // 
            // txt_kullanici_adi
            // 
            this.txt_kullanici_adi.EditValue = "";
            this.txt_kullanici_adi.Location = new System.Drawing.Point(53, 215);
            this.txt_kullanici_adi.Name = "txt_kullanici_adi";
            this.txt_kullanici_adi.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_kullanici_adi.Properties.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kullanici_adi.Properties.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txt_kullanici_adi.Properties.Appearance.Options.UseBackColor = true;
            this.txt_kullanici_adi.Properties.Appearance.Options.UseFont = true;
            this.txt_kullanici_adi.Properties.Appearance.Options.UseForeColor = true;
            this.txt_kullanici_adi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txt_kullanici_adi.Size = new System.Drawing.Size(242, 20);
            this.txt_kullanici_adi.TabIndex = 1;
            this.txt_kullanici_adi.EditValueChanged += new System.EventHandler(this.txt_kullanici_adi_EditValueChanged);
            // 
            // lbl_parola
            // 
            this.lbl_parola.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parola.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lbl_parola.Appearance.Options.UseFont = true;
            this.lbl_parola.Appearance.Options.UseForeColor = true;
            this.lbl_parola.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_parola.Location = new System.Drawing.Point(53, 260);
            this.lbl_parola.Name = "lbl_parola";
            this.lbl_parola.Size = new System.Drawing.Size(114, 22);
            this.lbl_parola.TabIndex = 3;
            this.lbl_parola.Text = "Parola";
            // 
            // txt_parola
            // 
            this.txt_parola.EditValue = "";
            this.txt_parola.Location = new System.Drawing.Point(53, 288);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_parola.Properties.Appearance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parola.Properties.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txt_parola.Properties.Appearance.Options.UseBackColor = true;
            this.txt_parola.Properties.Appearance.Options.UseFont = true;
            this.txt_parola.Properties.Appearance.Options.UseForeColor = true;
            this.txt_parola.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txt_parola.Properties.PasswordChar = '*';
            this.txt_parola.Size = new System.Drawing.Size(242, 20);
            this.txt_parola.TabIndex = 2;
            this.txt_parola.EditValueChanged += new System.EventHandler(this.txt_parola_EditValueChanged);
            // 
            // chckedt_beni_hatirla
            // 
            this.chckedt_beni_hatirla.Location = new System.Drawing.Point(53, 338);
            this.chckedt_beni_hatirla.Name = "chckedt_beni_hatirla";
            this.chckedt_beni_hatirla.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckedt_beni_hatirla.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.chckedt_beni_hatirla.Properties.Appearance.Options.UseFont = true;
            this.chckedt_beni_hatirla.Properties.Appearance.Options.UseForeColor = true;
            this.chckedt_beni_hatirla.Properties.Caption = "  Beni Hatırla";
            this.chckedt_beni_hatirla.Size = new System.Drawing.Size(127, 22);
            this.chckedt_beni_hatirla.TabIndex = 3;
            // 
            // btn_giris_yap
            // 
            this.btn_giris_yap.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_giris_yap.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris_yap.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_giris_yap.Appearance.Options.UseBackColor = true;
            this.btn_giris_yap.Appearance.Options.UseFont = true;
            this.btn_giris_yap.Appearance.Options.UseForeColor = true;
            this.btn_giris_yap.AppearancePressed.Options.UseBackColor = true;
            this.btn_giris_yap.AppearancePressed.Options.UseForeColor = true;
            this.btn_giris_yap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_giris_yap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris_yap.Location = new System.Drawing.Point(53, 398);
            this.btn_giris_yap.Name = "btn_giris_yap";
            this.btn_giris_yap.Size = new System.Drawing.Size(242, 48);
            this.btn_giris_yap.TabIndex = 4;
            this.btn_giris_yap.Text = "Giriş Yap";
            this.btn_giris_yap.Click += new System.EventHandler(this.btn_giris_yap_Click);
            // 
            // pcbx_exit
            // 
            this.pcbx_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbx_exit.Image = ((System.Drawing.Image)(resources.GetObject("pcbx_exit.Image")));
            this.pcbx_exit.Location = new System.Drawing.Point(260, 26);
            this.pcbx_exit.Name = "pcbx_exit";
            this.pcbx_exit.Size = new System.Drawing.Size(59, 48);
            this.pcbx_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbx_exit.TabIndex = 7;
            this.pcbx_exit.TabStop = false;
            this.pcbx_exit.Click += new System.EventHandler(this.pcbx_exit_Click);
            // 
            // frm_loginekrani
            // 
            this.AcceptButton = this.btn_giris_yap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 504);
            this.Controls.Add(this.pcbx_exit);
            this.Controls.Add(this.btn_giris_yap);
            this.Controls.Add(this.chckedt_beni_hatirla);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.lbl_parola);
            this.Controls.Add(this.txt_kullanici_adi);
            this.Controls.Add(this.lbl_kullanici_adi);
            this.Controls.Add(this.lbl_oturum_ac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_loginekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullanici_adi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_parola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckedt_beni_hatirla.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbx_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_oturum_ac;
        private DevExpress.XtraEditors.LabelControl lbl_kullanici_adi;
        private DevExpress.XtraEditors.TextEdit txt_kullanici_adi;
        private DevExpress.XtraEditors.LabelControl lbl_parola;
        private DevExpress.XtraEditors.TextEdit txt_parola;
        private DevExpress.XtraEditors.CheckEdit chckedt_beni_hatirla;
        private DevExpress.XtraEditors.SimpleButton btn_giris_yap;
        private System.Windows.Forms.PictureBox pcbx_exit;
    }
}

