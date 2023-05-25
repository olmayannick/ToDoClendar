using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToDoApplication
{
    public partial class Form4 : Form
    {
        string sifreReturn;
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtId_d.Text.ToString();
            string mail = txtMail_d.Text.ToString();
            string soru = cmbSoru.Text.ToString();
            string cevap = txtCevap_d.Text.ToString();
            string sifre1 = txtSifre_d.Text.ToString();
            string sifre2 = txtSifre2_d.Text.ToString();
            Veritabani sifredegis = new Veritabani();
            sifreReturn = sifredegis.sifreDegisimi(id, mail, soru, cevap);
            if (sifreReturn == "True")
            {
                if (sifre1 == sifre2)
                {
                    Veritabani sifredegistir = new Veritabani();
                    sifredegistir.sifreDegistir(mail, sifre1, sifre2);
                    MessageBox.Show("Şifre değişti");
                    txtCevap_d.Text = "";
                    txtId_d.Text = "";
                    txtMail_d.Text = "";
                    txtSifre2_d.Text = "";
                    txtSifre_d.Text = "";
                    cmbSoru.Text = "";
                }
                else
                {
                    MessageBox.Show("Şifre alanları aynı değil!");
                }
                
            }
            else
            {
                MessageBox.Show("Sistemde girdiğiniz bilgilere uygun bir hesap bulunmuyor!");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
