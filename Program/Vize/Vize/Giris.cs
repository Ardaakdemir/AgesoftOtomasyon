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

    public partial class Giris : Form
    {

        public Giris()
        {

            InitializeComponent();
            guvenlik();
        }
        AgesofttEntities1 db = new AgesofttEntities1();
        string sifreleme(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(txtSifre.Text);
            byte[] sonuc = md5.ComputeHash(dizi);
            return Convert.ToBase64String(sonuc);
        }
        void guvenlik()
        {
            Random rnd = new Random();
            string guvenlik = "";
            string yazi = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890";
            for (int i = 0; i < 6; i++)
            {
                guvenlik += yazi[rnd.Next(yazi.Length)];
            }
            lblguvenlik.Text = guvenlik;
        }
        


        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] dizi = Encoding.UTF8.GetBytes(txtSifre.Text);
                byte[] sonuc = md5.ComputeHash(dizi);
                lblsorgu.Text = Convert.ToBase64String(sonuc);
                var giris = db.tbl_calisanlar.Where(x => x.Username == txtGiris.Text && x.Password == lblsorgu.Text).FirstOrDefault();
                if (giris != null && lblguvenlik.Text == txtguvenlik.Text)
                {
                    giris.SonGiris = DateTime.Now.ToString();
                    db.SaveChanges();
                    Menu men = new Menu(giris.ID);
                    men.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanici adi, sifre veya guvenlik kodu yanlis", "Uyari!");
                    this.BackColor = Color.Red;
                    pb23.Image = Properties.Resources.logo_transparent2;
                    count++;
                    lblHata.Text = count.ToString();
                    lblHata.Visible = true;
                    lblHatali.Visible = true;
                    guvenlik();
                    if (count == 5)
                    {
                        MessageBox.Show("5 defa hatalı giriş yaptınız.");
                        txtGiris.Enabled = false;
                        txtSifre.Enabled = false;
                        txtguvenlik.Enabled = false;
                        btnGiris.Enabled = false;
                    }



                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }


        }

        private void lblguvenlik_Click(object sender, EventArgs e)
        {
            guvenlik();
        }

        private void pcSoru_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hocam Kullanıcı adı: admin  Sifre=beykent veya calisan isim ve şifresi ile giriş yapılabiliyor.");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult d = new DialogResult();
            d = MessageBox.Show("Kapatmak istiyor musunuz?", "Uyari!", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                this.Close();
                return;
            }
            else
            {
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarihh.Text = DateTime.Now.ToLongDateString();
            lblSaatt.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblTarihh_Click(object sender, EventArgs e)
        {

        }

        private void lblSaatt_Click(object sender, EventArgs e)
        {
            
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            txtGiris.MaxLength = 8;
            txtSifre.MaxLength = 8;
            timer1.Enabled = true;
        }
    }
}




        //private void Giris_Load(object sender, EventArgs e)
        //{
        //    btnGiris.Enabled = false;
        //}

        //private void pictureBox2_MouseHover(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Hocam Kullanıcı adı: admin  Sifre=beykent");
        //}

        //private void pictureBox2_Click(object sender, EventArgs e)
        //{

        //}

        //private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    MessageBox.Show("Programdan çıktınız.","Basariyla");
        //}

        //private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult d = new DialogResult();
        //    d = MessageBox.Show("Kapatmak istiyor musunuz?", "Uyari!", MessageBoxButtons.YesNo);
        //    if (d == DialogResult.No)
        //        e.Cancel = true;
        //                 return;
        //}

        //private void btnCikis_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void ckRobot_CheckedChanged(object sender, EventArgs e)
        //{
        //    btnGiris.Enabled = true;
        //}

        //private void txtSifre_TextChanged(object sender, EventArgs e)
        //{

        //}
    

