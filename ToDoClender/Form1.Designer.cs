
namespace ToDoApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new System.Windows.Forms.TextBox();
            txtSifre = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            chcSifreyiGoster = new System.Windows.Forms.CheckBox();
            btnKayit = new System.Windows.Forms.Button();
            btnSifre = new System.Windows.Forms.Button();
            btnGiris = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(95, 16);
            txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(126, 23);
            txtId.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new System.Drawing.Point(95, 50);
            txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new System.Drawing.Size(126, 23);
            txtSifre.TabIndex = 1;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // chcSifreyiGoster
            // 
            chcSifreyiGoster.AutoSize = true;
            chcSifreyiGoster.Location = new System.Drawing.Point(95, 87);
            chcSifreyiGoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chcSifreyiGoster.Name = "chcSifreyiGoster";
            chcSifreyiGoster.Size = new System.Drawing.Size(95, 19);
            chcSifreyiGoster.TabIndex = 2;
            chcSifreyiGoster.Text = "Şifreyi Göster";
            chcSifreyiGoster.UseVisualStyleBackColor = true;
            chcSifreyiGoster.CheckedChanged += chcSifreyiGoster_CheckedChanged;
            // 
            // btnKayit
            // 
            btnKayit.Location = new System.Drawing.Point(95, 157);
            btnKayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new System.Drawing.Size(126, 41);
            btnKayit.TabIndex = 4;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // btnSifre
            // 
            btnSifre.Location = new System.Drawing.Point(257, 159);
            btnSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSifre.Name = "btnSifre";
            btnSifre.Size = new System.Drawing.Size(130, 39);
            btnSifre.TabIndex = 5;
            btnSifre.Text = "Şifremi Unuttum";
            btnSifre.UseVisualStyleBackColor = true;
            btnSifre.Click += btnSifre_Click;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = System.Drawing.SystemColors.Control;
            btnGiris.Location = new System.Drawing.Point(257, 16);
            btnGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new System.Drawing.Size(130, 57);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(412, 256);
            Controls.Add(btnGiris);
            Controls.Add(btnSifre);
            Controls.Add(btnKayit);
            Controls.Add(chcSifreyiGoster);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSifre);
            Controls.Add(txtId);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chcSifreyiGoster;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnSifre;
        private System.Windows.Forms.Button btnGiris;
    }
}

