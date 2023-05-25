using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ToDoApplication
{

    public partial class Form3 : Form
    {
        string durumum;
        string mailDurum;
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=ToDoProject;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtKayitIsim.Text.Length < 1)
            {
                label9.Text = "İsim kısmı boş kalamaz";
                label9.ForeColor = Color.Red;
            }
            else if (txtKayitId.Text.Length < 1)
            {
                label9.Text = "Kullanıcı adı kısmı boş kalamaz";
                label9.ForeColor = Color.Red;
            }
            else if (txtKayitMail.Text.Length < 1)
            {
                label9.Text = "Mail kısmı boş kalamaz";
                label9.ForeColor = Color.Red;
            }
            else if (txtKayitMailTekrar.Text.Length < 1)
            {
                label9.Text = "Mail tekrar kısmı boş kalamaz";
                label9.ForeColor = Color.Red;
            }
            else if (txtKayitMail.Text.Length < 1)
            {
                label9.Text = "Mail kısmı boş kalamaz";
                label9.ForeColor = Color.Red;
            }
            else if (txtKayitSifre.Text.Length < 1)
            {
                label9.Text = "Şifre kısmı boş kalamaz";
                label9.ForeColor = Color.Red;
            }
            else if (txtKayitSifreTekrar.Text.Length < 1)
            {
                label9.Text = "Şifre tekrar kısmı boş kalamaz";
                label9.ForeColor = Color.Red;
            }
            else if (cmbSoru.Text.Length < 1)
            {
                label9.Text = "Soru kısmı boş kalamaz";
                label9.ForeColor = Color.Red;
            }
            else if (txtCevap.Text.Length < 1)
            {
                label9.Text = "Soruya cevap kısmı boş kalamaz";
                label9.ForeColor = Color.Red;
            }
            else
            {
                if (txtKayitMail.Text != txtKayitMailTekrar.Text || txtKayitSifre.Text != txtKayitSifreTekrar.Text)
                {
                    label9.Text = "Tekrar alanları aynı değil.";
                }
                else
                {
                    Veritabani kayitArama = new Veritabani();
                    durumum = kayitArama.kayitAra(txtKayitId.Text);
                    Veritabani mailara = new Veritabani();
                    mailDurum = mailara.mailAra(txtKayitMail.Text);

                    if (txtKayitMail.Text.Contains("@") == false)
                    {
                        label9.Text = "Lütfen gerçek bir mail giriniz.";
                    }
                    else if (txtKayitIsim.Text.Length < 3)
                    {
                        label9.Text = "İsim alanı çok kısa.";
                    }
                    else if (durumum == "true")
                    {
                        label9.Text = "Bu kullanıcı adı sistemde kayıtlı.";
                    }
                    else if (mailDurum == "true")
                    {
                        label9.Text = "Bu mail adresi zaten sistemde kayıtlı.";
                    }
                    else
                    {
                        string kayitIsim = txtKayitIsim.Text;
                        string kayitId = txtKayitId.Text;
                        string kayitMail = txtKayitMail.Text;
                        string kayitMailTekrar = txtKayitMailTekrar.Text;
                        string kayitSifre = txtKayitSifre.Text;
                        string kayitSifreTekrar = txtKayitSifreTekrar.Text;
                        string kayitSoruCevap = txtCevap.Text;
                        string kayitSoru = cmbSoru.Text;


                        Veritabani girisicin = new Veritabani();

                        girisicin.kayitEkle(kayitIsim, kayitId, kayitMail, kayitMailTekrar, kayitSifre, kayitSifreTekrar, kayitSoru, kayitSoruCevap);


                        label9.Text = "Kayıt başarılı.";
                        label9.ForeColor = Color.Green;

                        txtKayitIsim.Text = "";
                        txtKayitId.Text = "";
                        txtKayitMail.Text = "";
                        txtKayitMailTekrar.Text = "";
                        txtKayitSifre.Text = "";
                        txtKayitSifreTekrar.Text = "";
                        txtCevap.Text = "";
                        cmbSoru.Text = "";
                    }
                }

            }


        }

        private void cmbSoru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            Form3 kayitol = new Form3();
            giris.Show();
            this.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
