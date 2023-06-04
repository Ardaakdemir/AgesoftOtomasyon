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
    public partial class Masalar : Form
    {
        public Masalar()
        {
            
            InitializeComponent();
            dtrezervasyon.DataSource = db.tbl_masalar.ToList();
            this.dtrezervasyon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        AgesofttEntities1 db = new AgesofttEntities1();
        private void Masalar_Load(object sender, EventArgs e)
        {

            int kod = Convert.ToInt32(lbl1.Text);
            var numara = db.tbl_masalar.Where(x => x.MasaID == kod).FirstOrDefault();
            if (numara != null)
            {
                btnMasa1.ForeColor = Color.Red;
            }
            else
            {
                btnMasa1.ForeColor = Color.Lime;
            }
            int kod2 = Convert.ToInt32(lbl2.Text);
            var numara2 = db.tbl_masalar.Where(x => x.MasaID == kod2).FirstOrDefault();
            if (numara2 != null)
            {
                btnMasa2.ForeColor = Color.Red;
            }
            else
            {
                btnMasa2.ForeColor = Color.Lime;
            }
            int kod3 = Convert.ToInt32(lbl3.Text);
            var numara3 = db.tbl_masalar.Where(x => x.MasaID == kod3).FirstOrDefault();
            if (numara3 != null)
            {
                btnMasa3.ForeColor = Color.Red;
            }
            else
            {
                btnMasa3.ForeColor = Color.Lime;
            }
            int kod4 = Convert.ToInt32(lbl4.Text);
            var numara4 = db.tbl_masalar.Where(x => x.MasaID == kod4).FirstOrDefault();
            if (numara4 != null)
            {
                btnMasa4.ForeColor = Color.Red;
            }
            else
            {
                btnMasa4.ForeColor = Color.Lime;
            }
            int kod5 = Convert.ToInt32(lbl5.Text);
            var numara5 = db.tbl_masalar.Where(x => x.MasaID == kod5).FirstOrDefault();
            if (numara5 != null)
            {
                btnMasa5.ForeColor = Color.Red;
            }
            else
            {
                btnMasa5.ForeColor = Color.Lime;
            }
            int kod6 = Convert.ToInt32(lbl6.Text);
            var numara6 = db.tbl_masalar.Where(x => x.MasaID == kod6).FirstOrDefault();
            if (numara6 != null)
            {
                btnMasa6.ForeColor = Color.Red;
            }
            else
            {
                btnMasa6.ForeColor = Color.Lime;
            }
            int kod7 = Convert.ToInt32(lbl7.Text);
            var numara7 = db.tbl_masalar.Where(x => x.MasaID == kod7).FirstOrDefault();
            if (numara7 != null)
            {
                btnMasa7.ForeColor = Color.Red;
            }
            else
            {
                btnMasa7.ForeColor = Color.Lime;
            }
            int kod8 = Convert.ToInt32(lbl8.Text);
            var numara8 = db.tbl_masalar.Where(x => x.MasaID == kod8).FirstOrDefault();
            if (numara8 != null)
            {
                btnMasa8.ForeColor = Color.Red;
            }
            else
            {
                btnMasa8.ForeColor = Color.Lime;
            }
            int kod9 = Convert.ToInt32(lbl9.Text);
            var numara9 = db.tbl_masalar.Where(x => x.MasaID == kod9).FirstOrDefault();
            if (numara9 != null)
            {
                btnMasa9.ForeColor = Color.Red;
            }
            else
            {
                btnMasa9.ForeColor = Color.Lime;
            }
            int kod10 = Convert.ToInt32(lbl10.Text);
            var numara10 = db.tbl_masalar.Where(x => x.MasaID == kod10).FirstOrDefault();
            if (numara10 != null)
            {
                btnMasa10.ForeColor = Color.Red;
            }
            else
            {
                btnMasa10.ForeColor = Color.Lime;
            }
            int kod11 = Convert.ToInt32(lbl11.Text);
            var numara11 = db.tbl_masalar.Where(x => x.MasaID == kod11).FirstOrDefault();
            if (numara11 != null)
            {
                btnMasa11.ForeColor = Color.Red;
            }
            else
            {
                btnMasa12.ForeColor = Color.Lime;
            }
            int kod12 = Convert.ToInt32(lbl12.Text);
            var numara12 = db.tbl_masalar.Where(x => x.MasaID == kod12).FirstOrDefault();
            if (numara12 != null)
            {
                btnMasa12.ForeColor = Color.Red;
            }
            else
            {
                btnMasa12.ForeColor = Color.Lime;
            }
        }
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Bu formda sag tik ile Rezervasyon islemlerini yapabiliyoruz Rezervasyonu silmek için 'Rezervasyonu iptal et' i kullanabilirsiniz.Ayrıca isim ve tel no girdikten sonra masaya sağ tıklayıp rezerve de edebilirsiniz.", "Bilgi");
        }

        private void rezervasyonYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Masayi Rezerve etmek ister misin?", "Masa bos ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    txtid.Text = "1";
                }
                else
                {
                    txtid.Text = "";
                    txtid.Text = "1";
                }
                if (txtad.Text == "" && txttel.Text == "")
                {
                    MessageBox.Show("ILK ONCE MUSTERI ADI VE NUMARASI GIRINIZ!");
                }
                else
                {
                    tbl_masalar tbl = new tbl_masalar();
                    tbl.MasaID = Convert.ToInt32(txtid.Text);
                    tbl.MusteriAdi = txtad.Text;
                    tbl.TelNo = txttel.Text;
                    db.tbl_masalar.Add(tbl);
                    db.SaveChanges();
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa1.ForeColor = Color.Red;
                    MessageBox.Show("Basariyla Rezerve ettiniz.", "Tebrikler");
                    txtid.Text = "";
                    txtad.Text = "";
                    txttel.Text = "";
                }

            }

            return;
        }

        private void rezervasyonİptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Rezerveyi iptal etmek ister misin?", "Rezerveli ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                int kod = Convert.ToInt32(lbl1.Text);
                var numara = db.tbl_masalar.Where(x => x.MasaID == kod).FirstOrDefault();
                if (numara != null)
                {
                    db.tbl_masalar.Remove(numara);
                    db.SaveChanges();

                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa1.ForeColor = Color.Lime;
                    MessageBox.Show("Basariyla iptal ettiniz.", "Tebrikler");
                }
                else
                {
                    MessageBox.Show("İptal edilmedi!", "UYARI");
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();

                }

            }

            return;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Masayi Rezerve etmek ister misin?", "Masa bos ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    txtid.Text = "2";

                }
                else
                {
                    txtid.Text = "";
                    txtid.Text = "2";
                }
                if (txtad.Text == "" && txttel.Text == "")
                {
                    MessageBox.Show("ILK ONCE MUSTERI ADI VE NUMARASI GIRINIZ!");
                }
                else
                {
                    tbl_masalar tbl = new tbl_masalar();
                    tbl.MasaID = Convert.ToInt32(txtid.Text);
                    tbl.MusteriAdi = txtad.Text;
                    tbl.TelNo = txttel.Text;
                    db.tbl_masalar.Add(tbl);
                    db.SaveChanges();
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa2.ForeColor = Color.Red;
                    MessageBox.Show("Basariyla Rezerve ettiniz.", "Tebrikler");
                    txtid.Text = "";
                    txtad.Text = "";
                    txttel.Text = "";
                }

            }

            return;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Rezerveyi iptal etmek ister misin?", "Rezerveli ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                int kod = Convert.ToInt32(lbl2.Text);
                var numara = db.tbl_masalar.Where(x => x.MasaID == kod).FirstOrDefault();
                if (numara != null)
                {
                    db.tbl_masalar.Remove(numara);
                    db.SaveChanges();

                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa2.ForeColor = Color.Lime;
                    MessageBox.Show("Basariyla iptal ettiniz.", "Tebrikler");
                }
                else
                {
                    MessageBox.Show("İptal edilmedi!", "UYARI");
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();

                }
            }
        }
        private void cntmRez3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Masayi Rezerve etmek ister misin?", "Masa bos ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    txtid.Text = "3";
                }
                else
                {
                    txtid.Text = "";
                    txtid.Text = "3";
                }
                if (txtad.Text == "" && txttel.Text == "")
                {
                    MessageBox.Show("ILK ONCE MUSTERI ADI VE NUMARASI GIRINIZ!");
                }
                else
                {
                    tbl_masalar tbl = new tbl_masalar();
                    tbl.MasaID = Convert.ToInt32(txtid.Text);
                    tbl.MusteriAdi = txtad.Text;
                    tbl.TelNo = txttel.Text;
                    db.tbl_masalar.Add(tbl);
                    db.SaveChanges();
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa3.ForeColor = Color.Red;
                    MessageBox.Show("Basariyla Rezerve ettiniz.", "Tebrikler");
                    txtid.Text = "";
                    txtad.Text = "";
                    txttel.Text = "";
                }

            }

            return;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Rezerveyi iptal etmek ister misin?", "Rezerveli ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                int kod = Convert.ToInt32(lbl3.Text);
                var numara = db.tbl_masalar.Where(x => x.MasaID == kod).FirstOrDefault();
                if (numara != null)
                {
                    db.tbl_masalar.Remove(numara);
                    db.SaveChanges();

                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa3.ForeColor = Color.Lime;
                    MessageBox.Show("Basariyla iptal ettiniz.", "Tebrikler");
                }
                else
                {
                    MessageBox.Show("İptal edilmedi!", "UYARI");
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();

                }

            }

            return;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Masayi Rezerve etmek ister misin?", "Masa bos ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    txtid.Text = "4";
                }
                else
                {
                    txtid.Text = "";
                    txtid.Text = "4";
                }
                if (txtad.Text == "" && txttel.Text == "")
                {
                    MessageBox.Show("ILK ONCE MUSTERI ADI VE NUMARASI GIRINIZ!");
                    txtid.Text = "";
                }
                else
                {
                    tbl_masalar tbl = new tbl_masalar();
                    tbl.MasaID = Convert.ToInt32(txtid.Text);
                    tbl.MusteriAdi = txtad.Text;
                    tbl.TelNo = txttel.Text;
                    db.tbl_masalar.Add(tbl);
                    db.SaveChanges();
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa4.ForeColor = Color.Red;
                    MessageBox.Show("Basariyla Rezerve ettiniz.", "Tebrikler");
                    txtid.Text = "";
                    txtad.Text = "";
                    txttel.Text = "";
                }

            }

            return;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Rezerveyi iptal etmek ister misin?", "Rezerveli ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                int kod = Convert.ToInt32(lbl4.Text);
                var numara = db.tbl_masalar.Where(x => x.MasaID == kod).FirstOrDefault();
                if (numara != null)
                {
                    db.tbl_masalar.Remove(numara);
                    db.SaveChanges();

                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa4.ForeColor = Color.Lime;
                    MessageBox.Show("Basariyla iptal ettiniz.", "Tebrikler");
                }
                else
                {
                    MessageBox.Show("İptal edilmedi!", "UYARI");
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();

                }

            }

            return;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Masayi Rezerve etmek ister misin?", "Masa bos ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    txtid.Text = "5";
                }
                else
                {
                    txtid.Text = "";
                    txtid.Text = "5";
                }
                if (txtad.Text == "" && txttel.Text == "")
                {
                    MessageBox.Show("ILK ONCE MUSTERI ADI VE NUMARASI GIRINIZ!");
                }
                else
                {
                    tbl_masalar tbl = new tbl_masalar();
                    tbl.MasaID = Convert.ToInt32(txtid.Text);
                    tbl.MusteriAdi = txtad.Text;
                    tbl.TelNo = txttel.Text;
                    db.tbl_masalar.Add(tbl);
                    db.SaveChanges();
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa5.ForeColor = Color.Red;
                    MessageBox.Show("Basariyla Rezerve ettiniz.", "Tebrikler");
                    txtid.Text = "";
                    txtad.Text = "";
                    txttel.Text = "";
                }

            }

            return;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Rezerveyi iptal etmek ister misin?", "Rezerveli ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                int kod = Convert.ToInt32(lbl5.Text);
                var numara = db.tbl_masalar.Where(x => x.MasaID == kod).FirstOrDefault();
                if (numara != null)
                {
                    db.tbl_masalar.Remove(numara);
                    db.SaveChanges();

                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa5.ForeColor = Color.Lime;
                    MessageBox.Show("Basariyla iptal ettiniz.", "Tebrikler");
                }
                else
                {
                    MessageBox.Show("İptal edilmedi!", "UYARI");
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();

                }

            }

            return;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Masayi Rezerve etmek ister misin?", "Masa bos ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    txtid.Text = "6";
                }
                else
                {
                    txtid.Text = "";
                    txtid.Text = "6";
                }
                if (txtad.Text == "" && txttel.Text == "")
                {
                    MessageBox.Show("ILK ONCE MUSTERI ADI VE NUMARASI GIRINIZ!");
                }
                else
                {
                    tbl_masalar tbl = new tbl_masalar();
                    tbl.MasaID = Convert.ToInt32(txtid.Text);
                    tbl.MusteriAdi = txtad.Text;
                    tbl.TelNo = txttel.Text;
                    db.tbl_masalar.Add(tbl);
                    db.SaveChanges();
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa6.ForeColor = Color.Red;
                    MessageBox.Show("Basariyla Rezerve ettiniz.", "Tebrikler");
                    txtid.Text = "";
                    txtad.Text = "";
                    txttel.Text = "";
                }

            }

            return;
        }

        private void cntmRez6_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Rezerveyi iptal etmek ister misin?", "Rezerveli ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                int kod = Convert.ToInt32(lbl6.Text);
                var numara = db.tbl_masalar.Where(x => x.MasaID == kod).FirstOrDefault();
                if (numara != null)
                {
                    db.tbl_masalar.Remove(numara);
                    db.SaveChanges();

                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa6.ForeColor = Color.Lime;
                    MessageBox.Show("Basariyla iptal ettiniz.", "Tebrikler");
                }
                else
                {
                    MessageBox.Show("İptal edilmedi!", "UYARI");
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();

                }

            }

            return;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Masayi Rezerve etmek ister misin?", "Masa bos ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    txtid.Text = "7";
                }
                else
                {
                    txtid.Text = "";
                    txtid.Text = "7";
                }
                if (txtad.Text == "" && txttel.Text == "")
                {
                    MessageBox.Show("ILK ONCE MUSTERI ADI VE NUMARASI GIRINIZ!");
                }
                else
                {
                    tbl_masalar tbl = new tbl_masalar();
                    tbl.MasaID = Convert.ToInt32(txtid.Text);
                    tbl.MusteriAdi = txtad.Text;
                    tbl.TelNo = txttel.Text;
                    db.tbl_masalar.Add(tbl);
                    db.SaveChanges();
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa7.ForeColor = Color.Red;
                    MessageBox.Show("Basariyla Rezerve ettiniz.", "Tebrikler");
                    txtid.Text = "";
                    txtad.Text = "";
                    txttel.Text = "";
                }

            }

            return;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Rezerveyi iptal etmek ister misin?", "Rezerveli ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                int kod = Convert.ToInt32(lbl7.Text);
                var numara = db.tbl_masalar.Where(x => x.MasaID == kod).FirstOrDefault();
                if (numara != null)
                {
                    db.tbl_masalar.Remove(numara);
                    db.SaveChanges();

                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa7.ForeColor = Color.Lime;
                    MessageBox.Show("Basariyla iptal ettiniz.", "Tebrikler");
                }
                else
                {
                    MessageBox.Show("İptal edilmedi!", "UYARI");
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();

                }

            }

            return;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Masayi Rezerve etmek ister misin?", "Masa bos ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    txtid.Text = "8";
                }
                else
                {
                    txtid.Text = "";
                    txtid.Text = "8";
                }
                if (txtad.Text == "" && txttel.Text == "")
                {
                    MessageBox.Show("ILK ONCE MUSTERI ADI VE NUMARASI GIRINIZ!");
                }
                else
                {
                    tbl_masalar tbl = new tbl_masalar();
                    tbl.MasaID = Convert.ToInt32(txtid.Text);
                    tbl.MusteriAdi = txtad.Text;
                    tbl.TelNo = txttel.Text;
                    db.tbl_masalar.Add(tbl);
                    db.SaveChanges();
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa8.ForeColor = Color.Red;
                    MessageBox.Show("Basariyla Rezerve ettiniz.", "Tebrikler");
                    txtid.Text = "";
                    txtad.Text = "";
                    txttel.Text = "";
                }

            }

            return;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Rezerveyi iptal etmek ister misin?", "Rezerveli ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                int kod = Convert.ToInt32(lbl8.Text);
                var numara = db.tbl_masalar.Where(x => x.MasaID == kod).FirstOrDefault();
                if (numara != null)
                {
                    db.tbl_masalar.Remove(numara);
                    db.SaveChanges();

                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa8.ForeColor = Color.Lime;
                    MessageBox.Show("Basariyla iptal ettiniz.", "Tebrikler");
                }
                else
                {
                    MessageBox.Show("İptal edilmedi!", "UYARI");
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();

                }

            }

            return;
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Masayi Rezerve etmek ister misin?", "Masa bos ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    txtid.Text = "9";
                }
                else
                {
                    txtid.Text = "";
                    txtid.Text = "9";
                }
                if (txtad.Text == "" && txttel.Text == "")
                {
                    MessageBox.Show("ILK ONCE MUSTERI ADI VE NUMARASI GIRINIZ!");
                }
                else
                {
                    tbl_masalar tbl = new tbl_masalar();
                    tbl.MasaID = Convert.ToInt32(txtid.Text);
                    tbl.MusteriAdi = txtad.Text;
                    tbl.TelNo = txttel.Text;
                    db.tbl_masalar.Add(tbl);
                    db.SaveChanges();
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa9.ForeColor = Color.Red;
                    MessageBox.Show("Basariyla Rezerve ettiniz.", "Tebrikler");
                    txtid.Text = "";
                    txtad.Text = "";
                    txttel.Text = "";
                }

            }

            return;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Rezerveyi iptal etmek ister misin?", "Rezerveli ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                int kod = Convert.ToInt32(lbl9.Text);
                var numara = db.tbl_masalar.Where(x => x.MasaID == kod).FirstOrDefault();
                if (numara != null)
                {
                    db.tbl_masalar.Remove(numara);
                    db.SaveChanges();

                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa9.ForeColor = Color.Lime;
                    MessageBox.Show("Basariyla iptal ettiniz.", "Tebrikler");
                }
                else
                {
                    MessageBox.Show("İptal edilmedi!", "UYARI");
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();

                }

            }

            return;
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Masayi Rezerve etmek ister misin?", "Masa bos ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    txtid.Text = "10";
                }
                else
                {
                    txtid.Text = "";
                    txtid.Text = "10";
                }
                if (txtad.Text == "" && txttel.Text == "")
                {
                    MessageBox.Show("ILK ONCE MUSTERI ADI VE NUMARASI GIRINIZ!");
                }
                else
                {
                    tbl_masalar tbl = new tbl_masalar();
                    tbl.MasaID = Convert.ToInt32(txtid.Text);
                    tbl.MusteriAdi = txtad.Text;
                    tbl.TelNo = txttel.Text;
                    db.tbl_masalar.Add(tbl);
                    db.SaveChanges();
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa10.ForeColor = Color.Red;
                    MessageBox.Show("Basariyla Rezerve ettiniz.", "Tebrikler");
                    txtid.Text = "";
                    txtad.Text = "";
                    txttel.Text = "";
                }

            }

            return;
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Rezerveyi iptal etmek ister misin?", "Rezerveli ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                int kod = Convert.ToInt32(lbl10.Text);
                var numara = db.tbl_masalar.Where(x => x.MasaID == kod).FirstOrDefault();
                if (numara != null)
                {
                    db.tbl_masalar.Remove(numara);
                    db.SaveChanges();

                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa10.ForeColor = Color.Lime;
                    MessageBox.Show("Basariyla iptal ettiniz.", "Tebrikler");
                }
                else
                {
                    MessageBox.Show("İptal edilmedi!", "UYARI");
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();

                }

            }

            return;
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Masayi Rezerve etmek ister misin?", "Masa bos ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    txtid.Text = "11";
                }
                else
                {
                    txtid.Text = "";
                    txtid.Text = "11";
                }
                if (txtad.Text == "" && txttel.Text == "")
                {
                    MessageBox.Show("ILK ONCE MUSTERI ADI VE NUMARASI GIRINIZ!");
                }
                else
                {
                    tbl_masalar tbl = new tbl_masalar();
                    tbl.MasaID = Convert.ToInt32(txtid.Text);
                    tbl.MusteriAdi = txtad.Text;
                    tbl.TelNo = txttel.Text;
                    db.tbl_masalar.Add(tbl);
                    db.SaveChanges();
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa11.ForeColor = Color.Red;
                    MessageBox.Show("Basariyla Rezerve ettiniz.", "Tebrikler");
                    txtid.Text = "";
                    txtad.Text = "";
                    txttel.Text = "";
                }

            }

            return;
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Rezerveyi iptal etmek ister misin?", "Rezerveli ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                int kod = Convert.ToInt32(lbl11.Text);
                var numara = db.tbl_masalar.Where(x => x.MasaID == kod).FirstOrDefault();
                if (numara != null)
                {
                    db.tbl_masalar.Remove(numara);
                    db.SaveChanges();

                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa11.ForeColor = Color.Lime;
                    MessageBox.Show("Basariyla iptal ettiniz.", "Tebrikler");
                }
                else
                {
                    MessageBox.Show("İptal edilmedi!", "UYARI");
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();

                }

            }

            return;
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Masayi Rezerve etmek ister misin?", "Masa bos ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                if (txtid.Text == "")
                {
                    txtid.Text = "12";
                }
                else
                {
                    txtid.Text = "";
                    txtid.Text = "12";
                }
                if (txtad.Text == "" && txttel.Text == "")
                {
                    MessageBox.Show("ILK ONCE MUSTERI ADI VE NUMARASI GIRINIZ!");
                }
                else
                {
                    tbl_masalar tbl = new tbl_masalar();
                    tbl.MasaID = Convert.ToInt32(txtid.Text);
                    tbl.MusteriAdi = txtad.Text;
                    tbl.TelNo = txttel.Text;
                    db.tbl_masalar.Add(tbl);
                    db.SaveChanges();
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa12.ForeColor = Color.Red;
                    MessageBox.Show("Basariyla Rezerve ettiniz.", "Tebrikler");
                }

            }

            return;
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Rezerveyi iptal etmek ister misin?", "Rezerveli ise", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                int kod = Convert.ToInt32(lbl12.Text);
                var numara = db.tbl_masalar.Where(x => x.MasaID == kod).FirstOrDefault();
                if (numara != null)
                {
                    db.tbl_masalar.Remove(numara);
                    db.SaveChanges();

                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                    btnMasa12.ForeColor = Color.Lime;
                    MessageBox.Show("Basariyla iptal ettiniz.", "Tebrikler");
                }
                else
                {
                    MessageBox.Show("İptal edilmedi!", "UYARI");
                    dtrezervasyon.DataSource = db.tbl_masalar.ToList();

                }

            }

            return;
        }

        private void btnrez_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtad.Text == "" && txttel.Text == "")
                {
                    MessageBox.Show("ILK ONCE MUSTERI ADI VE NUMARASI GIRINIZ!");
                }
                else
                {

                    if (Convert.ToInt32(txtid.Text) <= 12)
                    {

                        tbl_masalar tbl = new tbl_masalar();
                        tbl.MasaID = Convert.ToInt32(txtid.Text);
                        tbl.MusteriAdi = txtad.Text;
                        tbl.TelNo = txttel.Text;
                        db.tbl_masalar.Add(tbl);
                        db.SaveChanges();
                        int b;
                        b = Convert.ToInt32(txtid.Text);
                        dtrezervasyon.DataSource = db.tbl_masalar.ToList();
                        if (1 == b)
                        {
                            btnMasa1.ForeColor = Color.Red;
                        }
                        else if (1 == b)
                        {
                            btnMasa1.ForeColor = Color.Red;
                        }
                        else if (2 == b)
                        {
                            btnMasa2.ForeColor = Color.Red;
                        }
                        else if (3 == b)
                        {
                            btnMasa3.ForeColor = Color.Red;
                        }
                        else if (5 == b)
                        {
                            btnMasa5.ForeColor = Color.Red;
                        }
                        else if (4 == b)
                        {
                            btnMasa1.ForeColor = Color.Red;
                        }
                        else if (5 == b)
                        {
                            btnMasa5.ForeColor = Color.Red;
                        }
                        else if (6 == b)
                        {
                            btnMasa6.ForeColor = Color.Red;
                        }
                        else if (7 == b)
                        {
                            btnMasa7.ForeColor = Color.Red;
                        }
                        else if (8 == b)
                        {
                            btnMasa8.ForeColor = Color.Red;
                        }
                        else if (9 == b)
                        {
                            btnMasa9.ForeColor = Color.Red;
                        }
                        else if (10 == b)
                        {
                            btnMasa10.ForeColor = Color.Red;
                        }
                        else if (11 == b)
                        {
                            btnMasa11.ForeColor = Color.Red;
                        }
                        else if (12 == b)
                        {
                            btnMasa12.ForeColor = Color.Red;
                        }
                        txtid.Text = "";
                        txtad.Text = "";
                        txttel.Text = "";





                    }
                    else
                    {
                        MessageBox.Show("Şuanlık 12 den fazla Masamız bulunmamaktadır.", "Uyarı !");
                    }                                 
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnmasabos_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}