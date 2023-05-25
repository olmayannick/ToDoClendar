
namespace ToDoApplication
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtKayitIsim = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtKayitMail = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtKayitId = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtKayitSifre = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtKayitSifreTekrar = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtKayitMailTekrar = new System.Windows.Forms.TextBox();
            btnKayitOl = new System.Windows.Forms.Button();
            btnGeriDon = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            cmbSoru = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            txtCevap = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtKayitIsim
            // 
            txtKayitIsim.Location = new System.Drawing.Point(136, 44);
            txtKayitIsim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtKayitIsim.Name = "txtKayitIsim";
            txtKayitIsim.Size = new System.Drawing.Size(168, 23);
            txtKayitIsim.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "İsim-Soyisim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(36, 149);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "E-Mail Tekrar";
            // 
            // txtKayitMail
            // 
            txtKayitMail.Location = new System.Drawing.Point(136, 112);
            txtKayitMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtKayitMail.Name = "txtKayitMail";
            txtKayitMail.Size = new System.Drawing.Size(168, 23);
            txtKayitMail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(36, 78);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "Kullanıcı Adı";
            // 
            // txtKayitId
            // 
            txtKayitId.Location = new System.Drawing.Point(136, 78);
            txtKayitId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtKayitId.Name = "txtKayitId";
            txtKayitId.Size = new System.Drawing.Size(168, 23);
            txtKayitId.TabIndex = 1;
            txtKayitId.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(36, 185);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(30, 15);
            label4.TabIndex = 7;
            label4.Text = "Şifre";
            // 
            // txtKayitSifre
            // 
            txtKayitSifre.Location = new System.Drawing.Point(136, 185);
            txtKayitSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtKayitSifre.Name = "txtKayitSifre";
            txtKayitSifre.Size = new System.Drawing.Size(168, 23);
            txtKayitSifre.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(36, 220);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(64, 15);
            label5.TabIndex = 9;
            label5.Text = "Şifre Tekrar";
            // 
            // txtKayitSifreTekrar
            // 
            txtKayitSifreTekrar.Location = new System.Drawing.Point(136, 220);
            txtKayitSifreTekrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtKayitSifreTekrar.Name = "txtKayitSifreTekrar";
            txtKayitSifreTekrar.Size = new System.Drawing.Size(168, 23);
            txtKayitSifreTekrar.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(36, 112);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "E-Mail";
            // 
            // txtKayitMailTekrar
            // 
            txtKayitMailTekrar.Location = new System.Drawing.Point(136, 148);
            txtKayitMailTekrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtKayitMailTekrar.Name = "txtKayitMailTekrar";
            txtKayitMailTekrar.Size = new System.Drawing.Size(168, 23);
            txtKayitMailTekrar.TabIndex = 3;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new System.Drawing.Point(36, 320);
            btnKayitOl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new System.Drawing.Size(267, 27);
            btnKayitOl.TabIndex = 8;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.Location = new System.Drawing.Point(36, 352);
            btnGeriDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new System.Drawing.Size(267, 32);
            btnGeriDon.TabIndex = 9;
            btnGeriDon.Text = "Zaten Hesabım Var";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(38, 254);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(56, 15);
            label7.TabIndex = 14;
            label7.Text = "Gizli Soru";
            // 
            // cmbSoru
            // 
            cmbSoru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSoru.FormattingEnabled = true;
            cmbSoru.Items.AddRange(new object[] { "En sevdiğin renk", "En sevdiğin şehir", "Favori mesleğin", "Favori öğretmeninin adı", "İlk aşkının adı" });
            cmbSoru.Location = new System.Drawing.Point(136, 254);
            cmbSoru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmbSoru.Name = "cmbSoru";
            cmbSoru.Size = new System.Drawing.Size(168, 23);
            cmbSoru.Sorted = true;
            cmbSoru.TabIndex = 6;
            cmbSoru.UseWaitCursor = true;
            cmbSoru.SelectedIndexChanged += cmbSoru_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(38, 284);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(65, 15);
            label8.TabIndex = 16;
            label8.Text = "Gizli Cevap";
            // 
            // txtCevap
            // 
            txtCevap.Location = new System.Drawing.Point(136, 284);
            txtCevap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCevap.Name = "txtCevap";
            txtCevap.Size = new System.Drawing.Size(168, 23);
            txtCevap.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(38, 14);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(140, 15);
            label9.TabIndex = 18;
            label9.Text = "Boş kısımları doldurunuz.";
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(363, 406);
            Controls.Add(label9);
            Controls.Add(txtCevap);
            Controls.Add(label8);
            Controls.Add(cmbSoru);
            Controls.Add(label7);
            Controls.Add(btnGeriDon);
            Controls.Add(btnKayitOl);
            Controls.Add(label6);
            Controls.Add(txtKayitMailTekrar);
            Controls.Add(label5);
            Controls.Add(txtKayitSifreTekrar);
            Controls.Add(label4);
            Controls.Add(txtKayitSifre);
            Controls.Add(label3);
            Controls.Add(txtKayitId);
            Controls.Add(label2);
            Controls.Add(txtKayitMail);
            Controls.Add(label1);
            Controls.Add(txtKayitIsim);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtKayitIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKayitMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKayitId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKayitSifreTekrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKayitMailTekrar;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSoru;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Label label9;
    }
}