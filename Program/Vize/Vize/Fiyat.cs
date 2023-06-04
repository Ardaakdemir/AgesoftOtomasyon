using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Vize
{
    public partial class Fiyat : Form
    {
        XDocument mb = XDocument.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
        public Fiyat()
        {
            InitializeComponent();
            dturun.DataSource = db.tbl_urun.ToList();
            this.dturun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int kayitSayisi = dturun.Rows.Count;
            lblurunsayisi.Text = (kayitSayisi + " adet urun listeleniyor..");

        }
        AgesofttEntities1 db = new AgesofttEntities1();

        private void btnekle_Click(object sender, EventArgs e)
        {
            tbl_urun tbl = new tbl_urun();
            tbl.UrunAdi = txturun2.Text;
            tbl.Fiyati = txtfiyat2.Text;

            if (rbmesrubat.Checked)
            {
                tbl.Turu = rbmesrubat.Text;
            }
            else if (rbsicakk.Checked)
            {
                tbl.Turu = rbsicakk.Text;
            }
            else if (rbsoguk.Checked)
            {
                tbl.Turu = rbsoguk.Text;
            }
            else if (rbtatli.Checked)
            {
                tbl.Turu = rbtatli.Text;
            }
            else if (rbtuz.Checked)
            {
                tbl.Turu = rbtuz.Text;
            }
            else if (rbdigerrr.Checked)
            {
                tbl.Turu = rbdigerrr.Text;
            }
            db.tbl_urun.Add(tbl);
            db.SaveChanges();
            dturun.DataSource = db.tbl_urun.ToList();
            txturun2.Text = "";
            txtfiyat2.Text = "";
            int kayitSayisi = dturun.Rows.Count;
            lblurunsayisi.Text = (kayitSayisi + " adet urun listeleniyor..");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" && txturun.Text == "")
            {
                MessageBox.Show("Urun ID veya İsmi Girmediniz.Lütfen Bilgi Giriniz.");
            }
            else
            {
                int urun = Convert.ToInt32(txtID.Text);
                var sonuc = db.tbl_urun.Where(x => x.ID == urun).FirstOrDefault();
                sonuc.UrunAdi = txturun.Text;
                sonuc.Fiyati = txtfiyat.Text;

                if (rb2soguk.Checked)
                {
                    sonuc.Turu = rb2soguk.Text;
                }
                else if (rb2sicak.Checked)
                {
                    sonuc.Turu = rb2sicak.Text;
                }
                else if (rb2diger.Checked)
                {
                    sonuc.Turu = rb2diger.Text;
                }
                else if (rb2tatli.Checked)
                {
                    sonuc.Turu = rb2tatli.Text;
                }
                else if (rb2tuzlu.Checked)
                {
                    sonuc.Turu = rb2tuzlu.Text;
                }
                else if (rb2mesrubat.Checked)
                {
                    sonuc.Turu = rb2mesrubat.Text;
                }


                db.SaveChanges();
                dturun.DataSource = db.tbl_urun.ToList();
                txturun.Text = "";
                txtfiyat.Text = "";
                txtID.Text = "";
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(txtidsil.Text);
            var urunsil = db.tbl_urun.Where(x => x.ID == kod).FirstOrDefault();
            if (urunsil != null)
            {
                db.tbl_urun.Remove(urunsil);
                db.SaveChanges();
                dturun.DataSource = db.tbl_urun.ToList();
                txtidsil.Text = "";
                int kayitSayisi = dturun.Rows.Count;
                lblurunsayisi.Text = (kayitSayisi + " adet urun listeleniyor..");

            }
            else
            {
                MessageBox.Show("ID girmediniz!", "UYARI");
                dturun.DataSource = db.tbl_urun.ToList();

            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            if (rb3tuz.Checked)
            {
                dturun.DataSource = db.tbl_urun.Where(x => x.Turu == rb3tuz.Text).ToList();
                int kayitSayisi = dturun.Rows.Count;
                lblurunsayisi.Text = (kayitSayisi + " adet urun listeleniyor..");
            }
            else if (rb3tatli.Checked)
            {
                dturun.DataSource = db.tbl_urun.Where(x => x.Turu == rb3tatli.Text).ToList();
                int kayitSayisi = dturun.Rows.Count;
                lblurunsayisi.Text = (kayitSayisi + " adet urun listeleniyor..");
            }
            else if (rb3mesr.Checked)
            {
                dturun.DataSource = db.tbl_urun.Where(x => x.Turu == rb3mesr.Text).ToList();
                int kayitSayisi = dturun.Rows.Count;
                lblurunsayisi.Text = (kayitSayisi + " adet urun listeleniyor..");
            }
            else if (rb3sicak.Checked)
            {
                dturun.DataSource = db.tbl_urun.Where(x => x.Turu == rb3sicak.Text).ToList();
                int kayitSayisi = dturun.Rows.Count;
                lblurunsayisi.Text = (kayitSayisi + " adet urun listeleniyor..");
            }
            else if (rb3soguk.Checked)
            {
                dturun.DataSource = db.tbl_urun.Where(x => x.Turu == rb3soguk.Text).ToList();
                int kayitSayisi = dturun.Rows.Count;
                lblurunsayisi.Text = (kayitSayisi + " adet urun listeleniyor..");
            }
            else if (rb3diger.Checked)
            {
                dturun.DataSource = db.tbl_urun.Where(x => x.Turu == rb3diger.Text).ToList();
                int kayitSayisi = dturun.Rows.Count;
                lblurunsayisi.Text = (kayitSayisi + " adet urun listeleniyor..");
            }
        }


        private void Fiyat_Load(object sender, EventArgs e)
        {
            var sonuc = from x in mb.Descendants("Currency") select new { doviz = x.Element("Isim").Value };
            foreach (var item in sonuc)
            {
                cmbdoviz.Items.Add(item.doviz.ToString());
            }
        }

        private void cmbdoviz_SelectedIndexChanged(object sender, EventArgs e)
        {
            var KurBilgileri = from x in mb.Descendants("Currency")
                               where
                               x.Element("Isim").Value == cmbdoviz.SelectedItem.ToString()
                               select new
                               {

                                   dovad = x.Element("CurrencyName").Value,
                                   alis = x.Element("ForexBuying").Value,
                                   satis = x.Element("ForexSelling").Value
                               };
            foreach (var x in KurBilgileri)
            {

                lblDovizalis2.Visible = true;
                lblDovizsatis2.Visible = true;
                lblDovizad.Visible = true;
                lblDovizad.Text = x.dovad;
                lblDovizalis.Text = x.alis + "₺";
                lblDovizsatis.Text = x.satis + "₺";
            }

        }

        private void dturun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}