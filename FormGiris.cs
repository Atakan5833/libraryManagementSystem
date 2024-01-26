using System.Data.SqlClient;

namespace KutuphaneGirisSistemi
{
    public partial class FormGiris : Form
    {
        //Kullan�c� giri� yapt�ndan sonra anasayfa form sayfas� a��lacak
        FormKitaplar formKitaplar;
        public FormGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=F58\SQLEXPRESS;Initial Catalog=witchLibrary;Integrated Security=True");

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string sifre = "";
            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT sifre FROM TableUserLogin WHERE kullaniciAdi = @p1", baglanti);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxKullanici.Text);
                SqlDataReader sqlData = sqlKomut.ExecuteReader();

                while(sqlData.Read())
                {
                    sifre = sqlData[0].ToString();
                }

                //label4.Text = sifre;

                if (sifre == textBoxSifre.Text)
                {
                    //Kullan�c� giri� yapt�ndan sonra anasayfa form sayfas� a��lacak
                    formKitaplar = new FormKitaplar();
                    this.Hide();
                    formKitaplar.Show();
                   
                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!");
                    textBoxKullanici.Text = "";
                    textBoxSifre.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ba�lant� Hatas�" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
