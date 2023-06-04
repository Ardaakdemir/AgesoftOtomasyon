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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
            dtsiparislerr.DataSource = db.tbl_siparisler.ToList();
            this.dtsiparislerr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int kayitSayisi = dtsiparislerr.Rows.Count;
            lbladet.Text = (kayitSayisi + " adet sipariş listeleniyor..");
        }
        AgesofttEntities1 db = new AgesofttEntities1();
        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            var sonuc = (from x in db.tbl_urun select new { value = x.ID, Names = x.UrunAdi }).ToList();
            cmburun.DataSource = sonuc;
            cmburun.DisplayMember = "Names";
            cmburun.ValueMember = "value";
            cmburun.SelectedIndex = 1;
        }

        private void btnsip_Click(object sender, EventArgs e)
        {
            Paket pkt = new Paket();
            pkt.Show();
            this.Hide();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            dtsiparislerr.DataSource = db.tbl_siparisler.Where(x => x.Urun == cmburun.Text).ToList();
            int kayitSayisi = dtsiparislerr.Rows.Count;
            lbladet.Text = (kayitSayisi + " adet " + cmburun.Text + " "+ "satilmistir..");
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            dtsiparislerr.DataSource = db.tbl_siparisler.ToList();
            int kayitSayisi = dtsiparislerr.Rows.Count;
            lbladet.Text = (kayitSayisi + " adet urun listeleniyor..");
        }
    }
}
