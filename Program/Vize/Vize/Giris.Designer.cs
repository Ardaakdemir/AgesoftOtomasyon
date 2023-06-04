namespace Vize
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.lblGiris = new System.Windows.Forms.Label();
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblHatali = new System.Windows.Forms.Label();
            this.lblHata = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtguvenlik = new System.Windows.Forms.TextBox();
            this.lblguvenlik = new System.Windows.Forms.Label();
            this.lblsorgu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTarihh = new System.Windows.Forms.Label();
            this.lblSaatt = new System.Windows.Forms.Label();
            this.pb23 = new System.Windows.Forms.PictureBox();
            this.pcSoru = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSoru)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiris.ForeColor = System.Drawing.Color.White;
            this.lblGiris.Location = new System.Drawing.Point(14, 38);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(161, 23);
            this.lblGiris.TabIndex = 1;
            this.lblGiris.Text = "Kullanıcı Adı :";
            // 
            // txtGiris
            // 
            this.txtGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGiris.Location = new System.Drawing.Point(198, 38);
            this.txtGiris.Multiline = true;
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(132, 31);
            this.txtGiris.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(198, 95);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(132, 31);
            this.txtSifre.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(198, 208);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(132, 43);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHatali
            // 
            this.lblHatali.AutoSize = true;
            this.lblHatali.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHatali.ForeColor = System.Drawing.Color.Black;
            this.lblHatali.Location = new System.Drawing.Point(392, 319);
            this.lblHatali.Name = "lblHatali";
            this.lblHatali.Size = new System.Drawing.Size(208, 18);
            this.lblHatali.TabIndex = 6;
            this.lblHatali.Text = "Kez hatalı giriş yaptınız...";
            this.lblHatali.Visible = false;
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHata.ForeColor = System.Drawing.Color.Blue;
            this.lblHata.Location = new System.Drawing.Point(373, 318);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(22, 22);
            this.lblHata.TabIndex = 7;
            this.lblHata.Text = "1";
            this.lblHata.Visible = false;
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCikis.Location = new System.Drawing.Point(553, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(87, 34);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şifre :";
            // 
            // txtguvenlik
            // 
            this.txtguvenlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtguvenlik.Location = new System.Drawing.Point(198, 155);
            this.txtguvenlik.Multiline = true;
            this.txtguvenlik.Name = "txtguvenlik";
            this.txtguvenlik.Size = new System.Drawing.Size(132, 31);
            this.txtguvenlik.TabIndex = 2;
            // 
            // lblguvenlik
            // 
            this.lblguvenlik.AutoSize = true;
            this.lblguvenlik.BackColor = System.Drawing.Color.Black;
            this.lblguvenlik.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold);
            this.lblguvenlik.ForeColor = System.Drawing.Color.Transparent;
            this.lblguvenlik.Location = new System.Drawing.Point(13, 155);
            this.lblguvenlik.Name = "lblguvenlik";
            this.lblguvenlik.Size = new System.Drawing.Size(148, 27);
            this.lblguvenlik.TabIndex = 6;
            this.lblguvenlik.Text = "lblguvenlik";
            this.lblguvenlik.Click += new System.EventHandler(this.lblguvenlik_Click);
            // 
            // lblsorgu
            // 
            this.lblsorgu.AutoSize = true;
            this.lblsorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsorgu.ForeColor = System.Drawing.Color.Transparent;
            this.lblsorgu.Location = new System.Drawing.Point(354, 99);
            this.lblsorgu.Name = "lblsorgu";
            this.lblsorgu.Size = new System.Drawing.Size(20, 24);
            this.lblsorgu.TabIndex = 11;
            this.lblsorgu.Text = "1";
            this.lblsorgu.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTarihh
            // 
            this.lblTarihh.AutoSize = true;
            this.lblTarihh.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarihh.ForeColor = System.Drawing.Color.White;
            this.lblTarihh.Location = new System.Drawing.Point(13, 293);
            this.lblTarihh.Name = "lblTarihh";
            this.lblTarihh.Size = new System.Drawing.Size(68, 27);
            this.lblTarihh.TabIndex = 12;
            this.lblTarihh.Text = "tarih";
            this.lblTarihh.Click += new System.EventHandler(this.lblTarihh_Click);
            // 
            // lblSaatt
            // 
            this.lblSaatt.AutoSize = true;
            this.lblSaatt.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaatt.ForeColor = System.Drawing.Color.White;
            this.lblSaatt.Location = new System.Drawing.Point(13, 224);
            this.lblSaatt.Name = "lblSaatt";
            this.lblSaatt.Size = new System.Drawing.Size(62, 27);
            this.lblSaatt.TabIndex = 13;
            this.lblSaatt.Text = "saat";
            this.lblSaatt.Click += new System.EventHandler(this.lblSaatt_Click);
            // 
            // pb23
            // 
            this.pb23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb23.Image = global::Vize.Properties.Resources.logo_transparent;
            this.pb23.Location = new System.Drawing.Point(321, 12);
            this.pb23.Name = "pb23";
            this.pb23.Size = new System.Drawing.Size(337, 328);
            this.pb23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb23.TabIndex = 14;
            this.pb23.TabStop = false;
            // 
            // pcSoru
            // 
            this.pcSoru.Image = global::Vize.Properties.Resources.soru1;
            this.pcSoru.Location = new System.Drawing.Point(336, 155);
            this.pcSoru.Name = "pcSoru";
            this.pcSoru.Size = new System.Drawing.Size(38, 32);
            this.pcSoru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcSoru.TabIndex = 8;
            this.pcSoru.TabStop = false;
            this.pcSoru.Click += new System.EventHandler(this.pcSoru_Click);
            // 
            // Giris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(180)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(652, 348);
            this.ControlBox = false;
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.pcSoru);
            this.Controls.Add(this.lblSaatt);
            this.Controls.Add(this.lblTarihh);
            this.Controls.Add(this.lblsorgu);
            this.Controls.Add(this.lblguvenlik);
            this.Controls.Add(this.txtguvenlik);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblHatali);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiris);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.pb23);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSoru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblHatali;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.PictureBox pcSoru;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtguvenlik;
        private System.Windows.Forms.Label lblguvenlik;
        private System.Windows.Forms.Label lblsorgu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTarihh;
        private System.Windows.Forms.Label lblSaatt;
        private System.Windows.Forms.PictureBox pb23;
    }
}

