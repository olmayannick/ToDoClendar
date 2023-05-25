using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ToDoApplication
{
    class Veritabani
    {
        SqlConnection SQLBaglantisi = new SqlConnection("Data Source=SADAHARU;Initial Catalog=ToDoProject;Integrated Security=True");
        string girisDurumu;
        string sifreDurumu;
        public void baglantiyiAc()
        {
            if (SQLBaglantisi.State.ToString() == "Closed")
            {
                SQLBaglantisi.Open();
            }
            else
            {
                MessageBox.Show("Bağlantı zaten açık.");
            }
        }
        public void baglantiyiKapat()
        {
            if (SQLBaglantisi.State.ToString() == "Opened")
            {
                SQLBaglantisi.Close();
            }
            else
            {

            }

        }

        public void kayitEkle(string _kayitIsim, string _kayitId, string _kayitEMail, string _kayitEMailTekrar, string _kayitSifre, string _kayitSifreTekrar, string _kayitGizliSoru, string _kayitGizliCevap)
        {
            baglantiyiAc();
            string kayit1 = "insert into todoTable(kullaniciIdd, kullaniciAdi) values (@kullaniciIddd, @kullaniciAdii)";
            string kayit = "insert into girisTable(isim,eMail,eMailTekrar, sifre, sifreTekrar, gizliSoru, gizliCevap) values (@isim,@eMail,@eMailTekrar,@sifre, @sifreTekrar, @gizliSoru, @gizliCevap) ";
            string sorgula = "select kullaniciId from girisTable where eMail like @emaill";

            SqlCommand ekleKomutu = new SqlCommand(kayit, SQLBaglantisi);
            ekleKomutu.Parameters.AddWithValue("@isim", _kayitIsim);
            ekleKomutu.Parameters.AddWithValue("@eMail", _kayitEMail);
            ekleKomutu.Parameters.AddWithValue("@eMailTekrar", _kayitEMailTekrar);
            ekleKomutu.Parameters.AddWithValue("@sifre", _kayitSifre);
            ekleKomutu.Parameters.AddWithValue("@sifreTekrar", _kayitSifreTekrar);
            ekleKomutu.Parameters.AddWithValue("@gizliSoru", _kayitGizliSoru);
            ekleKomutu.Parameters.AddWithValue("@gizliCevap", _kayitGizliCevap);
            ekleKomutu.ExecuteNonQuery();


            SqlCommand sorgulama = new SqlCommand(sorgula, SQLBaglantisi);
            sorgulama.Parameters.AddWithValue("@emaill", _kayitEMail);
            object sorgum = sorgulama.ExecuteScalar();


            SqlCommand ekleKomutu2 = new SqlCommand(kayit1, SQLBaglantisi);
            ekleKomutu2.Parameters.AddWithValue("@kullaniciIddd", sorgum.ToString());
            ekleKomutu2.Parameters.AddWithValue("@kullaniciAdii", _kayitId);
            ekleKomutu2.ExecuteNonQuery();


            baglantiyiKapat();
            MessageBox.Show("Kayıt eklendi!");
        }

        public string kayitAra(string _kayitId)
        {
            string durum;
            baglantiyiAc();
            SqlCommand da = new SqlCommand("select * from todoTable where kullaniciAdi like @kullaniciAdi", SQLBaglantisi);
            da.Parameters.AddWithValue("@kullaniciAdi", _kayitId);
            SqlDataReader dr = da.ExecuteReader();
            if (dr.Read().ToString() == "True")
            {
                durum = "true";
            }
            else
            {
                durum = "false";
            }
            baglantiyiKapat();
            return durum;
        }

        public string mailAra(string _kayitMail)
        {
            string mailDurum;
            baglantiyiAc();
            SqlCommand daa = new SqlCommand("select * from girisTable where eMail like @eMail", SQLBaglantisi);
            daa.Parameters.AddWithValue("@eMail", _kayitMail);
            SqlDataReader drr = daa.ExecuteReader();
            if (drr.Read().ToString() == "True")
            {
                mailDurum = "true";
            }
            else
            {
                mailDurum = "false";
            }
            baglantiyiKapat();
            return mailDurum;
        }

        public string girisSorgula(string _kayitId, string _kayitSifre)
        {
            baglantiyiAc();




            SqlCommand giris2 = new SqlCommand("select kullaniciIdd from todoTable where kullaniciAdi like @kullaniciAdii", SQLBaglantisi);
            giris2.Parameters.AddWithValue("@kullaniciAdii", _kayitId);
            object sorgumm = giris2.ExecuteScalar();

            SqlCommand giris = new SqlCommand("select * from girisTable where kullaniciId like @kullaniciAdi and sifre like @parola", SQLBaglantisi);
            giris.Parameters.AddWithValue("kullaniciAdi", sorgumm.ToString());    //dfhjklsşksdnfvklbndsklvnskldnvklnskv
            giris.Parameters.AddWithValue("@parola", _kayitSifre);
            SqlDataReader drr2 = giris.ExecuteReader();
            if (drr2.Read().ToString() == "True")
            {
                girisDurumu = "True";
            }
            else
            {
                girisDurumu = "False";
            }
            baglantiyiKapat();
            return girisDurumu;
        }

        public string sifreDegisimi(string _kayitIdd, string _kayitMaill, string _kayitSorusu, string _kayitCevabi)
        {
            baglantiyiAc();
            SqlCommand giris2 = new SqlCommand("select kullaniciIdd from todoTable where kullaniciAdi like @kullaniciAdii", SQLBaglantisi);
            giris2.Parameters.AddWithValue("@kullaniciAdii", _kayitIdd);
            object sorgummm = giris2.ExecuteScalar();

            SqlCommand sifreDegis = new SqlCommand("select * from girisTable where kullaniciId like @kullaniciAdi and eMail like @mail and gizliSoru like @soru and gizliCevap like @cevap", SQLBaglantisi);
            sifreDegis.Parameters.AddWithValue("@kullaniciAdi", sorgummm.ToString());
            sifreDegis.Parameters.AddWithValue("@mail", _kayitMaill);
            sifreDegis.Parameters.AddWithValue("@soru", _kayitSorusu);
            sifreDegis.Parameters.AddWithValue("@cevap", _kayitCevabi);
            SqlDataReader drr3 = sifreDegis.ExecuteReader();
            if (drr3.Read().ToString() == "True")
            {
                sifreDurumu = "True";
            }
            else
            {
                sifreDurumu = "False";
            }
            baglantiyiKapat();
            return sifreDurumu;
        }

        public void sifreDegistir(string _kayitMaili, string _kayitSifre1, string _kayitSifre2)
        {
            baglantiyiAc();
            SqlCommand sifreDegistir = new SqlCommand("update girisTable set sifre=@sifre, sifreTekrar=@sifretekrari where eMail=@mail ", SQLBaglantisi);
            sifreDegistir.Parameters.AddWithValue("@mail", _kayitMaili);
            sifreDegistir.Parameters.AddWithValue("@sifre", _kayitSifre1);
            sifreDegistir.Parameters.AddWithValue("@sifretekrari", _kayitSifre2);
            sifreDegistir.ExecuteNonQuery();
            baglantiyiKapat();

        }

        public void todoEkle(string _kullaniciAdi, string _todo, string _todoTarih)
        {
            baglantiyiAc();
            SqlCommand girisyeni = new SqlCommand("select kullaniciIdd from todoTable where kullaniciAdi like @kullaniciAdii", SQLBaglantisi);
            girisyeni.Parameters.AddWithValue("@kullaniciAdii", _kullaniciAdi);
            object sorguyeni = girisyeni.ExecuteScalar();

            string todoEklemek = "insert into todoTable (kullaniciIdd, kullaniciAdi, todo, todoTarih) values (@id, @kAdi, @yapilacak, @yapilacaktarih)";
            SqlCommand todoAdd = new SqlCommand(todoEklemek, SQLBaglantisi);
            todoAdd.Parameters.AddWithValue("@id", sorguyeni.ToString());
            todoAdd.Parameters.AddWithValue("@kAdi", _kullaniciAdi);
            todoAdd.Parameters.AddWithValue("@yapilacak", _todo);
            todoAdd.Parameters.AddWithValue("@yapilacaktarih", _todoTarih);

            todoAdd.ExecuteNonQuery();
            baglantiyiKapat();
        }

        public void listele(ListView lsit, string _kullaniciAdi)
        {
            lsit.Items.Clear();
            baglantiyiAc();
            string arama = "select kullaniciAdi, todo, todoTarih from todoTable where kullaniciAdi like @kadi";
            SqlCommand aramayeni = new SqlCommand(arama, SQLBaglantisi);
            aramayeni.Parameters.AddWithValue("@kadi", _kullaniciAdi);
            SqlDataReader dr = aramayeni.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["kullaniciAdi"].ToString());
                item.SubItems.Add(dr["todo"].ToString());
                item.SubItems.Add(dr["todoTarih"].ToString());
                lsit.Items.Add(item);
            }
            baglantiyiKapat();

        }
        public string todoArama;
        public string todoAra(string _aranacakIslem)
        {
            baglantiyiAc();
            string arasil = "select * from todoTable where todo like @aranacaktodo";
            SqlCommand silmeislem = new SqlCommand(arasil, SQLBaglantisi);
            silmeislem.Parameters.AddWithValue("@aranacaktodo", _aranacakIslem);

            SqlDataReader drr4 = silmeislem.ExecuteReader();
            if (drr4.Read().ToString() == "True")
            {
                todoArama = "True";
            }
            else
            {
                todoArama = "False";
            }
            baglantiyiKapat();
            return todoArama;
        }

        public void todoSil(string _silinecekIslem)
        {
            if (MessageBox.Show("Silinecek işlemi aynı şekilde boşluğa tamamen yazmanız gerekmektedir. \n Bilgi: Büyük küçük harf duyarlılığı ve noktalama işareti duyarlılığı vardır!", "Dikkat", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {
                baglantiyiAc();
                string araSil = "delete from todoTable where todo like @silinecektodo";
                SqlCommand silmeislemi = new SqlCommand(araSil, SQLBaglantisi);
                silmeislemi.Parameters.AddWithValue("@silinecektodo", _silinecekIslem);
                silmeislemi.ExecuteNonQuery();
                baglantiyiKapat();
            }

        }
    }
}
 