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
    public partial class Paket : Form
    {
        public Paket()
        {

            InitializeComponent();
            dturun.DataSource = db.tbl_urun.ToList();
            this.dturun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dturun.FirstDisplayedScrollingRowIndex = dturun.RowCount - 1;
            this.dtsiparis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }
        AgesofttEntities1 db = new AgesofttEntities1();
        DataTable tablo = new DataTable();
        private void Paket_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("ID", typeof(int));
            tablo.Columns.Add("Urun", typeof(string));
            tablo.Columns.Add("Adet", typeof(int));
            tablo.Columns.Add("Fiyat", typeof(int));
            tablo.Columns.Add("Tutar", typeof(int));
            dtsiparis.DataSource = tablo;
        }

        private void btnsicak_Click(object sender, EventArgs e)
        {
            dturun.DataSource = db.tbl_urun.Where(x => x.Turu == btnsicak.Text).ToList();
        }

        private void btnsoguk_Click(object sender, EventArgs e)
        {
            dturun.DataSource = db.tbl_urun.Where(x => x.Turu == btnsoguk.Text).ToList();
        }

        private void btnmesrubat_Click(object sender, EventArgs e)
        {
            dturun.DataSource = db.tbl_urun.Where(x => x.Turu == btnmesrubat.Text).ToList();
        }

        private void btntuz_Click(object sender, EventArgs e)
        {
            dturun.DataSource = db.tbl_urun.Where(x => x.Turu == btntuz.Text).ToList();
        }

        private void btntat_Click(object sender, EventArgs e)
        {
            dturun.DataSource = db.tbl_urun.Where(x => x.Turu == btntat.Text).ToList();
        }

        private void btndiger_Click(object sender, EventArgs e)
        {
            dturun.DataSource = db.tbl_urun.Where(x => x.Turu == btndiger.Text).ToList();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtadet.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtadet.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtadet.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtadet.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtadet.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtadet.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtadet.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtadet.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtadet.Text += "9";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtadet.Text = "";
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblmusteribilgi.Text == "empty" && lblbilgino.Text == "empty")
                {
                    MessageBox.Show("Müşteri bilgisi girmediniz.Lütfen Bilgi Giriniz.");
                }
                else
                {
                    if (txtadet.Text == "")
                    {
                        txtadet.Text = "1";
                    }
                    int a, b, c;
                    a = Convert.ToInt32(txtadet.Text);
                    b = Convert.ToInt32(txtfiyat.Text);
                    c = a * b;

                    lbltutarrr.Text = c.ToString();
                    tablo.Rows.Add(txtid.Text, txturun.Text, txtadet.Text, txtfiyat.Text, lbltutarrr.Text);
                    dtsiparis.DataSource = tablo;                   
                    int toplam = 0;
                    for (int i = 0; i < dtsiparis.Rows.Count; ++i)
                    {
                        toplam += Convert.ToInt32(dtsiparis.Rows[i].Cells[4].Value);
                    }
                    lbltut.Text = toplam.ToString() + "₺";
                    lbltut.Visible = true;
                    tbl_siparisler tbl = new tbl_siparisler();
                    tbl.MusteriAdı = lblmusteribilgi.Text;
                    tbl.Urun = txturun.Text;
                    tbl.Adet = txtadet.Text;
                    tbl.Fiyat = txtfiyat.Text;
                    tbl.Durum = "Hazirlaniyor.";
                    tbl.UrunID = txtid.Text;
                    tbl.Tutar = c.ToString();
                    tbl.Telefon = lblbilgino.Text;
                    db.tbl_siparisler.Add(tbl);
                    db.SaveChanges();
                    db.SaveChanges();

                    txtadet.Text = "";
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.ToString());
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtadet.Text += "0";
        }

        private void btnodeme_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_siparisler tbl = new tbl_siparisler();
                tbl.MusteriAdı = lblmusteribilgi.Text;
                tbl.Urun = "SİPARİŞ SONU";
                tbl.Adet = txtadet.Text;
                tbl.Fiyat = "----------";
                tbl.Durum = "----------";
                tbl.UrunID = "----------";
                tbl.Tutar = lbltut.Text;
                tbl.Telefon = lblbilgino.Text;
                db.tbl_siparisler.Add(tbl);
                db.SaveChanges();
                gbmusteribilgi.Visible = false;
                lblmusteribilgi.Text = "empty"; lblbilgino.Text = "empty";
                txtadet.Text = "";
                tablo.Clear();
                lbltut.Visible = false;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void btnpakets_Click(object sender, EventArgs e)
        {
            tbl_siparisler tbl = new tbl_siparisler();
            tbl.MusteriAdı = lblmusteribilgi.Text;
            tbl.Urun = "SİPARİŞ SONU";
            tbl.Adet = txtadet.Text;
            tbl.Fiyat = "----------";
            tbl.Durum = "Paket Servis";
            tbl.UrunID = "----------";
            tbl.Tutar = lbltut.Text;
            tbl.Telefon = lblbilgino.Text;
            db.tbl_siparisler.Add(tbl);
            db.SaveChanges();
            gbmusteribilgi.Visible = false;
            lblmusteribilgi.Text = "empty"; lblbilgino.Text = "empty";
            txtadet.Text = "";
            tablo.Clear();
            lbltut.Visible = false;
        }

        private void btnipt_Click(object sender, EventArgs e)
        {
            gbmusteribilgi.Visible = false;
            lblmusteribilgi.Text = "empty";
            lblbilgino.Text = "empty";
            txtadet.Text = "";
            tablo.Clear();
            lbltut.Visible = false;
        }

        private void dturun_DoubleClick(object sender, EventArgs e)
        {

            if (txtadet.Text == "")
            {
                txtadet.Text = "1";
            }
        }

        private void dturun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedrow = dturun.Rows[e.RowIndex];
                txtid.Text = selectedrow.Cells[0].Value.ToString();
                txturun.Text = selectedrow.Cells[1].Value.ToString();
                txtfiyat.Text = selectedrow.Cells[2].Value.ToString();
                txttur.Text = selectedrow.Cells[3].Value.ToString();
            }

        }

        private void btnmusterikayit_Click(object sender, EventArgs e)
        {
            lblmusteribilgi.Text = txtmusteriad.Text + " " + txtmusterisoyad.Text;
            lblbilgino.Text = txtmusterino.Text;
            gbmusteribilgi.Visible = true;
            txtmusteriad.Text = ""; txtmusterisoyad.Text = ""; txtmusterino.Text = "";
        }

        private void btnyenisip_Click(object sender, EventArgs e)
        {
            gbmusteribilgi.Visible = false;
            lblmusteribilgi.Text = "empty"; lblbilgino.Text = "empty";
            txtadet.Text = "";
            tablo.Clear();
            lbltut.Visible = false;
        }

        private void btngoruntu_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            onizleme.Document = Faturaprintdoc;
            ((Form)onizleme).WindowState = FormWindowState.Normal; // Tam ekran olması için
            onizleme.PrintPreviewControl.Zoom = 1.0; //Sayfanın %100 boyutunda olması için
            onizleme.ShowDialog(); /*Faturaprintprev.ShowDialog();*/
        }

        private void btnyazdir_Click(object sender, EventArgs e)
        {
            DialogResult dlr = Faturaprint.ShowDialog();
            if (dlr == DialogResult.OK)
            {
                Faturaprintdoc.Print();
            }



        }


        private void Faturaprintdoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //int height = dtsiparis.Height;
            //dtsiparis.Height = dtsiparis.RowCount * dtsiparis.RowTemplate.Height * 2;
            //Bitmap bmp = new Bitmap(dtsiparis.Width, dtsiparis.Height);
            //dtsiparis.DrawToBitmap(bmp, new Rectangle(0, 0, dtsiparis.Width, dtsiparis.Height));
            //dtsiparis.Height = height;
            ////Faturaprintprev.ShowDialog(); 
            //e.Graphics.DrawImage(bmp, 0, 0);




            //Bitmap objBmp = new Bitmap(this.dtsiparis.Width, this.dtsiparis.Height);
            //dtsiparis.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dtsiparis.Width, this.dtsiparis.Height));
            Font myFont = new Font("arial", 50);
            Font myFont2 = new Font("arial", 20);
            Font myFont3 = new Font("arial", 30);
            Font myFont4 = new Font("UniSpace", 40);
            SolidBrush sbrush = new SolidBrush(Color.Blue);
            SolidBrush bbrush = new SolidBrush(Color.Black);
            SolidBrush abrush = new SolidBrush(Color.ForestGreen);
            SolidBrush cbrush = new SolidBrush(Color.SpringGreen);
            SolidBrush rbrush = new SolidBrush(Color.Red);
            Pen mypen = new Pen(Color.Red);

            e.Graphics.DrawLine(mypen, 100, 150, 700, 150);
            e.Graphics.DrawString("Fatura Özeti ", myFont, sbrush, 200, 50);
            //int y = 180;
            ////foreach (var x in dtsiparis.Columns)
            ////{
            ////    e.Graphics.DrawString(x.ToString(), myFont3, abrush, 120, y);
            ////    y += 50;
            ////}
            e.Graphics.DrawLine(mypen, 100, 900, 700, 900);
            string toplam = lbltut.Text;
            e.Graphics.DrawString("Toplam = " + toplam, myFont3, bbrush, 120, 950);
            e.Graphics.DrawString("Ares Kafe", myFont4, cbrush, 480, 1100);
            e.Graphics.DrawLine(mypen, 100, 1050, 430, 1050);
            e.Graphics.DrawLine(mypen, 100, 150, 100, 1050);
            e.Graphics.DrawLine(mypen, 430, 900, 430, 1050);
            e.Graphics.DrawLine(mypen, 700, 150, 700, 900);

            Bitmap objBmp = new Bitmap(dtsiparis.Width, dtsiparis.Height);
            dtsiparis.DrawToBitmap(objBmp, new Rectangle(50, 50, dtsiparis.Width, dtsiparis.Height));
            e.Graphics.DrawImage(objBmp, 48, 98);


        }
    }
}