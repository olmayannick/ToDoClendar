
namespace ToDoApplication
{
    partial class Form4
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
            this.txtId_d = new System.Windows.Forms.TextBox();
            this.txtMail_d = new System.Windows.Forms.TextBox();
            this.txtCevap_d = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSoru = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre_d = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifre2_d = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtId_d
            // 
            this.txtId_d.Location = new System.Drawing.Point(135, 14);
            this.txtId_d.Name = "txtId_d";
            this.txtId_d.Size = new System.Drawing.Size(186, 27);
            this.txtId_d.TabIndex = 0;
            // 
            // txtMail_d
            // 
            this.txtMail_d.Location = new System.Drawing.Point(135, 64);
            this.txtMail_d.Name = "txtMail_d";
            this.txtMail_d.Size = new System.Drawing.Size(186, 27);
            this.txtMail_d.TabIndex = 1;
            // 
            // txtCevap_d
            // 
            this.txtCevap_d.Location = new System.Drawing.Point(135, 150);
            this.txtCevap_d.Name = "txtCevap_d";
            this.txtCevap_d.Size = new System.Drawing.Size(186, 27);
            this.txtCevap_d.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gizli Soru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gizli Cevap";
            // 
            // cmbSoru
            // 
            this.cmbSoru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoru.FormattingEnabled = true;
            this.cmbSoru.Items.AddRange(new object[] {
            "En sevdiğin renk",
            "En sevdiğin şehir",
            "Favori mesleğin",
            "Favori öğretmeninin adı",
            "İlk aşkının adı"});
            this.cmbSoru.Location = new System.Drawing.Point(135, 106);
            this.cmbSoru.Name = "cmbSoru";
            this.cmbSoru.Size = new System.Drawing.Size(186, 28);
            this.cmbSoru.Sorted = true;
            this.cmbSoru.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Şifreyi Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Giriş Sayfasına Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yeni Şifre";
            // 
            // txtSifre_d
            // 
            this.txtSifre_d.Location = new System.Drawing.Point(136, 189);
            this.txtSifre_d.Name = "txtSifre_d";
            this.txtSifre_d.Size = new System.Drawing.Size(186, 27);
            this.txtSifre_d.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Yeni Şifre Tekrar";
            // 
            // txtSifre2_d
            // 
            this.txtSifre2_d.Location = new System.Drawing.Point(135, 231);
            this.txtSifre2_d.Name = "txtSifre2_d";
            this.txtSifre2_d.Size = new System.Drawing.Size(186, 27);
            this.txtSifre2_d.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 405);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSifre2_d);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSifre_d);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbSoru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCevap_d);
            this.Controls.Add(this.txtMail_d);
            this.Controls.Add(this.txtId_d);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId_d;
        private System.Windows.Forms.TextBox txtMail_d;
        private System.Windows.Forms.TextBox txtCevap_d;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSoru;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifre_d;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifre2_d;
    }
}