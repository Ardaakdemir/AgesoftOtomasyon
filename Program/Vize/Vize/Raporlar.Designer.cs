
namespace Vize
{
    partial class Raporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raporlar));
            this.btnanasayfa = new System.Windows.Forms.Button();
            this.dtsiparislerr = new System.Windows.Forms.DataGridView();
            this.lbladet = new System.Windows.Forms.Label();
            this.lblsiparisleru = new System.Windows.Forms.Label();
            this.btnsip = new System.Windows.Forms.Button();
            this.cmburun = new System.Windows.Forms.ComboBox();
            this.btnara = new System.Windows.Forms.Button();
            this.btngoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtsiparislerr)).BeginInit();
            this.SuspendLayout();
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnanasayfa.AutoSize = true;
            this.btnanasayfa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnanasayfa.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnanasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanasayfa.ForeColor = System.Drawing.Color.Yellow;
            this.btnanasayfa.Location = new System.Drawing.Point(12, 593);
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.Size = new System.Drawing.Size(158, 34);
            this.btnanasayfa.TabIndex = 1;
            this.btnanasayfa.Text = "MENUYE DON";
            this.btnanasayfa.UseVisualStyleBackColor = false;
            this.btnanasayfa.Click += new System.EventHandler(this.btnanasayfa_Click);
            // 
            // dtsiparislerr
            // 
            this.dtsiparislerr.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtsiparislerr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtsiparislerr.Location = new System.Drawing.Point(12, 41);
            this.dtsiparislerr.Name = "dtsiparislerr";
            this.dtsiparislerr.Size = new System.Drawing.Size(859, 546);
            this.dtsiparislerr.TabIndex = 2;
            // 
            // lbladet
            // 
            this.lbladet.AutoSize = true;
            this.lbladet.BackColor = System.Drawing.Color.Black;
            this.lbladet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladet.ForeColor = System.Drawing.Color.Yellow;
            this.lbladet.Location = new System.Drawing.Point(9, 21);
            this.lbladet.Name = "lbladet";
            this.lbladet.Size = new System.Drawing.Size(50, 17);
            this.lbladet.TabIndex = 3;
            this.lbladet.Text = "lbladet";
            // 
            // lblsiparisleru
            // 
            this.lblsiparisleru.AutoSize = true;
            this.lblsiparisleru.BackColor = System.Drawing.Color.Black;
            this.lblsiparisleru.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsiparisleru.ForeColor = System.Drawing.Color.Yellow;
            this.lblsiparisleru.Location = new System.Drawing.Point(337, 9);
            this.lblsiparisleru.Name = "lblsiparisleru";
            this.lblsiparisleru.Size = new System.Drawing.Size(161, 29);
            this.lblsiparisleru.TabIndex = 4;
            this.lblsiparisleru.Text = "SİPARİŞLER";
            // 
            // btnsip
            // 
            this.btnsip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsip.AutoSize = true;
            this.btnsip.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnsip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsip.ForeColor = System.Drawing.Color.Yellow;
            this.btnsip.Location = new System.Drawing.Point(709, 593);
            this.btnsip.Name = "btnsip";
            this.btnsip.Size = new System.Drawing.Size(150, 34);
            this.btnsip.TabIndex = 1;
            this.btnsip.Text = "YENİ SİPARİŞ";
            this.btnsip.UseVisualStyleBackColor = false;
            this.btnsip.Click += new System.EventHandler(this.btnsip_Click);
            // 
            // cmburun
            // 
            this.cmburun.FormattingEnabled = true;
            this.cmburun.Location = new System.Drawing.Point(640, 14);
            this.cmburun.Name = "cmburun";
            this.cmburun.Size = new System.Drawing.Size(119, 21);
            this.cmburun.TabIndex = 5;
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.DarkRed;
            this.btnara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnara.ForeColor = System.Drawing.Color.White;
            this.btnara.Location = new System.Drawing.Point(765, 12);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(106, 23);
            this.btnara.TabIndex = 6;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btngoster
            // 
            this.btngoster.BackColor = System.Drawing.Color.DarkRed;
            this.btngoster.ForeColor = System.Drawing.Color.White;
            this.btngoster.Location = new System.Drawing.Point(373, 593);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(106, 23);
            this.btngoster.TabIndex = 7;
            this.btngoster.Text = "HEPSİNİ GÖSTER";
            this.btngoster.UseVisualStyleBackColor = false;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // Raporlar
            // 
            this.AcceptButton = this.btnanasayfa;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = global::Vize.Properties.Resources.cubuk1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 624);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.cmburun);
            this.Controls.Add(this.lblsiparisleru);
            this.Controls.Add(this.lbladet);
            this.Controls.Add(this.dtsiparislerr);
            this.Controls.Add(this.btnsip);
            this.Controls.Add(this.btnanasayfa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Raporlar";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.Raporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsiparislerr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnanasayfa;
        private System.Windows.Forms.DataGridView dtsiparislerr;
        private System.Windows.Forms.Label lbladet;
        private System.Windows.Forms.Label lblsiparisleru;
        private System.Windows.Forms.Button btnsip;
        private System.Windows.Forms.ComboBox cmburun;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btngoster;
    }
}