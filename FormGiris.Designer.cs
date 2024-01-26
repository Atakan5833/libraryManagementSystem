namespace KutuphaneGirisSistemi
{
    partial class FormGiris
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
            buttonGiris = new Button();
            label1 = new Label();
            textBoxKullanici = new TextBox();
            label2 = new Label();
            textBoxSifre = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonGiris
            // 
            buttonGiris.Font = new Font("Segoe UI", 12F);
            buttonGiris.Location = new Point(196, 303);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(161, 49);
            buttonGiris.TabIndex = 0;
            buttonGiris.Text = "Giriş";
            buttonGiris.UseVisualStyleBackColor = true;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(27, 150);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı: ";
            // 
            // textBoxKullanici
            // 
            textBoxKullanici.Location = new Point(196, 154);
            textBoxKullanici.Name = "textBoxKullanici";
            textBoxKullanici.Size = new Size(161, 27);
            textBoxKullanici.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(27, 232);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(196, 233);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(161, 27);
            textBoxSifre.TabIndex = 5;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(57, 26);
            label3.Name = "label3";
            label3.Size = new Size(300, 35);
            label3.TabIndex = 6;
            label3.Text = "Welcome To The Library";
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(411, 439);
            Controls.Add(label3);
            Controls.Add(textBoxSifre);
            Controls.Add(label2);
            Controls.Add(textBoxKullanici);
            Controls.Add(label1);
            Controls.Add(buttonGiris);
            Name = "FormGiris";
            Text = "Witch Library";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGiris;
        private Label label1;
        private TextBox textBoxKullanici;
        private Label label2;
        private TextBox textBoxSifre;
        private Label label3;
    }
}
