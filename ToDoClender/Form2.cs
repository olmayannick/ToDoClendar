using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ToDoApplication
{
    public partial class Form2 : Form
    {
        public string girisId_Form2;
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void btnToDoEkle_Click(object sender, EventArgs e)
        {
            string toDo = textBox1.Text.ToString();
            string toDoTarih = dateTimePicker1.Text.ToString();
            Veritabani yapilacak = new Veritabani();
            yapilacak.todoEkle(girisId_Form2, toDo, toDoTarih);
            MessageBox.Show("Yapılacak işlem listeye eklendi!");
            listele();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = girisId_Form2;
            listele();
        }

        public void listele()
        {
            Veritabani list = new Veritabani();
            list.listele(listView1, girisId_Form2);
        }

        private void btnToDoSil_Click(object sender, EventArgs e)
        {
            string aranacakislem = textBox1.Text.ToString();
            Veritabani sil = new Veritabani();
            sil.todoSil(aranacakislem);
            listele();

        }
    }
}
