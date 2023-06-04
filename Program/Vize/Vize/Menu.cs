using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize
{
    public partial class Menu : Form
    {
        AgesofttEntities1 cb = new AgesofttEntities1();
        public Menu(int id)
        {        
           InitializeComponent();
            var sonuc = cb.tbl_calisanlar.Where(x => x.ID == id).FirstOrDefault();
            tstpAd.Text = sonuc.Ad;
            tstpSoyad.Text = sonuc.Soyad;
            tstpSongiris.Text = sonuc.SonGiris;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblTarih.Text = DateTime.Today.ToString("d");
            lblTarih2.Text = DateTime.Today.ToString("dddd");
        }
       
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Kapatmak istiyor musunuz?", "Uyari!", MessageBoxButtons.YesNo);
            if (d == DialogResult.No)
                e.Cancel = true;
            
            return;
        }

        private void btnCalisanlar_Click(object sender, EventArgs e)
        {
            Calisanlar cls = new Calisanlar();
            cls.Show();
            
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            Raporlar rp = new Raporlar();
            rp.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pcSoru2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Yapanlar = \nArda AKDEMİR 1903022037 \nEnes CENGİZ 1903022038 \nGökdeniz BOZ 1903022033", "otomasyon Bilgisi");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnFiyat_Click(object sender, EventArgs e)
        {
            Fiyat fyt = new Fiyat();
            fyt.Show();
        }

        private void btnMasalar_Click(object sender, EventArgs e)
        {
            Masalar msl = new Masalar();
            msl.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void karanlıkModDarkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.BackgroundImage = Properties.Resources.logo_transparent;
            lblPaket.ForeColor = Color.Maroon;
            lblFiyat.ForeColor = Color.Maroon;
            lblCalisanlar.ForeColor = Color.Maroon;
            lblMasalar.ForeColor = Color.Maroon;
            lblRaporlar.ForeColor = Color.Maroon;
            lblTarih.ForeColor = Color.Maroon;
            lblSaat.ForeColor = Color.Maroon;
            lblTarih2.ForeColor = Color.Maroon;
        }

        private void klasikModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aydınlıkModLightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(249, 244, 255);
            this.BackgroundImage = Properties.Resources.logo_transparent2;
            lblPaket.ForeColor = Color.FromArgb(64, 64, 64);
            lblFiyat.ForeColor = Color.FromArgb(64, 64, 64);
            lblCalisanlar.ForeColor = Color.FromArgb(64, 64, 64);
            lblMasalar.ForeColor = Color.FromArgb(64, 64, 64);
            lblRaporlar.ForeColor = Color.FromArgb(64, 64, 64);
            lblTarih.ForeColor = Color.FromArgb(128, 128, 255);
            lblSaat.ForeColor = Color.FromArgb(128, 128, 255);
            lblTarih2.ForeColor = Color.FromArgb(128, 128, 255);
        }

        private void btnPaket_Click(object sender, EventArgs e)
        {
            Paket pkt = new Paket();
            pkt.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void geriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giris gir = new Giris();
            gir.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void cntmMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lblMasalar_Click(object sender, EventArgs e)
        {

        }

        private void lblPaket_Click(object sender, EventArgs e)
        {

        }
    }
}
