using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneGirisSistemi
{
    public partial class FormKitaplar : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=F58\SQLEXPRESS;Initial Catalog=witchLibrary;Integrated Security=True");

        public FormKitaplar()
        {
            InitializeComponent();
        }

        //Kitapları gösteren fonksiyon
        private void kitaplar()
        {
            try
            {

                string q = "SELECT * FROM TableBooks";
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            kitaplar();
        }


        /*
         if(labelKitapID.Text != "-")
            {
                DateTime bugun = DateTime.Now;
                int fark = (int) (bugun- dateTimePickerOduncTarihi.Value.Date).TotalDays;
                if (fark > 10)
                {
                    int gecikmeBedeli = (fark- 10) *2 ;
                    label10.Text = gecikmeBedeli.ToString();
                }
            }
        */

        //kitap ekleme 
        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                SqlCommand kitapEkle = new SqlCommand("INSERT INTO TableBooks (kitapAdi,yazarAdi,yazarSoyadi, ISBN, durum, kitapTurKodu) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);

                kitapEkle.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                kitapEkle.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                kitapEkle.Parameters.AddWithValue("@P3", textBoxYazarSoyadi.Text);
                kitapEkle.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                kitapEkle.Parameters.AddWithValue("@P5", "False ");
                kitapEkle.Parameters.AddWithValue("@P6", textBoxKitapTurKodu.Text);

                kitapEkle.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Birşeyler ters gitti! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            kitaplar();
        }

        //kitap ekleme yeri
        private void dataGridViewKitaplar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            label10.Text = "0";
            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;

            labelKitapID.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxKitapAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxYazarAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxYazarSoyadi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxKitapTurKodu.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[8].Value.ToString();
            textBoxKitapAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[1].Value.ToString();

            textBoxOduncAlan.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value.ToString();
            if (dataGridViewKitaplar.Rows[secilenSatir].Cells[6].Value != DBNull.Value)
                dateTimePickerOduncTarihi.Value = (DateTime)dataGridViewKitaplar.Rows[secilenSatir].Cells[6].Value;
        }

        private void buttonBilgiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableBooks SET kitapAdi = @P1, yazarAdi = @P2, yazarSoyadi = @P3, ISBN = @P4, kitapTurKodu = @P5 WHERE ID= @P6", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYazarSoyadi.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", textBoxKitapTurKodu.Text);
                sqlCommand.Parameters.AddWithValue("@P6", labelKitapID.Text);

                //yazdığımız queryi çalıştırmak için 
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası " + ex.Message);
            }
            finally { baglanti.Close(); }

            // verileri güncelledikten sonra güncel halini tekrardan verileri göstermesi için tekrardan tablo oluşturuyorum yani o yüzden fonksiyonu çağırıyorum yoksa kapatıp açtıktan sonra görebilirim anca güncellemeyi
            kitaplar();
        }

        //ödünç kısmı
        private void buttonOdunc_Click(object sender, EventArgs e)
        {
            if (labelKitapID.Text != "-")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableBooks SET oduncAlan = @P1, tarih = @P2, durum = @P3 WHERE ID= @P4", baglanti);

                    sqlCommand.Parameters.AddWithValue("@P1", textBoxOduncAlan.Text);
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePickerOduncTarihi.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@P3", "True");
                    sqlCommand.Parameters.AddWithValue("@P4", labelKitapID.Text);
                    //yazdığımız queryi çalıştırmak için 
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme Hatası " + ex.Message);
                }
                finally { baglanti.Close(); }
                // verileri güncelledikten sonra güncel halini tekrardan verileri göstermesi için tekrardan tablo oluşturuyorum yani o yüzden fonksiyonu çağırıyorum yoksa kapatıp açtıktan sonra görebilirim anca güncellemeyi
                kitaplar();
            }
            else
                MessageBox.Show("Lütfen Listeden Bir Kitap Seçiniz! ");
        }
        //ödünç kısmı bitti

        //gecikme bedeli hesabı
        private void buttonDurum_Click(object sender, EventArgs e)
        {
            DateTime bugunTarihi = DateTime.Now;
            if (labelKitapID.Text != "-")
            {
                int gecikmeBedeli = (int)(bugunTarihi - dateTimePickerOduncTarihi.Value.Date).TotalDays;
                if (gecikmeBedeli > 10)
                {
                    int bedel = (gecikmeBedeli - 10) * 3;
                    label10.Text = bedel.ToString();

                }

            }
        }
        //gecikme bedeli bitti

        //iade işlemi
        private void buttonIade_Click(object sender, EventArgs e)
        {
            if (labelKitapID.Text != "-")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableBooks SET oduncAlan = @P1, tarih = @P2, durum = @P3 WHERE ID= @P4", baglanti);

                    sqlCommand.Parameters.AddWithValue("@P1", "");
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = DBNull.Value;
                    sqlCommand.Parameters.AddWithValue("@P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", labelKitapID.Text);
                    //yazdığımız queryi çalıştırmak için 
                    sqlCommand.ExecuteNonQuery();
                    textBoxOduncAlan.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İade Hatası " + ex.Message);
                }
                finally { baglanti.Close(); }
                // verileri güncelledikten sonra güncel halini tekrardan verileri göstermesi için tekrardan tablo oluşturuyorum yani o yüzden fonksiyonu çağırıyorum yoksa kapatıp açtıktan sonra görebilirim anca güncellemeyi
                kitaplar();
            }

        }

        //textboxları temizleme butonu
        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxBosalt();
        }
        private void textBoxBosalt()
        {
            labelKitapID.Text = "-";
            textBoxKitapAdi.Text = "";
            textBoxYazarAdi.Text = "";
            textBoxYazarSoyadi.Text = "";
            textBoxISBN.Text = "";
            textBoxKitapTurKodu.Text = "";
            textBoxOduncAlan.Text = "";
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            kitapAra();
        }

        //kitap arama fonksitonu
        private void kitapAra()
        {
            try
            {

                string q = "SELECT * FROM TableBooks WHERE kitapAdi LIKE '" + textBoxKitapAdi.Text + "%' AND yazarAdi LIKE'" + textBoxYazarAdi.Text + "%' AND yazarSoyadi LIKE'" + textBoxYazarSoyadi.Text + "%' AND ISBN LIKE'" + textBoxISBN.Text + "%' AND kitapTurKodu LIKE'" + textBoxKitapTurKodu.Text + "%' AND oduncAlan LIKE'" + textBoxOduncAlan.Text + "%' ";
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTumKitaplar_Click(object sender, EventArgs e)
        {
            kitaplar();
        }

        //veritabanından kitap silme işlemi

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (labelKitapID.Text == "-" || labelKitapID.Text == "")
            {
                MessageBox.Show("Lütfen silinecek kitabı seçiniz!");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sil = new SqlCommand("DELETE FROM TableBooks WHERE ID = '" + labelKitapID.Text + "'", baglanti);
                    //sil.Parameters.AddWithValue("@P1", labelKitapID.Text);
                    sil.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { baglanti.Close(); }
                kitaplar();
                textBoxBosalt();

            }
        }

        private void FormKitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
