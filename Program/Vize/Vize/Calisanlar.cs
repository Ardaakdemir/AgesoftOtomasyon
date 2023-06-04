using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Vize
{
    public partial class Calisanlar : Form
    {
        public Calisanlar()
        {
            InitializeComponent();
            datagridvcalisan.DataSource = db.tbl_calisanlar.ToList();
            this.datagridvcalisan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int kayitSayisi = datagridvcalisan.Rows.Count;
            lblcalisansayisi.Text=(kayitSayisi + " adet çalışan bilgisi var.");
        }
        AgesofttEntities1 db = new AgesofttEntities1();
        public class calisanlar
    {
        public string ad;
        public string soyad;
        public string tc;
        public string telefon;
    }
        

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_calisanlar tbl = new tbl_calisanlar();
                tbl.Ad = txtad.Text;
                tbl.Soyad = txtsoyad.Text;
                tbl.TC = txttc.Text;
                tbl.Telefon = txttelefon.Text;
                int uzunad = txtad.Text.Length;
                string ad = txtad.Text;
                string soyad = txtsoyad.Text;
                string tc = txttc.Text;
                string tel = txttelefon.Text;
                string sifre = ad + soyad + tel + tc;
                int uzunluk = sifre.Length;
                string username, pass = "";
                if (uzunad < 4)
                {
                    username = txtad.Text.Substring(0, 3) + txtsoyad.Text.Substring(0, 2) + txttelefon.Text.Substring(4, 2);
                }
                else { username = txtad.Text.Substring(0, 4) + txtsoyad.Text.Substring(0, 1) + txttelefon.Text.Substring(5, 2); }
                Random rnd = new Random();
                for (int i = 0; i < 6; i++)
                {
                    pass += sifre[rnd.Next(uzunluk)];
                }
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] dizi = Encoding.UTF8.GetBytes(pass);
                byte[] sonuc = md5.ComputeHash(dizi);
                lblencrypted.Text = Convert.ToBase64String(sonuc);
                tbl.Username = username;
                tbl.Password = lblencrypted.Text;

                db.tbl_calisanlar.Add(tbl);
                db.SaveChanges();
                lblusername.Text = username;
                lblpassword.Text = pass;
                gbsifre.Visible = true;
                txtad.Text = "";
                txttc.Text = "";
                txttelefon.Text = "";
                txtsoyad.Text = "";
                datagridvcalisan.DataSource = db.tbl_calisanlar.ToList();




            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            int kod = Convert.ToInt32(txtId.Text);
            var numara = db.tbl_calisanlar.Where(x => x.ID == kod).FirstOrDefault();
            if (numara != null)
            {
                db.tbl_calisanlar.Remove(numara);
                db.SaveChanges();
                btnKayit.PerformClick();
                datagridvcalisan.DataSource = db.tbl_calisanlar.ToList();
                MessageBox.Show("Kullanici Silindi!", "UYARI");
            }
            else
            {
                MessageBox.Show("ID girmediniz!", "UYARI");
                datagridvcalisan.DataSource = db.tbl_calisanlar.ToList();

            }
        }

        private void gbsifre_Enter(object sender, EventArgs e)
        {
            lblpassword.Text = "empty";
            lblusername.Text = "empty";
            lblencrypted.Text = "empty";
        }

        private void Calisanlar_Load(object sender, EventArgs e)
        {

        }
    }
}
