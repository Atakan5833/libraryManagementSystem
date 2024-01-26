namespace KutuphaneGirisSistemi
{
    partial class FormKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitaplar));
            groupBox1 = new GroupBox();
            buttonSil = new Button();
            buttonTumKitaplar = new Button();
            buttonAra = new Button();
            buttonTemizle = new Button();
            buttonBilgiGuncelle = new Button();
            buttonKitapEkle = new Button();
            textBoxKitapTurKodu = new TextBox();
            textBoxISBN = new TextBox();
            textBoxYazarSoyadi = new TextBox();
            textBoxYazarAdi = new TextBox();
            labelKitapID = new Label();
            textBoxKitapAdi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label12 = new Label();
            buttonOdunc = new Button();
            dateTimePickerOduncTarihi = new DateTimePicker();
            textBoxOduncAlan = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            label13 = new Label();
            buttonIade = new Button();
            label11 = new Label();
            label10 = new Label();
            buttonDurum = new Button();
            label9 = new Label();
            groupBox4 = new GroupBox();
            dataGridViewKitaplar = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSil);
            groupBox1.Controls.Add(buttonTumKitaplar);
            groupBox1.Controls.Add(buttonAra);
            groupBox1.Controls.Add(buttonTemizle);
            groupBox1.Controls.Add(buttonBilgiGuncelle);
            groupBox1.Controls.Add(buttonKitapEkle);
            groupBox1.Controls.Add(textBoxKitapTurKodu);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxYazarSoyadi);
            groupBox1.Controls.Add(textBoxYazarAdi);
            groupBox1.Controls.Add(labelKitapID);
            groupBox1.Controls.Add(textBoxKitapAdi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 334);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kayıt ve Güncelleme";
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(330, 276);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(115, 33);
            buttonSil.TabIndex = 15;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonTumKitaplar
            // 
            buttonTumKitaplar.Location = new Point(330, 237);
            buttonTumKitaplar.Name = "buttonTumKitaplar";
            buttonTumKitaplar.Size = new Size(115, 33);
            buttonTumKitaplar.TabIndex = 14;
            buttonTumKitaplar.Text = "Tüm Kitaplar";
            buttonTumKitaplar.UseVisualStyleBackColor = true;
            buttonTumKitaplar.Click += buttonTumKitaplar_Click;
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(203, 276);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(115, 33);
            buttonAra.TabIndex = 13;
            buttonAra.Text = "Kitap Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // buttonTemizle
            // 
            buttonTemizle.Location = new Point(16, 276);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(172, 33);
            buttonTemizle.TabIndex = 12;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = true;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // buttonBilgiGuncelle
            // 
            buttonBilgiGuncelle.Location = new Point(16, 237);
            buttonBilgiGuncelle.Name = "buttonBilgiGuncelle";
            buttonBilgiGuncelle.Size = new Size(172, 33);
            buttonBilgiGuncelle.TabIndex = 11;
            buttonBilgiGuncelle.Text = "Kitap Bilgileri Güncelle";
            buttonBilgiGuncelle.UseVisualStyleBackColor = true;
            buttonBilgiGuncelle.Click += buttonBilgiGuncelle_Click;
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.Location = new Point(203, 237);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(115, 33);
            buttonKitapEkle.TabIndex = 0;
            buttonKitapEkle.Text = "Yeni Kitap Ekle";
            buttonKitapEkle.UseVisualStyleBackColor = true;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // textBoxKitapTurKodu
            // 
            textBoxKitapTurKodu.Font = new Font("Segoe UI", 8F);
            textBoxKitapTurKodu.Location = new Point(177, 192);
            textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            textBoxKitapTurKodu.Size = new Size(233, 25);
            textBoxKitapTurKodu.TabIndex = 10;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Font = new Font("Segoe UI", 8F);
            textBoxISBN.Location = new Point(177, 161);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(233, 25);
            textBoxISBN.TabIndex = 9;
            // 
            // textBoxYazarSoyadi
            // 
            textBoxYazarSoyadi.Font = new Font("Segoe UI", 8F);
            textBoxYazarSoyadi.Location = new Point(177, 130);
            textBoxYazarSoyadi.Name = "textBoxYazarSoyadi";
            textBoxYazarSoyadi.Size = new Size(233, 25);
            textBoxYazarSoyadi.TabIndex = 8;
            // 
            // textBoxYazarAdi
            // 
            textBoxYazarAdi.Font = new Font("Segoe UI", 8F);
            textBoxYazarAdi.Location = new Point(177, 99);
            textBoxYazarAdi.Name = "textBoxYazarAdi";
            textBoxYazarAdi.Size = new Size(233, 25);
            textBoxYazarAdi.TabIndex = 7;
            // 
            // labelKitapID
            // 
            labelKitapID.AutoSize = true;
            labelKitapID.Font = new Font("Segoe UI", 11F);
            labelKitapID.Location = new Point(177, 40);
            labelKitapID.Name = "labelKitapID";
            labelKitapID.Size = new Size(20, 25);
            labelKitapID.TabIndex = 6;
            labelKitapID.Text = "-";
            // 
            // textBoxKitapAdi
            // 
            textBoxKitapAdi.Font = new Font("Segoe UI", 8F);
            textBoxKitapAdi.Location = new Point(177, 68);
            textBoxKitapAdi.Name = "textBoxKitapAdi";
            textBoxKitapAdi.Size = new Size(233, 25);
            textBoxKitapAdi.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(25, 192);
            label6.Name = "label6";
            label6.Size = new Size(146, 25);
            label6.TabIndex = 5;
            label6.Text = "Kitap Tür Kodu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(25, 161);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 4;
            label5.Text = "ISBN :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(25, 130);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 3;
            label4.Text = "Yazar Soyadı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(25, 99);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 2;
            label3.Text = "Yazar Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(25, 68);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Kitap Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(25, 40);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(buttonOdunc);
            groupBox2.Controls.Add(dateTimePickerOduncTarihi);
            groupBox2.Controls.Add(textBoxOduncAlan);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 8F);
            groupBox2.Location = new Point(504, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 334);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödünç Alma";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7F);
            label12.Location = new Point(103, 189);
            label12.Name = "label12";
            label12.Size = new Size(139, 15);
            label12.TabIndex = 18;
            label12.Text = "Ödünç süresi 10 gündür!!";
            // 
            // buttonOdunc
            // 
            buttonOdunc.Location = new Point(105, 137);
            buttonOdunc.Name = "buttonOdunc";
            buttonOdunc.Size = new Size(134, 49);
            buttonOdunc.TabIndex = 18;
            buttonOdunc.Text = "Kitabı Ödünç Ver";
            buttonOdunc.UseVisualStyleBackColor = true;
            buttonOdunc.Click += buttonOdunc_Click;
            // 
            // dateTimePickerOduncTarihi
            // 
            dateTimePickerOduncTarihi.Location = new Point(167, 71);
            dateTimePickerOduncTarihi.Name = "dateTimePickerOduncTarihi";
            dateTimePickerOduncTarihi.Size = new Size(128, 25);
            dateTimePickerOduncTarihi.TabIndex = 14;
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Font = new Font("Segoe UI", 8F);
            textBoxOduncAlan.Location = new Point(154, 40);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(162, 25);
            textBoxOduncAlan.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(20, 71);
            label8.Name = "label8";
            label8.Size = new Size(128, 25);
            label8.TabIndex = 13;
            label8.Text = "Ödünç Tarihi :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(20, 40);
            label7.Name = "label7";
            label7.Size = new Size(120, 25);
            label7.TabIndex = 12;
            label7.Text = "Ödünç Alan :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(buttonIade);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(buttonDurum);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(881, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 334);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "İade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7F);
            label13.Location = new Point(60, 189);
            label13.Name = "label13";
            label13.Size = new Size(169, 15);
            label13.TabIndex = 19;
            label13.Text = "Günlük gecikme bedeli 3TL'dir.";
            // 
            // buttonIade
            // 
            buttonIade.Location = new Point(60, 248);
            buttonIade.Name = "buttonIade";
            buttonIade.Size = new Size(134, 49);
            buttonIade.TabIndex = 17;
            buttonIade.Text = "Kitabı İade Et";
            buttonIade.UseVisualStyleBackColor = true;
            buttonIade.Click += buttonIade_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(174, 40);
            label11.Name = "label11";
            label11.Size = new Size(31, 25);
            label11.TabIndex = 16;
            label11.Text = "TL";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(118, 40);
            label10.Name = "label10";
            label10.Size = new Size(22, 25);
            label10.TabIndex = 12;
            label10.Text = "0";
            // 
            // buttonDurum
            // 
            buttonDurum.Location = new Point(60, 137);
            buttonDurum.Name = "buttonDurum";
            buttonDurum.Size = new Size(134, 49);
            buttonDurum.TabIndex = 12;
            buttonDurum.Text = "Gecikme Durumu Hesapla";
            buttonDurum.UseVisualStyleBackColor = true;
            buttonDurum.Click += buttonDurum_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(19, 40);
            label9.Name = "label9";
            label9.Size = new Size(93, 25);
            label9.TabIndex = 15;
            label9.Text = "Gecikme :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewKitaplar);
            groupBox4.Location = new Point(12, 352);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1122, 246);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Dock = DockStyle.Fill;
            dataGridViewKitaplar.Location = new Point(3, 23);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.RowHeadersWidth = 51;
            dataGridViewKitaplar.Size = new Size(1116, 220);
            dataGridViewKitaplar.TabIndex = 0;
            dataGridViewKitaplar.Tag = "";
            dataGridViewKitaplar.CellContentClick += dataGridViewKitaplar_CellContentClick_1;
            // 
            // FormKitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkMagenta;
            ClientSize = new Size(1146, 610);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormKitaplar";
            Text = " Witch Library Yönetim Sistemi";
            FormClosed += FormKitaplar_FormClosed;
            Load += FormKitaplar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label labelKitapID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxYazarAdi;
        private TextBox textBoxKitapAdi;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyadi;
        private Button buttonKitapEkle;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKitaplar;
        private Button buttonBilgiGuncelle;
        private TextBox textBoxOduncAlan;
        private Label label8;
        private Label label7;
        private Button buttonOdunc;
        private DateTimePicker dateTimePickerOduncTarihi;
        private Button buttonIade;
        private Label label11;
        private Label label10;
        private Button buttonDurum;
        private Label label9;
        private Label label12;
        private Label label13;
        private Button buttonAra;
        private Button buttonTemizle;
        private Button buttonTumKitaplar;
        private Button buttonSil;
    }
}