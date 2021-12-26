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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-CF2MUPA;Initial Catalog=giyim;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        string KomutString;


        private void button4_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            SqlDataAdapter adtr;
            komut.CommandText = "SELECT*FROM Musteriler";
            adtr = new SqlDataAdapter(komut.CommandText, baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            //komut.CommandText="INSERT INTO Musteriler(MusteriId,Adi,Soyadi,TcNo,Cinsiyet,KayitTarihi,Adres,Telefon,Eposta) VALUES(

        }
    }
}
