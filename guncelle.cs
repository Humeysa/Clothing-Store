using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class guncelle : Form
    {
        public guncelle()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-CF2MUPA;Initial Catalog=giyim;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection(conString);  
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "SELECT * from Urunler where Urunid=@Urunid";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@Urunid",textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read()) 
            {
                textBox2.Text = dr["UrunAdi"].ToString();
                textBox3.Text = dr["Cinsiyet"].ToString();
                textBox4.Text = dr["Marka"].ToString();
                textBox5.Text = dr["Renk"].ToString();
                textBox6.Text = dr["Fiyat"].ToString();
                textBox7.Text = dr["StokAdet"].ToString();
                textBox8.Text = dr["Beden"].ToString();
            }
            else
                MessageBox.Show("Ürün Bulunamadı");
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "UPDATE Urunler set UrunAdi=@UrunAdi,Cinsiyet=@Cinsiyet,Marka=@Marka,Renk=@Renk,Fiyat=@Fiyat,StokAdet=@StokAdet,Beden=@Beden where Urunid=@Urunid";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@UrunAdi", textBox2.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", textBox3.Text);
            komut.Parameters.AddWithValue("@Marka", textBox4.Text);
            komut.Parameters.AddWithValue("@Renk", textBox5.Text);
            komut.Parameters.AddWithValue("@Fiyat", textBox6.Text);
            komut.Parameters.AddWithValue("@StokAdet", textBox7.Text);
            komut.Parameters.AddWithValue("@Beden", textBox8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Bilgileri Güncellendi.");
        }
    }
}
