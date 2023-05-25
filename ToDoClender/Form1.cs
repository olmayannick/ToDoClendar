using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApplication
{
    public partial class Form1 : Form
    {
        string girisDurumu;
        public string girisId;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Form3 kayitol = new Form3();
            Form1 giris = new Form1();
            kayitol.Show();
            this.Hide();
        }

        private void chcSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chcSifreyiGoster.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
            }
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            Form4 sifreDegistir = new Form4();
            sifreDegistir.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtId.Text.ToString();
            string kullaniciSifre = txtSifre.Text.ToString();
            Veritabani giris = new Veritabani();
            girisDurumu = giris.girisSorgula(kullaniciAdi, kullaniciSifre);
            if (girisDurumu == "True")
            {
                Form2 todoGiris = new Form2();
                todoGiris.girisId_Form2 = kullaniciAdi;
                todoGiris.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Giriş başarısız!");
            }

        }


    }
}
